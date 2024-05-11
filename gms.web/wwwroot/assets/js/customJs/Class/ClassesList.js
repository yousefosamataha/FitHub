"use strict";
import { globalClass } from '../custom.js';

// Class definition
var activitiesList = function () {
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
                    url: '/Class/AddNewClass',
                    type: 'GET',
                    success: function (data) {
                        $(modalEl.querySelector(".modal-body")).empty().html(data);
                        modal.show();

                        $('#Class_GymLocationId').select2({
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

                        //$('.add-new-activity-category-popover-btn').popover();

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
                                        data.Class.StartTime = $('[name="Class.StartTime"]').val();
                                        data.Class.EndTime = $('[name="Class.EndTime"]').val();

                                        $.ajax({
                                            url: '/Class/AddNewClass',
                                            type: 'POST',
                                            data: {
                                                createClassModel: data.Class
                                            },
                                            dataType: 'json',
                                            success: function (response) {
                                                window.location.href = `/Class/Index`;
                                            }
                                        });
                                    }
                                });
                            }
                        });
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
                        type: 'Post',
                        data: {
                            id: this.dataset.id
                        },
                        success: function (data) {
                            $(modalEl.querySelector(".modal-body")).empty().html(data);
                            modal.show();

                            $('#Class_GymLocationId').select2({
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

                            //$.ajax({
                            //    url: '/Activity/GetActivityMembershipsById',
                            //    type: 'GET',
                            //    data: {
                            //        activityId: $('[name="Activity.Id"]').val()
                            //    },
                            //    dataType: 'json',
                            //    success: function (response) {
                            //        var membershipIds = [];
                            //        response.data.forEach(m => membershipIds.push(m.membershipPlanId));
                            //        $('#select_memberships').val(membershipIds).trigger('change');
                            //    }
                            //});

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
                                            data.Class.ClassName = $('[name="Class.ClassName"]').val();
                                            data.Class.GymLocationId = $('[name="Class.GymLocationId"]').val();
                                            data.Class.ClassFees = $('[name="Class.ClassFees"]').val();
                                            data.Class.StartTime = $('[name="Class.StartTime"]').val();
                                            data.Class.EndTime = $('[name="Class.EndTime"]').val();
                                            console.log(data);

                                            //$.ajax({
                                            //    url: '/Class/UpdateClass',
                                            //    type: 'POST',
                                            //    data: {
                                            //        updateClassDTO: data
                                            //    },
                                            //    dataType: 'json',
                                            //    success: function (response) {
                                            //        console.log(response);
                                            //        window.location.href = `/Activity/Index`;
                                            //    }
                                            //});
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

    // Delete Group
    var deleteActivity = () => {
        // Select all delete buttons
        const deleteButtons = table.querySelectorAll('.delete-activity-btn');

        deleteButtons.forEach(d => {
            d.addEventListener("click", function (e) {
                // Select parent row
                const parent = this.closest('tr');

                $.ajax({
                    url: '/Activity/DeleteActivity',
                    type: 'POST',
                    data: {
                        id: this.dataset.id
                    },
                    success: function (response) {
                        // Remove current row
                        datatable.row($(parent)).remove().draw(false);
                        // globalClass.handleTooltip();
                        toastr.success("Activity Deleted Successfully!");
                    },
                    error: function (xhr, status, error) {
                        console.error('Error:', error);
                    }
                });
            });
        });
    }

    // Show Activity Videos
    var showActivityVideos = () => {
        // Select all delete buttons
        const showButtons = table.querySelectorAll('.show-activity-videos-btn');

        showButtons.forEach(s => {
            s.addEventListener("click", function (e) {
                window.location.href = `/Activity/ActivityVideos?activityId=${this.dataset.id}`;
            });
        });
    }

    // Add New Activity Category
    var handleAddNewActivityCategory = () => {
        $(document).on('click', '.add-new-activity-category', function () {
            const modalEl = document.querySelector("#main_modal");
            var activityCategoryTable;
            document.querySelector("#main_modal .modal-dialog").classList.add("mw-750px");
            jsonlocalizerData().then(data => {
                modalEl.querySelector("h3").innerText = data["add_new_activity_category"];
            });

            $.ajax({
                url: '/Activity/AddNewActivityCategory',
                type: 'GET',
                success: function (data) {
                    $(modalEl.querySelector(".modal-body")).empty().html(data);
                    $('.popover').remove();

                    // Init Datatable
                    activityCategoryTable = $("#activity_Category_list").DataTable({
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
                    const addNewActivityCategoryForm = document.getElementById('add_new_activity_category_form');
                    var addNewActivityCategoryValidator;
                    jsonlocalizerData().then(data => {
                        addNewActivityCategoryValidator = FormValidation.formValidation(addNewActivityCategoryForm,
                            {
                                fields: {
                                    'CreateActivityCategory.Name': {
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
                    const deleteButtons = document.querySelectorAll('.delete-activity-category-btn');
                    deleteButtons.forEach(d => {
                        d.addEventListener("click", function (e) {
                            // Select parent row
                            const parent = this.closest('tr');

                            $.ajax({
                                url: '/Activity/DeleteActivityCategory',
                                type: 'POST',
                                data: {
                                    id: this.dataset.id
                                },
                                success: function (response) {
                                    // Remove current row
                                    activityCategoryTable.row($(parent)).remove().draw(false);
                                    toastr.success("Activity Category Deleted Successfully!");
                                },
                                error: function (xhr, status, error) {
                                    console.error('Error:', error);
                                }
                            });
                        });
                    });

                    // Handle Form Submition
                    const submitButton = document.getElementById('add_new_Activity_category_form_submit');
                    submitButton.addEventListener('click', function (e) {
                        // Prevent default button action
                        e.preventDefault();

                        // Validate form before submit
                        if (addNewActivityCategoryValidator) {
                            addNewActivityCategoryValidator.validate().then(function (status) {
                                if (status == 'Valid') {
                                    submitButton.setAttribute('data-kt-indicator', 'on');
                                    submitButton.disabled = true;

                                    var data = {};
                                    data.Name = $('[name="CreateActivityCategory.Name"]').val();

                                    $.ajax({
                                        url: '/Activity/AddNewActivityCategory',
                                        type: 'POST',
                                        data: {
                                            activityCategoryModal: data
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
            //deleteActivity();
            //showActivityVideos();
            //handleAddNewActivityCategory();
        }
    };
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
    activitiesList.init();
});
