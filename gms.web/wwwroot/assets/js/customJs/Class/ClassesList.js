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

    // Add New Activity
    var handleAddNewActivity = () => {
        document.querySelector("#add_new_activity").addEventListener("click", () => {
            // Select Modal Element And Set Title
            const modalEl = document.querySelector("#main_modal");
            jsonlocalizerData().then(data => {
                modalEl.querySelector("h3").innerText = data["add_new_activity"];
            });

            if (modalEl) {
                modal = new bootstrap.Modal(modalEl);
                $.ajax({
                    url: '/Activity/AddNewActivity',
                    type: 'GET',
                    success: function (data) {
                        $(modalEl.querySelector(".modal-body")).empty().html(data);
                        modal.show();

                        $('#Activity_ActivityCategoryId').select2({
                            minimumResultsForSearch: -1
                        });

                        $('#select_memberships').select2({
                            minimumResultsForSearch: -1
                        });

                        $('#kt_docs_repeater_basic').repeater({
                            initEmpty: false,

                            defaultValues: {
                                'text-input': 'foo'
                            },

                            show: function () {
                                $(this).slideDown();
                            },

                            hide: function (deleteElement) {
                                $(this).slideUp(deleteElement);
                            }
                        });

                        $('.add-new-activity-category-popover-btn').popover();

                        // Handle Form Validation
                        const addNewActivityForm = document.getElementById('add_new_Activity_form');
                        var addNewActivityValidator;
                        jsonlocalizerData().then(data => {
                            addNewActivityValidator = FormValidation.formValidation(addNewActivityForm,
                                {
                                    fields: {
                                        'Activity.ActivityCategoryId': {
                                            validators: {
                                                notEmpty: {
                                                    message: data.thisfieldisrequired
                                                }
                                            }
                                        },
                                        'Activity.Title': {
                                            validators: {
                                                notEmpty: {
                                                    message: data.thisfieldisrequired
                                                }
                                            }
                                        },
                                        'SelectedMembershipIds': {
                                            validators: {
                                                notEmpty: {
                                                    message: data.thisfieldisrequired
                                                }
                                            }
                                        },
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
                        const submitButton = document.getElementById('add_new_Activity_form_submit');
                        submitButton.addEventListener('click', function (e) {
                            // Prevent default button action
                            e.preventDefault();

                            // Validate form before submit
                            if (addNewActivityValidator) {
                                addNewActivityValidator.validate().then(function (status) {
                                    if (status == 'Valid') {
                                        submitButton.setAttribute('data-kt-indicator', 'on');
                                        submitButton.disabled = true;

                                        var textareas = document.querySelectorAll("#kt_docs_repeater_basic textarea");
                                        var activityVideos = [];
                                        textareas.forEach(e => e.value.length > 0 ? activityVideos.push(e.value) : true);
                                        var data = {};
                                        data.Activity = {};
                                        data.Activity.Title = $('[name="Activity.Title"]').val();
                                        data.Activity.ActivityCategoryId = $('[name="Activity.ActivityCategoryId"]').val();
                                        data.MembershipIds = $('[name="SelectedMembershipIds"]').val();
                                        data.ActivityVideos = activityVideos;

                                        $.ajax({
                                            url: '/Activity/AddNewActivity',
                                            type: 'POST',
                                            data: {
                                                activityModal: data
                                            },
                                            dataType: 'json',
                                            success: function (response) {
                                                console.log(response);
                                                window.location.href = `/Activity/Index`;
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

    // Edite Group
    var editActivity = () => {
        // Select all delete buttons
        const editButtons = table.querySelectorAll('.edit-activity-btn');

        editButtons.forEach(Button => {
            Button.addEventListener("click", function (e) {
                // Select Modal Element And Set Title
                const modalEl = document.querySelector("#main_modal");
                jsonlocalizerData().then(data => {
                    modalEl.querySelector("h3").innerText = data["edit_activity"];
                });

                if (modalEl) {
                    const modal = new bootstrap.Modal(modalEl);
                    $.ajax({
                        url: '/Activity/EditActivity',
                        type: 'Post',
                        data: {
                            id: this.dataset.id
                        },
                        success: function (data) {
                            $(modalEl.querySelector(".modal-body")).empty().html(data);
                            modal.show();

                            $('#Activity_ActivityCategoryId').select2({
                                minimumResultsForSearch: -1
                            });

                            $('#select_memberships').select2({
                                minimumResultsForSearch: -1
                            });

                            $('#kt_docs_repeater_basic').repeater({
                                initEmpty: false,
                                defaultValues: {
                                    'text-input': ''
                                },
                                show: function () {
                                    $(this).find('textarea').val('');
                                    $(this).slideDown();
                                },
                                hide: function (deleteElement) {
                                    $(this).slideUp(deleteElement);
                                }
                            });

                            $.ajax({
                                url: '/Activity/GetActivityMembershipsById',
                                type: 'GET',
                                data: {
                                    activityId: $('[name="Activity.Id"]').val()
                                },
                                dataType: 'json',
                                success: function (response) {
                                    var membershipIds = [];
                                    response.data.forEach(m => membershipIds.push(m.membershipPlanId));
                                    $('#select_memberships').val(membershipIds).trigger('change');
                                }
                            });

                            // Handle Form Validation
                            const updateActivityForm = document.getElementById('update_Activity_form');
                            var updateActivityValidator;
                            jsonlocalizerData().then(data => {
                                updateActivityValidator = FormValidation.formValidation(updateActivityForm,
                                    {
                                        fields: {
                                            'Activity.ActivityCategoryId': {
                                                validators: {
                                                    notEmpty: {
                                                        message: data.thisfieldisrequired
                                                    }
                                                }
                                            },
                                            'Activity.Title': {
                                                validators: {
                                                    notEmpty: {
                                                        message: data.thisfieldisrequired
                                                    }
                                                }
                                            },
                                            'SelectedMembershipIds': {
                                                validators: {
                                                    notEmpty: {
                                                        message: data.thisfieldisrequired
                                                    }
                                                }
                                            },
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
                            const submitButton = document.getElementById('update_activity_form_submit');
                            submitButton.addEventListener('click', function (e) {
                                // Prevent default button action
                                e.preventDefault();

                                // Validate form before submit
                                if (updateActivityValidator) {
                                    updateActivityValidator.validate().then(function (status) {
                                        if (status == 'Valid') {
                                            submitButton.setAttribute('data-kt-indicator', 'on');
                                            submitButton.disabled = true;

                                            var textareas = document.querySelectorAll("#kt_docs_repeater_basic textarea");
                                            var activityVideos = [];
                                            textareas.forEach(e => activityVideos.push(e.value));
                                            var data = {};
                                            data.Activity = {};
                                            data.Activity.Id = $('[name="Activity.Id"]').val();
                                            data.Activity.Title = $('[name="Activity.Title"]').val();
                                            data.Activity.ActivityCategoryId = $('[name="Activity.ActivityCategoryId"]').val();
                                            data.MembershipIds = $('[name="SelectedMembershipIds"]').val();
                                            data.ActivityVideos = activityVideos;
                                            console.log(data);

                                            $.ajax({
                                                url: '/Activity/UpdateActivity',
                                                type: 'POST',
                                                data: {
                                                    updateActivityDTO: data
                                                },
                                                dataType: 'json',
                                                success: function (response) {
                                                    console.log(response);
                                                    window.location.href = `/Activity/Index`;
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
            //handleAddNewActivity();
            //editActivity();
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
