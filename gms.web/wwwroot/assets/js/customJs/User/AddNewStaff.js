"use strict";

// Class definition
var addNewStaff = function () {
    // Shared variables
    const addNewStaffForm = document.getElementById('add_new_staff_form');
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
        validator = FormValidation.formValidation(addNewStaffForm,
            {
                fields: {
                    'CreateStaffDTO.FirstName': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'CreateStaffDTO.LastName': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'CreateStaffDTO.BirthDate': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'CreateStaffDTO.GenderId': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'CreateStaffDTO.Email': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'CreateStaffDTO.Password': {
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
                    'RoleName': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    }
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

    // Init Birth Date Flatpickr
    var initFlatpickr = () => {
        const birthDateElement = document.querySelector('#CreateStaffDTO_BirthDate');

        $(birthDateElement).flatpickr({
            locale: flatpickrOptions,
            dateFormat: "Y-m-d",
            altFormat: "d/m/Y",
        });
    }

    // Staff Status Handler
    const handleStaffStatus = () => {
        const target = document.getElementById('staff_status');
        const select = document.getElementById('CreateStaffDTO_StatusId');
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

    // Convert To Base64
    var convertToBase64 = () => {
        document.getElementById('CreateStaffDTO_Image').addEventListener('change', function (event) {
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

    // Add New Staff Form Submition
    const formSubmition = () => {
        const submitButton = document.getElementById('add_new_staff_form_submit');
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
                        data.CreateStaffDTO = {};
                        data.CreateStaffDTO.Image = base64Image;
                        data.CreateStaffDTO.StatusId = $('[name="CreateStaffDTO.StatusId"]').val();
                        data.CreateStaffDTO.FirstName = $('[name="CreateStaffDTO.FirstName"]').val();
                        data.CreateStaffDTO.LastName = $('[name="CreateStaffDTO.LastName"]').val();
                        data.CreateStaffDTO.BirthDate = $('[name="CreateStaffDTO.BirthDate"]').val();
                        data.CreateStaffDTO.GenderId = $('[name="CreateStaffDTO.GenderId"]').val();
                        data.CreateStaffDTO.City = $('[name="CreateStaffDTO.City"]').val();
                        data.CreateStaffDTO.State = $('[name="CreateStaffDTO.State"]').val();
                        data.CreateStaffDTO.Address = $('[name="CreateStaffDTO.Address"]').val();
                        data.CreateStaffDTO.PhoneNumber = $('[name="CreateStaffDTO.PhoneNumber"]').val();
                        data.CreateStaffDTO.Email = $('[name="CreateStaffDTO.Email"]').val();
                        data.CreateStaffDTO.Password = $('[name="CreateStaffDTO.Password"]').val();
                        data.SelectedGroupIds = $('[name="SelectedGroupIds"]').val();
                        data.RoleName = $('[name="RoleName"]').val();
                        console.log(data);

                        $.ajax({
                            url: '/GymUser/CreateNewStaff',
                            type: 'POST',
                            data: {
                                model: data
                            },
                            success: function (response) {
                                window.location.href = `/GymUser/Staffslist`;
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
            handleStaffStatus();
            convertToBase64();
            formSubmition();
        }
    };
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
    addNewStaff.init();
});