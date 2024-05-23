"use strict";
import { globalClass } from '../custom.js';

// Class definition
var membershipPayment = function () {
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
            'pageLength': 10,
            'columnDefs': [
                { orderable: false, targets: [7, 8] },
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
        const filterSearch = document.querySelector('[members-list-filter="search"]');
        filterSearch.addEventListener('keyup', function (e) {
            datatable.search(e.target.value).draw();
        });
    }

    // Handle Add Payment
    var handleAddPayment = () => {
        // Select all delete buttons
        const addPaymentButtons = table.querySelectorAll('.add-payment-btn');

        addPaymentButtons.forEach(Button => {
            Button.addEventListener("click", function (e) {
                // Select Modal Element And Set Title
                const modalEl = document.querySelector("#main_modal");
                jsonlocalizerData().then(data => {
                    modalEl.querySelector("h3").innerText = data["add_payment"];
                });
                var modelData = {};
                modelData.MemberMembershipId = this.dataset.id;
                modelData.Price = this.dataset.price;
                modelData.PiadAmount = this.dataset.piadAmount;
                modelData.DueAmount = this.dataset.dueAmount;
                modelData.SignupFee = this.dataset.signupFee;

                if (modalEl) {
                    const modal = new bootstrap.Modal(modalEl);
                    $.ajax({
                        url: '/Membership/AddMembershipPayment',
                        type: 'POST',
                        data: {
                            model: modelData
                        },
                        success: function (data) {
                            $(modalEl.querySelector(".modal-body")).empty().html(data);
                            modal.show();

                            // Handle Form Validation
                            const addMembershipPaymentForm = document.getElementById('add_membership_payment_form');
                            var addMembershipPaymentValidator;
                            jsonlocalizerData().then(data => {
                                addMembershipPaymentValidator = FormValidation.formValidation(addMembershipPaymentForm,
                                    {
                                        fields: {
                                            'Amount': {
                                                validators: {
                                                    notEmpty: {
                                                        message: data.thisfieldisrequired
                                                    },
                                                    between: {
                                                        min: e.target.dataset.dueAmount,
                                                        max: e.target.dataset.dueAmount,
                                                        message: data["The_amount_must_not_be_less_than_or_equal_to"] + " " + e.target.dataset.dueAmount + "!"
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
                            const submitButton = document.getElementById('add_membership_payment_form_submit');
                            submitButton.addEventListener('click', function (e) {
                                // Prevent default button action
                                e.preventDefault();

                                // Validate form before submit
                                if (addMembershipPaymentValidator) {
                                    addMembershipPaymentValidator.validate().then(function (status) {
                                        if (status == 'Valid') {
                                            submitButton.setAttribute('data-kt-indicator', 'on');
                                            submitButton.disabled = true;

                                            var data = {};
                                            data.GymMemberMembershipId = $('[name="MemberMembershipId"]').val();
                                            data.PaidAmount = +$('[name="Amount"]').val();

                                            $.ajax({
                                                url: '/Membership/AddMembershipPaymentAmount',
                                                type: 'POST',
                                                data: {
                                                    createDto: data
                                                },
                                                dataType: 'json',
                                                success: function (response) {
                                                    console.log(response);
                                                    window.location.href = `/Membership/MembershipPayment`;
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
            table = document.querySelector('#membership_payment');

            if (!table) {
                return;
            }

            initDatatable();
            handleSearchDatatable();
            handleAddPayment();
        }
    };
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
    membershipPayment.init();
});
