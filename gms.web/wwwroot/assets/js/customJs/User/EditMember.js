"use strict";

// Class definition
var editMember = function () {
    // Shared variables
    const editMemberForm = document.getElementById('edit_member_form');
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
        validator = FormValidation.formValidation(editMemberForm,
            {
                fields: {
                    'MemberDTO.FirstName': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'MemberDTO.LastName': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'MemberDTO.BirthDate': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'MemberDTO.GenderId': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'MemberDTO.Email': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'MemberDTO.Password': {
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
                    'MemberDTO.GymMemberMembership.GymMembershipPlanId': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'MemberDTO.GymMemberMembership.JoiningDate': {
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
    var initFlatpickr = () =>    {
        const birthDateElement = document.querySelector('#MemberDTO_BirthDate');
        const joiningDateElement = document.querySelector('#MemberDTO_GymMemberMembership_JoiningDate');
        const expiringDateElement = document.querySelector('#MemberDTO_GymMemberMembership_ExpiringDate');

        $(birthDateElement).flatpickr({
            locale: flatpickrOptions,
            dateFormat: "Y-m-d",
            altFormat: "d/m/Y",
        });

        $(joiningDateElement).flatpickr({
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
        const select = document.getElementById('MemberDTO_StatusId');
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
    $("#MemberDTO_GymMemberMembership_GymMembershipPlanId").on('select2:select', function (e) {
        var selectedData = e.params.data;
        durationType = $(selectedData.element).data("durationType");
        duration = $(selectedData.element).data("duration");

        $("#MemberDTO_GymMemberMembership_JoiningDate").removeAttr('disabled');
        if ($("#MemberDTO_GymMemberMembership_JoiningDate").val().length > 0) {
            $("#MemberDTO_GymMemberMembership_JoiningDate").change();
        }
    });

    $("#MemberDTO_GymMemberMembership_JoiningDate").on('change', function (e) {
        let selectedDate = new Date(e.target.value);
        let expiringDate;
        if (durationType == undefined || duration == undefined) {
            durationType = $("#MemberDTO_GymMemberMembership_GymMembershipPlanId")[0].selectedOptions[0].dataset.durationType;
            duration = +$("#MemberDTO_GymMemberMembership_GymMembershipPlanId")[0].selectedOptions[0].dataset.duration;
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
        $("#MemberDTO_GymMemberMembership_ExpiringDate").val(expiringDate.toISOString().split('T')[0]);
    });

    // Convert To Base64
    var convertToBase64 = () => {
        document.getElementById('MemberDTO_Image').addEventListener('change', function (event) {
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
        const submitButton = document.getElementById('edit_member_form_submit');
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
                        data.MemberDTO = {};
                        data.UpdateMemberMembershipDTO = {};
                        data.MemberDTO.Image = base64Image;
                        data.MemberDTO.StatusId = $('[name="MemberDTO.StatusId"]').val();
                        data.MemberDTO.FirstName = $('[name="MemberDTO.FirstName"]').val();
                        data.MemberDTO.LastName = $('[name="MemberDTO.LastName"]').val();
                        data.MemberDTO.BirthDate = $('[name="MemberDTO.BirthDate"]').val();
                        data.MemberDTO.GenderId = $('[name="MemberDTO.GenderId"]').val();
                        data.MemberDTO.City = $('[name="MemberDTO.City"]').val();
                        data.MemberDTO.State = $('[name="MemberDTO.State"]').val();
                        data.MemberDTO.Address = $('[name="MemberDTO.Address"]').val();
                        data.MemberDTO.PhoneNumber = $('[name="MemberDTO.PhoneNumber"]').val();
                        data.MemberDTO.Email = $('[name="MemberDTO.Email"]').val();
                        data.MemberDTO.Password = $('[name="MemberDTO.Password"]').val();
                        data.SelectedGroupIds = $('[name="SelectedGroupIds"]').val();
                        data.UpdateMemberMembershipDTO.GymMembershipPlanId = $('[name="UpdateMemberMembershipDTO.GymMembershipPlanId"]').val();
                        data.UpdateMemberMembershipDTO.JoiningDate = $('[name="UpdateMemberMembershipDTO.JoiningDate"]').val();
                        data.UpdateMemberMembershipDTO.ExpiringDate = $('[name="UpdateMemberMembershipDTO.ExpiringDate"]').val();
                        console.log(data);

                        //$.ajax({
                        //    url: '/GymUser/CreateNewMember',
                        //    type: 'POST',
                        //    data: {
                        //        model: data
                        //    },
                        //    success: function (response) {
                        //        window.location.href = `/GymUser/Memberslist`;
                        //    },
                        //    error: function (xhr, status, error) {
                        //        console.error('Error:', error);
                        //    }
                        //});
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
            // formSubmition();

            // 
            $('#MemberDTO_StatusId').change();
        }
    };
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
    editMember.init();
});