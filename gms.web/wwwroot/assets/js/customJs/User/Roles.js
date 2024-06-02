"use strict";
import { globalClass } from '../custom.js';

// Class definition
var roles = function () {
    // Shared variables
    var currentLanguage = globalClass.checkLanguage(".AspNetCore.Culture").split("=").slice(-1)[0];
    var jsonlocalizerData = () => {
        return $.ajax({
            url: '/Home/GetJsonlocalizer',
            type: 'GET',
            data: { culture: currentLanguage },
            dataType: 'json'
        });
    }

    // Add Role
    var addRole = () => {
        const addRoleButton = document.querySelector('#add_new_role');

        addRoleButton.addEventListener("click", () => {
            const modalEl = document.querySelector("#main_modal");
            document.querySelector("#main_modal .modal-dialog").classList.add("mw-750px");
            jsonlocalizerData().then(data => {
                modalEl.querySelector("h3").innerText = data["add_new_role"];
            });

            if (modalEl) {
                const modal = new bootstrap.Modal(modalEl);
                $.ajax({
                    url: '/Roles/AddRole',
                    type: 'GET',
                    success: function (data) {
                        $(modalEl.querySelector(".modal-body")).empty().html(data);
                        modal.show();

                        // Handle Form Validation
                        const addRoleForm = document.getElementById('add_role_form');
                        var addRoleValidator;
                        jsonlocalizerData().then(data => {
                            addRoleValidator = FormValidation.formValidation(addRoleForm,
                                {
                                    fields: {
                                        'RoleName': {
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
                        const submitButton = document.getElementById('add_form_submit');
                        submitButton.addEventListener('click', function (e) {
                            // Prevent default button action
                            e.preventDefault();

                            // Validate form before submit
                            if (addRoleValidator) {
                                addRoleValidator.validate().then(function (status) {
                                    if (status == 'Valid') {
                                        submitButton.setAttribute('data-kt-indicator', 'on');
                                        submitButton.disabled = true;
                                        addRoleForm.submit();
                                    }
                                });
                            }
                        });
                    }
                });
            }
        });
    }

    // Edit Role
    var editRole = () => {
        document.querySelectorAll(".edit-role-btn").forEach(e => {
            e.addEventListener("click", function () {
                const modalEl = document.querySelector("#main_modal");
                document.querySelector("#main_modal .modal-dialog").classList.add("mw-750px");
                jsonlocalizerData().then(data => {
                    modalEl.querySelector("h3").innerText = data["edit_role"];
                });

                if (modalEl) {
                    const modal = new bootstrap.Modal(modalEl);
                    $.ajax({
                        url: '/Roles/EditRole',
                        type: 'GET',
                        data: {
                            roleId: this.dataset.id
                        },
                        success: function (data) {
                            $(modalEl.querySelector(".modal-body")).empty().html(data);
                            modal.show();

                            // Handle Form Validation
                            const addRoleForm = document.getElementById('edit_role_form');
                            var addRoleValidator;
                            jsonlocalizerData().then(data => {
                                addRoleValidator = FormValidation.formValidation(addRoleForm,
                                    {
                                        fields: {
                                            'RoleName': {
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
                            const submitButton = document.getElementById('edit_form_submit');
                            submitButton.addEventListener('click', function (e) {
                                // Prevent default button action
                                e.preventDefault();

                                // Validate form before submit
                                if (addRoleValidator) {
                                    addRoleValidator.validate().then(function (status) {
                                        if (status == 'Valid') {
                                            submitButton.setAttribute('data-kt-indicator', 'on');
                                            submitButton.disabled = true;
                                            addRoleForm.submit();
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

    // Edit Role
    var deleteRole = () => {
        document.querySelectorAll(".delete-role-btn").forEach(e => {
            e.addEventListener("click", function () {
                $.ajax({
                    url: '/Roles/DeleteRole',
                    type: 'POST',
                    data: {
                        roleId: this.dataset.id
                    },
                    success: function (res) {
                        if (res.success) {
                            toastr.success("Role Deleted Successfully!");
                            window.location.href = `/Roles`;
                        } else {
                            toastr.error("This Role Is Not Deletable!");
                        }
                    }
                });
            });
        });
    }

    return {
        init: function () {
            editRole();
            addRole();
            deleteRole();
        }
    };
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
    roles.init();
});
