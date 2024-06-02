"use strict";
import { globalClass } from '../custom.js';

// Class definition
var branchesList = function () {
    // Shared variables
    var table;
    var datatable;
    var CountriesList;
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
        const filterSearch = document.querySelector('[branches-list-filter="search"]');
        filterSearch.addEventListener('keyup', function (e) {
            datatable.search(e.target.value).draw();
        });
    }

    // Add Branch
    var addNewBranch = () => {
        document.querySelector("#add_new_branch").addEventListener("click", () => {
            // Select Modal Element And Set Title
            const modalEl = document.querySelector("#main_modal");
            document.querySelector("#main_modal .modal-dialog").classList.add("mw-750px");
            jsonlocalizerData().then(data => {
                modalEl.querySelector("h3").innerText = data["add_new_branch"];
            });

            if (modalEl) {
                const modal = new bootstrap.Modal(modalEl);
                $.ajax({
                    url: '/Gym/AddNewBranch',
                    type: 'GET',
                    success: function (data) {
                        $(modalEl.querySelector(".modal-body")).empty().html(data);
                        modal.show();

                        // Get Countries List
                        $.ajax({
                            url: '/Home/GetCountriesList',
                            type: 'GET',
                            success: function (data) {
                                CountriesList = data;
                            }
                        });

                        // Handle Select Country
                        var optionFormat = function (item) {
                            if (!item.id) {
                                return item.text;
                            }

                            var span = document.createElement('span');
                            var template = '';

                            template += '<img src="' + item.element.getAttribute('data-country-flag') + '" class="rounded-circle me-2" style="height:19px;" alt="image"/>';
                            template += item.text;

                            span.innerHTML = template;

                            return $(span);
                        }

                        $('#SelectCountry').select2({
                            minimumResultsForSearch: Infinity,
                            templateSelection: optionFormat,
                            templateResult: optionFormat
                        });

                        $('#SelectCountryCurrency').select2({
                            minimumResultsForSearch: -1
                        });

                        $('#SelectCountryTimeZone').select2({
                            minimumResultsForSearch: -1
                        });

                        document.getElementById('SelectCountry').onchange = function () {
                            var selectedValueId = document.getElementById('SelectCountry').value;
                            console.log(CountriesList);
                            var selectedValueObj = CountriesList.filter(c => c.id == selectedValueId)[0];
                            $("#SelectCountryCurrency").select2("val", selectedValueId);
                            $("#SelectCountryTimeZone").select2("val", selectedValueId);
                            document.querySelector("#BranchContactNumber").innerText = selectedValueObj.callingCode;
                        };

                        // Handle Form Validation
                        const addNewBranchForm = document.getElementById('add_new_branch_form');
                        var addNewBranchValidator;
                        jsonlocalizerData().then(data => {
                            addNewBranchValidator = FormValidation.formValidation(addNewBranchForm,
                                {
                                    fields: {
                                        'CreateBranch.BranchName': {
                                            validators: {
                                                notEmpty: {
                                                    message: data.thisfieldisrequired
                                                }
                                            }
                                        },
                                        'CreateBranch.CountryId': {
                                            validators: {
                                                notEmpty: {
                                                    message: data.thisfieldisrequired
                                                }
                                            }
                                        },
                                        'CreateBranch.Address': {
                                            validators: {
                                                notEmpty: {
                                                    message: data.thisfieldisrequired
                                                }
                                            }
                                        },
                                        'CreateBranch.Email': {
                                            validators: {
                                                notEmpty: {
                                                    message: data.thisfieldisrequired
                                                }
                                            }
                                        },
                                        'CreateBranch.ContactNumber': {
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
                        const submitButton = document.getElementById('add_new_branch_form_submit');
                        submitButton.addEventListener('click', function (e) {
                            // Prevent default button action
                            e.preventDefault();

                            // Validate form before submit
                            if (addNewBranchValidator) {
                                addNewBranchValidator.validate().then(function (status) {
                                    if (status == 'Valid') {
                                        submitButton.setAttribute('data-kt-indicator', 'on');
                                        submitButton.disabled = true;
                                        
                                        var CreateBranchDTO = {};
                                        CreateBranchDTO.BranchName = $('[name="CreateBranch.BranchName"]').val();
                                        CreateBranchDTO.CountryId = $('[name="CreateBranch.CountryId"]').val();
                                        CreateBranchDTO.Address = $('[name="CreateBranch.Address"]').val();
                                        CreateBranchDTO.Email = $('[name="CreateBranch.Email"]').val();
                                        CreateBranchDTO.ContactNumber = $('[name="CreateBranch.ContactNumber"]').val();
                                        console.log(data);

                                        $.ajax({
                                            url: '/Gym/AddNewBranch',
                                            type: 'POST',
                                            data: {
                                                model: CreateBranchDTO
                                            },
                                            dataType: 'json',
                                            success: function (response) {
                                                window.location.href = `/Gym/BranchesList`;
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
                    modalEl.querySelector("h3").innerText = data["edit_group"];
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
                                            submitButton.setAttribute('data-kt-indicator', 'on');
                                            submitButton.disabled = true;

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
                        datatable.row($(parent)).remove().draw(false);
                        // globalClass.handleTooltip();
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
            table = document.querySelector('#branches_list');

            if (!table) {
                return;
            }

            initDatatable();
            handleSearchDatatable();
            addNewBranch();
            //editGroup();
            //deleteGroup();
        }
    };
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
    branchesList.init();
});
