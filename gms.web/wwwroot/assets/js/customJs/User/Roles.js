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

    // Handle Add Payment
    var handleAddNewRole = () => {
        // Select all delete buttons
        const addNewRoleButton = document.querySelector('#add_new_role');
        addNewRoleButton.addEventListener("click", function (e) {
            // Select Modal Element And Set Title
            const modalEl = document.querySelector("#main_modal");
            jsonlocalizerData().then(data => {
                modalEl.querySelector("h3").innerText = data["add_new_role"];
            });
            //var modelData = {};
            //modelData.MemberMembershipId = this.dataset.id;
            //modelData.Price = this.dataset.price;
            //modelData.PiadAmount = this.dataset.piadAmount;
            //modelData.DueAmount = this.dataset.dueAmount;
            //modelData.SignupFee = this.dataset.signupFee;

            //if (modalEl) {
            //    const modal = new bootstrap.Modal(modalEl);
            //    $.ajax({
            //        url: '/Membership/AddMembershipPayment',
            //        type: 'POST',
            //        data: {
            //            model: modelData
            //        },
            //        success: function (data) {
            //            $(modalEl.querySelector(".modal-body")).empty().html(data);
            //            modal.show();

            //            // Handle Form Validation
            //            const addMembershipPaymentForm = document.getElementById('add_membership_payment_form');
            //            var addMembershipPaymentValidator;
            //            jsonlocalizerData().then(data => {
            //                addMembershipPaymentValidator = FormValidation.formValidation(addMembershipPaymentForm,
            //                    {
            //                        fields: {
            //                            'Amount': {
            //                                validators: {
            //                                    notEmpty: {
            //                                        message: data.thisfieldisrequired
            //                                    },
            //                                    between: {
            //                                        min: e.target.dataset.dueAmount,
            //                                        max: e.target.dataset.dueAmount,
            //                                        message: data["The_amount_must_not_be_less_than_or_equal_to"] + " " + e.target.dataset.dueAmount + "!"
            //                                    }
            //                                }
            //                            }
            //                        },
            //                        plugins: {
            //                            trigger: new FormValidation.plugins.Trigger(),
            //                            bootstrap: new FormValidation.plugins.Bootstrap5({
            //                                rowSelector: '.fv-row',
            //                                eleInvalidClass: '',
            //                                eleValidClass: ''
            //                            })
            //                        }
            //                    }
            //                );
            //            });

            //            // Handle Form Submition
            //            const submitButton = document.getElementById('add_membership_payment_form_submit');
            //            submitButton.addEventListener('click', function (e) {
            //                // Prevent default button action
            //                e.preventDefault();

            //                // Validate form before submit
            //                if (addMembershipPaymentValidator) {
            //                    addMembershipPaymentValidator.validate().then(function (status) {
            //                        if (status == 'Valid') {
            //                            submitButton.setAttribute('data-kt-indicator', 'on');
            //                            submitButton.disabled = true;

            //                            var data = {};
            //                            data.GymMemberMembershipId = $('[name="MemberMembershipId"]').val();
            //                            data.PaidAmount = +$('[name="Amount"]').val();

            //                            $.ajax({
            //                                url: '/Membership/AddMembershipPaymentAmount',
            //                                type: 'POST',
            //                                data: {
            //                                    createDto: data
            //                                },
            //                                dataType: 'json',
            //                                success: function (response) {
            //                                    console.log(response);
            //                                    window.location.href = `/Membership/MembershipPayment`;
            //                                }
            //                            });
            //                        }
            //                    });
            //                }
            //            });
            //        }
            //    });
            //}
        });
    }

    // Handle Add Payment
    var editMemberMembership = () => {
        // Select all delete buttons
        const editMemberMembershipButtons = table.querySelectorAll('.edit-member-membership-btn');

        editMemberMembershipButtons.forEach(Button => {
            Button.addEventListener("click", function (e) {
                // Select Modal Element And Set Title
                const modalEl = document.querySelector("#main_modal");
                jsonlocalizerData().then(data => {
                    modalEl.querySelector("h3").innerText = data["edit_member_subscription"];
                });

                if (modalEl) {
                    const modal = new bootstrap.Modal(modalEl);
                    $.ajax({
                        url: '/Membership/EditMemberMembership',
                        type: 'GET',
                        data: {
                            memberMembershipId: this.dataset.id
                        },
                        success: function (data) {
                            $(modalEl.querySelector(".modal-body")).empty().html(data);
                            modal.show();

                            $('#MemberMembershipDTO_GymMembershipPlanId').select2({
                                minimumResultsForSearch: -1
                            });

                            $("#MemberMembershipDTO_JoiningDate").flatpickr({
                                locale: flatpickrOptions,
                                dateFormat: "Y-m-d",
                                altFormat: "d/m/Y",
                            });

                            $("#MemberMembershipDTO_ExpiringDate").flatpickr({
                                locale: flatpickrOptions,
                                dateFormat: "Y-m-d",
                                altFormat: "d/m/Y",
                            });

                            // Membership Change Handler
                            $("#MemberMembershipDTO_GymMembershipPlanId").on('select2:select', function (e) {
                                var selectedData = e.params.data;
                                durationType = $(selectedData.element).data("durationType");
                                duration = $(selectedData.element).data("duration");
                                selectedMembershipAmount = $(selectedData.element).data("membershipAmount");

                                $("#MemberMembershipDTO_JoiningDate").removeAttr('disabled');
                                if ($("#MemberMembershipDTO_JoiningDate").val().length > 0) {
                                    $("#MemberMembershipDTO_JoiningDate").change();
                                }
                            });

                            $("#MemberMembershipDTO_JoiningDate").on('change', function (e) {
                                let selectedDate = new Date(e.target.value);
                                let expiringDate;
                                if (durationType == undefined || duration == undefined) {
                                    durationType = $("#MemberMembershipDTO_GymMembershipPlanId")[0].selectedOptions[0].dataset.durationType;
                                    duration = +$("#MemberMembershipDTO_GymMembershipPlanId")[0].selectedOptions[0].dataset.duration;
                                }
                                switch (durationType) {
                                    case "Year":
                                        expiringDate = selectedDate.setFullYear(selectedDate.getFullYear() + duration);
                                        break;
                                    case "Month":
                                        expiringDate = selectedDate.setMonth(selectedDate.getMonth() + duration);
                                        break;
                                    case "Day":
                                        expiringDate = selectedDate.setDate(selectedDate.getDate() + duration);
                                        break;
                                }
                                expiringDate = new Date(expiringDate);
                                $("#MemberMembershipDTO_ExpiringDate").val(expiringDate.toISOString().split('T')[0]);
                            });

                            // Handle Form Validation
                            const editMemberMembershipForm = document.getElementById('edit_member_membership_form');
                            var editMemberMembershipValidator;
                            jsonlocalizerData().then(data => {
                                editMemberMembershipValidator = FormValidation.formValidation(editMemberMembershipForm,
                                    {
                                        fields: {
                                            'MemberMembershipDTO.GymMembershipPlanId': {
                                                validators: {
                                                    notEmpty: {
                                                        message: data.thisfieldisrequired
                                                    }
                                                }
                                            },
                                            'MemberMembershipDTO.JoiningDate': {
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
                            const submitButton = document.getElementById('edit_member_membership_form_submit');
                            submitButton.addEventListener('click', function (e) {
                                // Prevent default button action
                                e.preventDefault();

                                // Validate form before submit
                                if (editMemberMembershipValidator) {
                                    editMemberMembershipValidator.validate().then(function (status) {
                                        if (status == 'Valid') {
                                            submitButton.setAttribute('data-kt-indicator', 'on');
                                            submitButton.disabled = true;

                                            var data = {};
                                            data.MemberMembershipDTO = {};
                                            data.UpdateMemberMembershipDTO = {};
                                            data.MemberMembershipDTO.MemberId = $('[name="MemberMembershipDTO.MemberId"]').val();
                                            data.UpdateMemberMembershipDTO.Id = $('[name="MemberMembershipDTO.Id"]').val();
                                            data.UpdateMemberMembershipDTO.MemberShipStatusId = $('[name="MemberMembershipDTO.MemberShipStatusId"]').val();
                                            data.UpdateMemberMembershipDTO.PaymentStatusId = $('[name="MemberMembershipDTO.PaymentStatusId"]').val();
                                            data.UpdateMemberMembershipDTO.GymMembershipPlanId = $('[name="MemberMembershipDTO.GymMembershipPlanId"]').val();
                                            data.UpdateMemberMembershipDTO.JoiningDate = $('[name="MemberMembershipDTO.JoiningDate"]').val();
                                            data.UpdateMemberMembershipDTO.ExpiringDate = $('[name="MemberMembershipDTO.ExpiringDate"]').val();
                                            data.PaidAmount = $('[name="MemberMembershipDTO.PaidAmount"]').val();
                                            data.MembershipAmount = selectedMembershipAmount != undefined ? selectedMembershipAmount : $('[name="MemberMembershipDTO.Membership.MembershipAmount"]').val();

                                            $.ajax({
                                                url: '/Membership/EditMemberMembership',
                                                type: 'POST',
                                                data: {
                                                    updateModel: data
                                                },
                                                dataType: 'json',
                                                success: function (response) {
                                                    console.log(response);
                                                    if (response.success) {
                                                        window.location.href = `/Membership/MembershipPayment`;
                                                    } else {
                                                        toastr.warning(response.message);
                                                    }
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

    return {
        init: function () {
            handleAddNewRole();
            // editMemberMembership();
        }
    };
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
    roles.init();
});
