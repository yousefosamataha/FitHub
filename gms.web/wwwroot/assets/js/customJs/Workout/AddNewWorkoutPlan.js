"use strict";
import { globalClass } from '../custom.js';

// Class definition
var addNewWorkoutPlan = function () {
    // Shared variables
    const addNewWorkoutPlanForm = document.getElementById('add_new_workout_plan_form');
    var currentLanguage = globalClass.checkLanguage(".AspNetCore.Culture").split("=").slice(-1)[0];
    var flatpickrOptions = globalClass.flatpickrLanguage;
    var validator;
    var membershipActivities;
    var jsonlocalizerData = () => {
        return $.ajax({
            url: '/Home/GetJsonlocalizer',
            type: 'GET',
            data: { culture: currentLanguage },
            dataType: 'json'
        });
    }

    // Validation
    jsonlocalizerData().then(data => {
        validator = FormValidation.formValidation(addNewWorkoutPlanForm,
            {
                fields: {
                    'CreateWorkoutPlan.GymMemberUserId': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'CreateWorkoutPlan.MemberLevelId': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'CreateWorkoutPlan.StartDate': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'CreateWorkoutPlan.EndDate': {
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

    // Init BirthDate And Joining Date Flatpickr
    var initFlatpickr = () => {
        const startDateElement = document.querySelector('#CreateWorkoutPlan_StartDate');
        const endDateElement = document.querySelector('#CreateWorkoutPlan_EndDate');

        $(startDateElement).flatpickr({
            locale: flatpickrOptions,
            dateFormat: "Y-m-d",
            altFormat: "d/m/Y",
        });

        $(endDateElement).flatpickr({
            locale: flatpickrOptions,
            dateFormat: "Y-m-d",
            altFormat: "d/m/Y",
        });
    }

    // Handle Select Member
    var handleSelectMember = () => {
        // Format options
        const optionFormat = (item) => {
            if (!item.id) {
                return item.text;
            }

            var span = document.createElement('span');
            var template = '';
            template += '<div class="d-flex align-items-center">';

            if (item.element.getAttribute('data-image') != "") {
                template += '<img src="' + item.element.getAttribute('data-image') + '" class="rounded-circle h-40px w-40px me-3" style="object-fit: cover;" alt="image"/>';
            } else {
                template += '<span class="symbol symbol-circle symbol-40px d-flex justify-content-center me-3"><span class="symbol-label symbol-label-blank"></span></span>';
            }
            template += '<div class="d-flex flex-column">'
            template += '<span class="fs-4 fw-bold lh-1">' + item.text + '</span>';
            template += '<span class="text-muted fs-5">' + item.element.getAttribute('data-email') + '</span>';
            template += '</div>';
            template += '</div>';

            span.innerHTML = template;

            //membershipActivities = item.element.getAttribute('data-test');

            ////for (var i = 0; i < membershipActivities.split(",").length; i++) {

            ////}

            //console.log(membershipActivities);
            //console.log(membershipActivities.split(","));
            //membershipActivities = membershipActivities.split(",");
            return $(span);
        }


        // Init Select2
        $('#CreateWorkoutPlan_GymMemberUserId').select2({
            templateSelection: optionFormat,
            templateResult: optionFormat
        });
    }

    // Add New Membership Form Submition
    const formSubmition = () => {
        const submitButton = document.getElementById('add_new_workout_plan_form_submit');
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
                        data.CreateWorkoutPlan = {};
                        data.CreateWorkoutPlanActivities = [];
                        data.CreateWorkoutPlan.GymMemberUserId = $('[name="CreateWorkoutPlan.GymMemberUserId"]').val();
                        data.CreateWorkoutPlan.MemberLevelId = $('[name="CreateWorkoutPlan.MemberLevelId"]').val();
                        data.CreateWorkoutPlan.StartDate = $('[name="CreateWorkoutPlan.StartDate"]').val();
                        data.CreateWorkoutPlan.EndDate = $('[name="CreateWorkoutPlan.EndDate"]').val();
                        data.CreateWorkoutPlan.Description = $('[name="CreateWorkoutPlan.Description"]').val();
                        document.querySelectorAll("[data-repeater-item]").forEach(e => {    
                            $(e).find('.SelectedDays').val().forEach(d => {
                                var workoutPlanActivity = {};
                                workoutPlanActivity.ActivityId = $(e).find('.ActivityId').val();
                                workoutPlanActivity.WeekDayId = +d;
                                workoutPlanActivity.Sets = +$(e).find('.Sets').val();
                                workoutPlanActivity.Reps = +$(e).find('.Reps').val();
                                workoutPlanActivity.Kg = +$(e).find('.Kg').val();
                                workoutPlanActivity.RestTime = "00:" + $(e).find('.Rest').val();
                                data.CreateWorkoutPlanActivities.push(workoutPlanActivity);
                            });
                        });
                        console.log(data);

                        $.ajax({
                            url: '/Workout/AddNewWorkoutPlan',
                            type: 'POST',
                            data: {
                                model: data
                            },
                            success: function (response) {
                                window.location.href = `/Workout/`;
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
            handleSelectMember();
            formSubmition();

            $('#kt_docs_repeater_advanced').repeater({
                initEmpty: false,

                defaultValues: {
                    'text-input': 'foo'
                },

                show: function () {
                    $(this).slideDown();

                    // Re-init select2
                    $(this).find('[data-kt-repeater="select2"]').select2({
                        closeOnSelect: false,
                        minimumResultsForSearch: Infinity
                    });

                    // Re-init select2
                    $(this).find('.ActivityId').select2({
                        minimumResultsForSearch: Infinity
                    });

                    // 
                    $(this).find('.Rest').flatpickr({
                        enableTime: true,
                        noCalendar: true,
                        dateFormat: "i:S",
                        time_24hr: true,
                        enableSeconds: true,
                        defaultMinute: 0,
                        defaultSeconds: 0,
                        minuteIncrement: 1,
                        secondIncrement: 1,
                        onReady: function (selectedDates, dateStr, instance) {
                            instance.calendarContainer.querySelector(".flatpickr-hour").style.display = "none";
                        }
                    });
                },

                hide: function (deleteElement) {
                    $(this).slideUp(deleteElement);
                },

                ready: function () {
                    //
                    //$('#CreateWorkoutPlan_GymMemberUserId').on('change', function () {
                    //    console.log($(this));
                    //    var filterText = $(this)[0].selectedOptions[0].dataset.test.split(",").filter(id => id.length != 0);
                    //    console.log(filterText);
                    //    console.log(x);
                    //    console.log(x.find('.test option'));

                    //    var $stateSelect = $('.test');
                    //    console.log($stateSelect);
                    //    // $stateSelect.empty();
                    //});

                    // Init select2
                    $('[data-kt-repeater="select2"]').select2({
                        closeOnSelect: false,
                        minimumResultsForSearch: Infinity
                    });

                    // Re-init select2
                    $('.ActivityId').select2({
                        minimumResultsForSearch: Infinity
                    });

                    // 
                    $('.Rest').flatpickr({
                        enableTime: true,
                        time_24hr: true,
                        noCalendar: true,
                        dateFormat: "i:S",
                        enableSeconds: true,
                        defaultMinute: 0,
                        defaultSeconds: 0,
                        minuteIncrement: 1,
                        secondIncrement: 1,
                        onReady: function (selectedDates, dateStr, instance) {
                            instance.calendarContainer.querySelector(".flatpickr-hour").style.display = "none";
                        }
                    });
                }
            });
        }
    };
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
    addNewWorkoutPlan.init();
});