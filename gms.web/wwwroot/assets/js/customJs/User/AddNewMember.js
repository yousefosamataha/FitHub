"use strict";

// Class definition
var addNewMember = function () {
    // Shared variables
    const addNewMemberForm = document.getElementById('add_new_member_form');
    var currentLanguage = getCookie(".AspNetCore.Culture").split("=").slice(-1)[0];
    var flatpickrOptions = currentLanguage === "ar-EG" ? {
        months: {
            shorthand: ['۰', '۱', '۲', '۳', '٤', '٥', '٦', '۷', '۸', '۹', "۱۰", "۱۱", "۱۲"],
            longhand: ["يناير", "فبراير", "مارس", "أبريل", "مايو", "يونيو", "يوليو", "أغسطس", "سبتمبر", "أكتوبر", "نوفمبر", "ديسمبر"]
        },
        weekdays: {
            shorthand: ["ح", "ن", "ث", "ر", "خ", "ج", "س"],
            longhand: ["الأحد", "الاثنين", "الثلاثاء", "الأربعاء", "الخميس", "الجمعة", "السبت"]
        },
        rangeSeparator: " إلى ",
        weekAbbreviation: "أس",
        scrollTitle: "قم بالتمرير للزيادة",
        toggleTitle: "اضغط للتبديل",
        amPM: ["ص", "م"],
        yearAriaLabel: "سنة",
        monthAriaLabel: "شهر",
        hourAriaLabel: "ساعة",
        minuteAriaLabel: "دقيقة",
    } : currentLanguage === "fr-FR" ? "fr" : "en";
    var birthDateFlatpickr;
    var joiningDateFlatpickr;
    var durationType;
    var duration;
    var passwordMeter;
    var base64Image;
    var validator;
    var jsonlocalizerData = () => {
        return $.ajax({
            url: '/Home/GetJsonlocalizer',
            type: 'GET',
            data: { culture: currentLanguage },
            dataType: 'json'
        });
    }

    // Check Language
    function getCookie(cname) {
        let name = cname + "=";
        let decodedCookie = decodeURIComponent(document.cookie);
        let ca = decodedCookie.split(';');
        for (let i = 0; i < ca.length; i++) {
            let c = ca[i];
            while (c.charAt(0) == ' ') {
                c = c.substring(1);
            }
            if (c.indexOf(name) == 0) {
                return c.substring(name.length, c.length);
            }
        }
        return "";
    }

    // Validation
    jsonlocalizerData().then(data => {
        validator = FormValidation.formValidation(addNewMemberForm,
            {
                fields: {
                    'CreateMemberDTO.FirstName': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'CreateMemberDTO.LastName': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'CreateMemberDTO.BirthDate': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'CreateMemberDTO.GenderId': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'CreateMemberDTO.Email': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'CreateMemberDTO.Password': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            },
                            callback: {
                                message: data["please_enter_valid_password"],
                                callback: function (input) {
                                    if (input.value.length > 0) {
                                        return validatePassword();
                                    }
                                }
                            }
                        }
                    },
                    'SelectedGroupIds': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
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
                    },
                },

                plugins: {
                    trigger: new FormValidation.plugins.Trigger({
                        event: {
                            'password': false
                        }
                    }),
                    bootstrap: new FormValidation.plugins.Bootstrap5({
                        rowSelector: '.fv-row',
                        eleInvalidClass: '',
                        eleValidClass: ''
                    })
                }
            }
        );
    });

    // Init BirthDate And Joining Date Flatpickr
    var initFlatpickr = () => {
        const birthDateElement = document.querySelector('#CreateMemberDTO_BirthDate');
        const joiningDateElement = document.querySelector('#MemberMembershipDTO_JoiningDate');
        const expiringDateElement = document.querySelector('#MemberMembershipDTO_ExpiringDate');

        $(birthDateElement).flatpickr({
            locale: flatpickrOptions,
            dateFormat: "Y-m-d",
            altFormat: "d/m/Y",
        });

        joiningDateFlatpickr = $(joiningDateElement).flatpickr({
            locale: flatpickrOptions,
            dateFormat: "Y-m-d",
            altFormat: "d/m/Y",
        });

        $(expiringDateElement).flatpickr({
            locale: flatpickrOptions,
            dateFormat: "Y-m-d",
            altFormat: "d/m/Y",
        });
    }

    // Member Status Handler
    const handleMemberStatus = () => {
        const target = document.getElementById('member_tatus');
        const select = document.getElementById('CreateMemberDTO_StatusId');
        const statusClasses = ['bg-success', 'bg-danger'];

        $(select).on('change', function (e) {
            const value = e.target.value;

            switch (value) {
                case "1": {
                    target.classList.remove(...statusClasses);
                    target.classList.add('bg-success');
                    break;
                }
                case "2": {
                    target.classList.remove(...statusClasses);
                    target.classList.add('bg-danger');
                    break;
                }
            }
        });
    }

    // Membership Change Handler
    $("#MemberMembershipDTO_GymMembershipPlanId").on('select2:select', function (e) {
        var selectedData = e.params.data;
        durationType = $(selectedData.element).data("durationType");
        duration = $(selectedData.element).data("duration");

        $("#MemberMembershipDTO_JoiningDate").removeAttr('disabled');
        if ($("#MemberMembershipDTO_JoiningDate").val().length > 0) {
            $("#MemberMembershipDTO_JoiningDate").change();
        }
    });

    $("#MemberMembershipDTO_JoiningDate").on('change', function (e) {
        let selectedDate = new Date(e.target.value);
        let expiringDate;
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

    // Convert To Base64
    var convertToBase64 = () => {
        document.getElementById('CreateMemberDTO_Image').addEventListener('change', function (event) {
            var file = event.target.files[0];
            var reader = new FileReader();
            reader.onload = function (event) {
                base64Image = event.target.result;
                console.log(base64Image); // Log base64-encoded image
            };
            reader.readAsDataURL(file);
        });
    }

    // Password input validation
    var validatePassword = function () {
        return (passwordMeter.score > 70);
    }

    // Add New Membership Form Submition
    const formSubmition = () => {
        const submitButton = document.getElementById('add_new_member_form_submit');
        submitButton.addEventListener('click', function (e) {
            // Prevent default button action
            e.preventDefault();

            // Validate form before submit
            if (validator) {
                validator.validate().then(function (status) {
                    if (status == 'Valid') {
                        submitButton.setAttribute('data-kt-indicator', 'on');
                        submitButton.disabled = true;

                        var data = {};
                        data.CreateMemberDTO = {};
                        data.MemberMembershipDTO = {};
                        data.CreateMemberDTO.Image = base64Image;
                        data.CreateMemberDTO.StatusId = $('[name="CreateMemberDTO.StatusId"]').val();
                        data.CreateMemberDTO.FirstName = $('[name="CreateMemberDTO.FirstName"]').val();
                        data.CreateMemberDTO.LastName = $('[name="CreateMemberDTO.LastName"]').val();
                        data.CreateMemberDTO.BirthDate = $('[name="CreateMemberDTO.BirthDate"]').val();
                        data.CreateMemberDTO.GenderId = $('[name="CreateMemberDTO.GenderId"]').val();
                        data.CreateMemberDTO.City = $('[name="CreateMemberDTO.City"]').val();
                        data.CreateMemberDTO.State = $('[name="CreateMemberDTO.State"]').val();
                        data.CreateMemberDTO.Address = $('[name="CreateMemberDTO.Address"]').val();
                        data.CreateMemberDTO.PhoneNumber = $('[name="CreateMemberDTO.PhoneNumber"]').val();
                        data.CreateMemberDTO.Email = $('[name="CreateMemberDTO.Email"]').val();
                        data.CreateMemberDTO.Password = $('[name="CreateMemberDTO.Password"]').val();
                        data.SelectedGroupIds = $('[name="SelectedGroupIds"]').val();
                        data.MemberMembershipDTO.GymMembershipPlanId = $('[name="MemberMembershipDTO.GymMembershipPlanId"]').val();
                        data.MemberMembershipDTO.JoiningDate = $('[name="MemberMembershipDTO.JoiningDate"]').val();
                        data.MemberMembershipDTO.ExpiringDate = $('[name="MemberMembershipDTO.ExpiringDate"]').val();
                        console.log(data);

                        $.ajax({
                            url: '/GymUser/CreateNewMember',
                            type: 'POST',
                            data: {
                                model: data
                            },
                            success: function (response) {
                                //toastr.success("Membership Added successfully!");
                                //toastr.success("تمت إضافة العضوية بنجاح!");
                                //window.location.href = `/Membership/MembershipsList`;
                            },
                            error: function (xhr, status, error) {
                                console.error('Error:', error);
                            }
                        });
                    }
                });
            }
        });
    }

    return {
        init: function () {
            passwordMeter = KTPasswordMeter.getInstance(document.querySelector('[data-kt-password-meter="true"]'));
            passwordMeter.options.minLength = 10;

            // Handlers
            initFlatpickr();
            handleMemberStatus();
            convertToBase64();
            formSubmition();
        }
    };
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
    addNewMember.init();
});