"use strict";

// Class definition
var editStaff = function () {
    // Shared variables
    const editStaffForm = document.getElementById('edit_staff_form');
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

    // Validation
    jsonlocalizerData().then(data => {
        validator = FormValidation.formValidation(editStaffForm,
            {
                fields: {
                    'StaffDTO.FirstName': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'StaffDTO.LastName': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'StaffDTO.BirthDate': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'StaffDTO.GenderId': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
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
        const birthDateElement = document.querySelector('#StaffDTO_BirthDate');

        $(birthDateElement).flatpickr({
            locale: flatpickrOptions,
            dateFormat: "Y-m-d",
            altFormat: "d/m/Y",
        });
    }

    // Staff Status Handler
    const handleStaffStatus = () => {
        const target = document.getElementById('staff_status');
        const select = document.getElementById('StaffDTO_StatusId');
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
        document.getElementById('StaffDTO_Image').addEventListener('change', function (event) {
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

    // Edit Staff Form Submition
    const formSubmition = () => {
        const submitButton = document.getElementById('edit_staff_form_submit');
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
                        data.UpdateStaffDTO = {};
                        data.UpdateStaffDTO.Image = base64Image;
                        data.UpdateStaffDTO.StatusId = $('[name="StaffDTO.StatusId"]').val();
                        data.UpdateStaffDTO.FirstName = $('[name="StaffDTO.FirstName"]').val();
                        data.UpdateStaffDTO.LastName = $('[name="StaffDTO.LastName"]').val();
                        data.UpdateStaffDTO.BirthDate = $('[name="StaffDTO.BirthDate"]').val();
                        data.UpdateStaffDTO.GenderId = $('[name="StaffDTO.GenderId"]').val();
                        data.UpdateStaffDTO.City = $('[name="StaffDTO.City"]').val();
                        data.UpdateStaffDTO.State = $('[name="StaffDTO.State"]').val();
                        data.UpdateStaffDTO.Address = $('[name="StaffDTO.Address"]').val();
                        data.UpdateStaffDTO.PhoneNumber = $('[name="StaffDTO.PhoneNumber"]').val();
                        data.UpdateStaffDTO.Email = $('[name="StaffDTO.Email"]').val();
                        data.SelectedGroupIds = $('[name="SelectedGroupIds"]').val();
                        data.SelectedSpecializationIds = $('[name="SelectedSpecializationIds"]').val();
                        data.RoleName = $('[name="RoleName"]').val();
                        console.log(data);

                        $.ajax({
                            url: '/GymUser/EditStaff',
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
            // Handlers
            initFlatpickr();
            handleStaffStatus();
            convertToBase64();
            handleInputImage();
            formSubmition();

            // Default Actions
            $('#StaffDTO_StatusId').change();
        }
    };
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
    editStaff.init();
});