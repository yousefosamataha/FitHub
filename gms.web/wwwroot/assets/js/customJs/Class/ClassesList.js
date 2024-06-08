"use strict";
import { globalClass } from '../custom.js';

// Class definition
var classesList = function () {
    // Shared variables
    var modal;
    var table;
    var datatable;
    var currentLanguage = globalClass.checkLanguage(".AspNetCore.Culture").split("=").slice(-1)[0];
    var datatableLanguage = currentLanguage == "ar-EG" ? "ar" : currentLanguage == "fr-FR" ? "fr" : "en";
    const hostName = window.location.origin;
    var jsonlocalizerData = () => {
        return $.ajax({
            url: '/Home/GetJsonlocalizer',
            type: 'GET',
            data: { culture: currentLanguage },
            dataType: 'json'
        });
    }

    // Init Datatable
    var initDatatable = function () {
        // Init datatable
        datatable = $(table).DataTable({
            language: {
                url: `${hostName}/assets/plugins/localization/datatable-${datatableLanguage}.json`,
            },
            "info": true,
            'order': [],
            'pageLength': 6,
            'columnDefs': [
                { orderable: false, targets: 5 }
            ],
            "lengthMenu": [[-1, 5, 10, 50], ["All", 5, 10, 50]],
            "pagingType": "full_numbers"
        });

        // Re-init functions on datatable re-draws
        datatable.on('draw', function () {
        });
    }

    // datatable pageing tap number
    $.fn.DataTable.ext.pager.numbers_length = 5;

    // Search Datatable
    var handleSearchDatatable = () => {
        const filterSearch = document.querySelector('[class-list-filter="search"]');
        filterSearch.addEventListener('keyup', function (e) {
            datatable.search(e.target.value).draw();
        });
    }

    // Add New Class
    var handleAddNewClass = () => {
        document.querySelector("#add_new_class").addEventListener("click", () => {
            // Select Modal Element And Set Title
            const modalEl = document.querySelector("#main_modal");
            jsonlocalizerData().then(data => {
                modalEl.querySelector("h3").innerText = data["add_new_class"];
            });

            if (modalEl) {
                modal = new bootstrap.Modal(modalEl);
                $.ajax({
                    url: '/Class/CreateNewClass',
                    type: 'GET',
                    success: function (data) {
                        $(modalEl.querySelector(".modal-body")).empty().html(data);
                        modal.show();

                        $('#Class_GymLocationId').select2({
                            minimumResultsForSearch: -1
                        });

                        $('#WeekDayIds').select2({
                            minimumResultsForSearch: -1
                        });

                        $("#Class_StartTime").flatpickr({
                            enableTime: true,
                            noCalendar: true,
                            time_24hr: false,
                            dateFormat: "h:i K",
                        });

                        $("#Class_EndTime").flatpickr({
                            enableTime: true,
                            noCalendar: true,
                            time_24hr: false,
                            dateFormat: "h:i K",
                        });

                        $('.add-new-gym-location-popover-btn').popover();

                        // Handle Form Validation
                        const addNewClassForm = document.getElementById('add_new_class_form');
                        var addNewClassValidator;
                        jsonlocalizerData().then(data => {
                            addNewClassValidator = FormValidation.formValidation(addNewClassForm,
                                {
                                    fields: {
                                        'Class.ClassName': {
                                            validators: {
                                                notEmpty: {
                                                    message: data.thisfieldisrequired
                                                }
                                            }
                                        },
                                        'Class.GymLocationId': {
                                            validators: {
                                                notEmpty: {
                                                    message: data.thisfieldisrequired
                                                }
                                            }
                                        },
                                        'Class.ClassFees': {
                                            validators: {
                                                notEmpty: {
                                                    message: data.thisfieldisrequired
                                                }
                                            }
                                        },
                                        'WeekDayIds': {
                                            validators: {
                                                notEmpty: {
                                                    message: data.thisfieldisrequired
                                                }
                                            }
                                        },
                                        'Class.StartTime': {
                                            validators: {
                                                notEmpty: {
                                                    message: data.thisfieldisrequired
                                                }
                                            }
                                        },
                                        'Class.EndTime': {
                                            validators: {
                                                notEmpty: {
                                                    message: data.thisfieldisrequired
                                                }
                                            }
                                        }
                                    },
                                    plugins: {
                                        trigger: new FormValidation.plugins.Trigger(),
                                        bootstrap: new FormValidation.plugins.Bootstrap5({
                                            rowSelector: '.fv-row',
                                            eleInvalidClass: '',
                                            eleValidClass: ''
                                        })
                                    }
                                }
                            );
                        });

                        // Handle Form Submition
                        const submitButton = document.getElementById('add_new_class_form_submit');
                        submitButton.addEventListener('click', function (e) {
                            // Prevent default button action
                            e.preventDefault();

                            // Validate form before submit
                            if (addNewClassValidator) {
                                addNewClassValidator.validate().then(function (status) {
                                    if (status == 'Valid') {
                                        submitButton.setAttribute('data-kt-indicator', 'on');
                                        submitButton.disabled = true;

                                        var data = {};
                                        data.Class = {};
                                        data.Class.ClassName = $('[name="Class.ClassName"]').val();
                                        data.Class.GymLocationId = $('[name="Class.GymLocationId"]').val();
                                        data.Class.ClassFees = $('[name="Class.ClassFees"]').val();
                                        data.WeekDayIds = $('[name="WeekDayIds"]').val();
                                        data.Class.StartTime = $('[name="Class.StartTime"]').val();
                                        data.Class.EndTime = $('[name="Class.EndTime"]').val();

                                        $.ajax({
                                            url: '/Class/CreateNewClass',
                                            type: 'POST',
                                            data: {
                                                addClassModel: data
                                            },
                                            dataType: 'json',
                                            success: function (response) {
                                                window.location.href = `/Class`;
                                            }
                                        });
                                    }
                                });
                            }
                        });
                    },
                    error: function (xhr) {
                        console.log(xhr);
                        if (xhr.status == 403) {
                            jsonlocalizerData().then(data => {
                                toastr.error(data["you_do_not_have_permission_to_access_this_action"]);
                            });
                        }
                    }
                });
            }
        });
    }

    // Edite Class
    var editClass = () => {
        // Select all delete buttons
        const editButtons = table.querySelectorAll('.edit-class-btn');

        editButtons.forEach(Button => {
            Button.addEventListener("click", function (e) {
                // Select Modal Element And Set Title
                const modalEl = document.querySelector("#main_modal");
                jsonlocalizerData().then(data => {
                    modalEl.querySelector("h3").innerText = data["edit_class"];
                });

                if (modalEl) {
                    const modal = new bootstrap.Modal(modalEl);
                    $.ajax({
                        url: '/Class/EditClass',
                        type: 'Get',
                        data: {
                            id: this.dataset.id
                        },
                        success: function (data) {
                            $(modalEl.querySelector(".modal-body")).empty().html(data);
                            modal.show();

                            $('#Class_GymLocationId').select2({
                                minimumResultsForSearch: -1
                            });

                            $('#WeekDayIds').select2({
                                minimumResultsForSearch: -1
                            });

                            $("#Class_StartTime").flatpickr({
                                enableTime: true,
                                noCalendar: true,
                                time_24hr: false,
                                dateFormat: "h:i K",
                            });

                            $("#Class_EndTime").flatpickr({
                                enableTime: true,
                                noCalendar: true,
                                time_24hr: false,
                                dateFormat: "h:i K",
                            });

                            $.ajax({
                                url: '/Class/GetClassScheduleDaysById',
                                type: 'GET',
                                data: {
                                    classId: $('[name="Class.Id"]').val()
                                },
                                dataType: 'json',
                                success: function (response) {
                                    var weekDayIds = [];
                                    response.data.forEach(cd => weekDayIds.push(cd.weekDayId));
                                    $('#WeekDayIds').val(weekDayIds).trigger('change');
                                }
                            });

                            // Handle Form Validation
                            const updateClassForm = document.getElementById('update_class_form');
                            var updateClassValidator;
                            jsonlocalizerData().then(data => {
                                updateClassValidator = FormValidation.formValidation(updateClassForm,
                                    {
                                        fields: {
                                            'Class.ClassName': {
                                                validators: {
                                                    notEmpty: {
                                                        message: data.thisfieldisrequired
                                                    }
                                                }
                                            },
                                            'Class.GymLocationId': {
                                                validators: {
                                                    notEmpty: {
                                                        message: data.thisfieldisrequired
                                                    }
                                                }
                                            },
                                            'Class.ClassFees': {
                                                validators: {
                                                    notEmpty: {
                                                        message: data.thisfieldisrequired
                                                    }
                                                }
                                            },
                                            'WeekDayIds': {
                                                validators: {
                                                    notEmpty: {
                                                        message: data.thisfieldisrequired
                                                    }
                                                }
                                            },
                                            'Class.StartTime': {
                                                validators: {
                                                    notEmpty: {
                                                        message: data.thisfieldisrequired
                                                    }
                                                }
                                            },
                                            'Class.EndTime': {
                                                validators: {
                                                    notEmpty: {
                                                        message: data.thisfieldisrequired
                                                    }
                                                }
                                            }
                                        },
                                        plugins: {
                                            trigger: new FormValidation.plugins.Trigger(),
                                            bootstrap: new FormValidation.plugins.Bootstrap5({
                                                rowSelector: '.fv-row',
                                                eleInvalidClass: '',
                                                eleValidClass: ''
                                            })
                                        }
                                    }
                                );
                            });

                            // Handle Form Submition
                            const submitButton = document.getElementById('update_class_form_submit');
                            submitButton.addEventListener('click', function (e) {
                                // Prevent default button action
                                e.preventDefault();

                                // Validate form before submit
                                if (updateClassValidator) {
                                    updateClassValidator.validate().then(function (status) {
                                        if (status == 'Valid') {
                                            submitButton.setAttribute('data-kt-indicator', 'on');
                                            submitButton.disabled = true;

                                            var data = {};
                                            data.Class = {};
                                            data.Class.Id = $('[name="Class.Id"]').val();
                                            data.Class.ClassName = $('[name="Class.ClassName"]').val();
                                            data.Class.GymLocationId = $('[name="Class.GymLocationId"]').val();
                                            data.Class.ClassFees = $('[name="Class.ClassFees"]').val();
                                            data.WeekDayIds = $('[name="WeekDayIds"]').val();
                                            data.Class.StartTime = $('[name="Class.StartTime"]').val();
                                            data.Class.EndTime = $('[name="Class.EndTime"]').val();

                                            $.ajax({
                                                url: '/Class/EditClass',
                                                type: 'POST',
                                                data: {
                                                    updateClassModel: data
                                                },
                                                dataType: 'json',
                                                success: function (response) {
                                                    window.location.href = `/Class`;
                                                }
                                            });
                                        }
                                    });
                                }
                            });
                        },
                        error: function (xhr) {
                            if (xhr.status == 403) {
                                jsonlocalizerData().then(data => {
                                    toastr.error(data["you_do_not_have_permission_to_access_this_action"]);
                                });
                            }
                        }
                    });
                }
            });
        });
    }

    // Delete Class
    var deleteClass = () => {
        // Select all delete buttons
        const deleteButtons = table.querySelectorAll('.delete-class-btn');

        deleteButtons.forEach(d => {
            d.addEventListener("click", function (e) {
                // Select parent row
                const parent = this.closest('tr');

                $.ajax({
                    url: '/Class/DeleteClass',
                    type: 'POST',
                    data: {
                        id: this.dataset.id
                    },
                    success: function (response) {
                        // Remove current row
                        datatable.row($(parent)).remove().draw(false);
                        toastr.success("Class Deleted Successfully!");
                    },
                    error: function (xhr) {
                        if (xhr.status == 403) {
                            jsonlocalizerData().then(data => {
                                toastr.error(data["you_do_not_have_permission_to_access_this_action"]);
                            });
                        }
                    }
                });
            });
        });
    }

    // Add New Gym Location
    var handleAddNewGymLocation = () => {
        $(document).on('click', '.add-new-gym-location', function () {
            const modalEl = document.querySelector("#main_modal");
            var gymLocationTable;
            document.querySelector("#main_modal .modal-dialog").classList.add("mw-750px");
            jsonlocalizerData().then(data => {
                modalEl.querySelector("h3").innerText = data["add_new_location"];
            });

            $.ajax({
                url: '/Gym/CreateNewGymLocation',
                type: 'GET',
                success: function (data) {
                    $(modalEl.querySelector(".modal-body")).empty().html(data);
                    $('.popover').remove();

                    // Init Datatable
                    gymLocationTable = $("#gym_location_list").DataTable({
                        language: {
                            url: `${hostName}/assets/plugins/localization/datatable-${datatableLanguage}.json`,
                        },
                        "info": true,
                        'order': [],
                        'pageLength': 4,
                        'columnDefs': [
                            { orderable: false, targets: 1 }
                        ],
                        "lengthMenu": [[-1, 5, 10, 50], ["All", 5, 10, 50]],
                        "pagingType": "full_numbers"
                    });

                    // Handle Form Validation
                    const addNewGymLocationForm = document.getElementById('add_new_gym_location_form');
                    var addNewGymLocationValidator;
                    jsonlocalizerData().then(data => {
                        addNewGymLocationValidator = FormValidation.formValidation(addNewGymLocationForm,
                            {
                                fields: {
                                    'CreateGymLocation.Name': {
                                        validators: {
                                            notEmpty: {
                                                message: data.thisfieldisrequired
                                            }
                                        }
                                    }
                                },
                                plugins: {
                                    trigger: new FormValidation.plugins.Trigger(),
                                    bootstrap: new FormValidation.plugins.Bootstrap5({
                                        rowSelector: '.fv-row',
                                        eleInvalidClass: '',
                                        eleValidClass: ''
                                    })
                                }
                            }
                        );
                    });

                    // Select all delete buttons
                    const deleteButtons = document.querySelectorAll('.delete-gym-location-btn');
                    deleteButtons.forEach(d => {
                        d.addEventListener("click", function (e) {
                            // Select parent row
                            const parent = this.closest('tr');

                            $.ajax({
                                url: '/Gym/DeleteGymLocation',
                                type: 'POST',
                                data: {
                                    id: this.dataset.id
                                },
                                success: function (response) {
                                    // Remove current row
                                    gymLocationTable.row($(parent)).remove().draw(false);
                                    toastr.success("Location Deleted Successfully!");
                                },
                                error: function (xhr, status, error) {
                                    console.error('Error:', error);
                                }
                            });
                        });
                    });

                    // Handle Form Submition
                    const submitButton = document.getElementById('add_new_gym_location_form_submit');
                    submitButton.addEventListener('click', function (e) {
                        // Prevent default button action
                        e.preventDefault();

                        // Validate form before submit
                        if (addNewGymLocationValidator) {
                            addNewGymLocationValidator.validate().then(function (status) {
                                if (status == 'Valid') {
                                    submitButton.setAttribute('data-kt-indicator', 'on');
                                    submitButton.disabled = true;

                                    var data = {};
                                    data.Name = $('[name="CreateGymLocation.Name"]').val();

                                    $.ajax({
                                        url: '/Gym/CreateNewGymLocation',
                                        type: 'POST',
                                        data: {
                                            gymLocationModal: data
                                        },
                                        dataType: 'json',
                                        success: function (response) {
                                            modal.hide();
                                        }
                                    });
                                }
                            });
                        }
                    });
                }
            });
        });
    }

    // View Classes Schedule
    var viewClassesSchedule = () => {
        document.querySelector("#view-classes-schedule").addEventListener("click", () => { 
            const modalEl = document.querySelector("#main_modal");
            // document.querySelector("#main_modal .modal-dialog").classList.add("mw-750px");
            jsonlocalizerData().then(data => {
                modalEl.querySelector("h3").innerText = data["classes_schedule"];
            });

            if (modalEl) {
                modal = new bootstrap.Modal(modalEl);
                $.ajax({
                    url: '/Class/ClassesSchedule',
                    type: 'GET',
                    success: function (data) {
                        $(modalEl.querySelector(".modal-body")).empty().html(data);
                        modal.show();
                    }
                });
            }
        });
    }

    // Public methods
    return {
        init: function () {
            table = document.querySelector('#Class_list');

            if (!table) {
                return;
            }

            initDatatable();
            handleSearchDatatable();
            handleAddNewClass();
            editClass();
            deleteClass();
            handleAddNewGymLocation();
            viewClassesSchedule();
        }
    };
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
    classesList.init();
});
