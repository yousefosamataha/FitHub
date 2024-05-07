"use strict";
import { globalClass } from '../custom.js';

// Class definition
var groupsList = function () {
    // Shared variables
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
                { orderable: false, targets: 2 }
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
        const filterSearch = document.querySelector('[groups-list-filter="search"]');
        filterSearch.addEventListener('keyup', function (e) {
            datatable.search(e.target.value).draw();
        });
    }

    // Add New Activity
    var handleAddNewGroup = () => {
        document.querySelector("#add_new_activity").addEventListener("click", () => {
            // Select Modal Element And Set Title
            const modalEl = document.querySelector("#main_modal");
            jsonlocalizerData().then(data => {
                modalEl.querySelector("h3").innerText = data["add_new_activity"];
            });

            if (modalEl) {
                const modal = new bootstrap.Modal(modalEl);
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
                                        var data = {};
                                        data.Activity = {};
                                        data.Activity.Title = $('[name="Activity.Title"]').val();
                                        data.Activity.ActivityCategoryId = $('[name="Activity.ActivityCategoryId"]').val();
                                        data.MembershipIds = $('[name="SelectedMembershipIds"]').val();
                                        console.log(data);
                                        $.ajax({
                                            url: '/Activity/AddNewActivity',
                                            type: 'POST',
                                            data: {
                                                activityModal: data
                                            },
                                            dataType: 'json',
                                            success: function (response) {
                                                console.log(response);
                                                //window.location.href = `/Gym/GroupsList`;
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
    var editGroup = () => {
        // Select all delete buttons
        const editButtons = table.querySelectorAll('.edit-group-btn');

        editButtons.forEach(Button => {
            Button.addEventListener("click", function (e) {
                // Select Modal Element And Set Title
                const modalEl = document.querySelector("#main_modal");
                jsonlocalizerData().then(data => {
                    modalEl.querySelector("h3").innerText = "Edit";
                });

                if (modalEl) {
                    const modal = new bootstrap.Modal(modalEl);
                    $.ajax({
                        url: '/Gym/EditGroup',
                        type: 'Post',
                        data: {
                            id: this.dataset.id
                        },
                        success: function (data) {
                            $(modalEl.querySelector(".modal-body")).empty().html(data);
                            modal.show();

                            // Handle Input Image
                            var imageInputElement = document.querySelector("#image_input_control");
                            var imageInput = new KTImageInput(imageInputElement);
                            var base64Image = imageInput.src.split('url("')[1].split('")')[0];
                            $("#image_input_control .btn[data-kt-image-input-action='remove']").show();
                            $("#image_input_control .btn[data-kt-image-input-action='remove']").css("display", "flex");

                            $("#image_input_control .btn[data-kt-image-input-action='remove']").click(function () {
                                base64Image = null;
                            });

                            // Handle Form Validation
                            const addNewGroupForm = document.getElementById('update_group_form');
                            var addNewGroupValidator;
                            jsonlocalizerData().then(data => {
                                addNewGroupValidator = FormValidation.formValidation(addNewGroupForm,
                                    {
                                        fields: {
                                            'Name': {
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

                            document.getElementById('Image').addEventListener('change', function (event) {
                                var file = event.target.files[0];
                                var reader = new FileReader();
                                reader.onload = function (event) {
                                    base64Image = event.target.result;
                                    console.log(base64Image);
                                };
                                reader.readAsDataURL(file);
                            });

                            // Handle Form Submition
                            const submitButton = document.getElementById('update_group_form_submit');
                            submitButton.addEventListener('click', function (e) {
                                // Prevent default button action
                                e.preventDefault();

                                // Validate form before submit
                                if (addNewGroupValidator) {
                                    addNewGroupValidator.validate().then(function (status) {
                                        if (status == 'Valid') {
                                            var data = {};
                                            data.Id = $('[name="Id"]').val();
                                            data.Name = $('[name="Name"]').val();
                                            data.Image = base64Image != '' ? base64Image : null;

                                            $.ajax({
                                                url: '/Gym/UpdateGroup',
                                                type: 'POST',
                                                data: {
                                                    modelDTO: data
                                                },
                                                dataType: 'json',
                                                success: function (response) {
                                                    console.log(response);
                                                    window.location.href = `/Gym/GroupsList`;
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
    var deleteGroup = () => {
        // Select all delete buttons
        const deleteButtons = table.querySelectorAll('.delete-group-btn');

        deleteButtons.forEach(d => {
            d.addEventListener("click", function (e) {
                // Select parent row
                const parent = this.closest('tr');

                $.ajax({
                    url: '/Gym/DeleteGroup',
                    type: 'POST',
                    data: {
                        id: this.dataset.id
                    },
                    success: function (response) {
                        // Remove current row
                        datatable.row($(parent)).remove().draw();
                        globalClass.handleTooltip();
                        toastr.success("Group Deleted Successfully!");
                    },
                    error: function (xhr, status, error) {
                        console.error('Error:', error);
                    }
                });
            });
        });
    }

    // Public methods
    return {
        init: function () {
            table = document.querySelector('#activities_list');

            if (!table) {
                return;
            }

            initDatatable();
            handleSearchDatatable();
            handleAddNewGroup();
            //editGroup();
            //deleteGroup();
        }
    };
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
    groupsList.init();
});
