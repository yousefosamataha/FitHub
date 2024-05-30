"use strict";

// Class definition
var userProfile = function () {
    // Shared variables
    var updateUserform = document.getElementById('update_user_form');
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

    // Init BirthDate And Joining Date Flatpickr
    var initFlatpickr = () => {
        const birthDateElement = document.querySelector('#BirthDate');

        $(birthDateElement).flatpickr({
            locale: flatpickrOptions,
            dateFormat: "Y-m-d",
            altFormat: "d/m/Y",
        });
    }

    // Handle Validation With Jsonlocalizer
    jsonlocalizerData().then(data => {
        validator = FormValidation.formValidation(updateUserform,
            {
                fields: {
                    'FirstName': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'LastName': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'BirthDate': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'GenderId': {
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

    // Convert To Base64
    var convertToBase64 = () => {
        document.getElementById('Image').addEventListener('change', function (event) {
            var file = event.target.files[0];
            var reader = new FileReader();
            reader.onload = function (event) {
                base64Image = event.target.result;
                console.log(base64Image); // Log base64-encoded image
            };
            reader.readAsDataURL(file);
        });
    }

    // Handle Input Image
    var handleInputImage = () => {
        var imageInputElement = document.querySelector("#image_input_control");
        var imageInput = KTImageInput.getInstance(imageInputElement);
        base64Image = imageInput.src != "none" ? imageInput.src.split('url("')[1].split('")')[0] : null;
        $("#image_input_control .btn[data-kt-image-input-action='remove']").on("click", function () {
            imageInput.src = "none";
            base64Image = null;
        });
    };

    // Form Submition
    const updateUserFormSubmition = () => {
        const submitButton = document.getElementById('update_user_form_submit');
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
                        data.Image = base64Image;
                        data.StatusId = $('[name="StatusId"]').val();
                        data.FirstName = $('[name="FirstName"]').val();
                        data.LastName = $('[name="LastName"]').val();
                        data.BirthDate = $('[name="BirthDate"]').val();
                        data.GenderId = $('[name="GenderId"]').val();
                        data.City = $('[name="City"]').val();
                        data.State = $('[name="State"]').val();
                        data.Address = $('[name="Address"]').val();
                        data.PhoneNumber = $('[name="PhoneNumber"]').val();
                        console.log(data);

                        $.ajax({
                            url: '/GymUser/EditUserProfile',
                            type: 'POST',
                            data: {
                                updateUserDto: data
                            },
                            success: function (response) {
                                window.location.href = `/GymUser/UserProfile`;
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

    // Public methods
    return {
        init: function () {
            initFlatpickr();
            convertToBase64();
            handleInputImage();
            updateUserFormSubmition();
        }
    };
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
    userProfile.init();
});
