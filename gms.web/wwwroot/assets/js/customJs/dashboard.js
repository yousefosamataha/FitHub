"use strict";
import { globalClass } from './custom.js';

// Class definition
var dashboard = function () {
    // Shared variables
    var currentLanguage = globalClass.checkLanguage(".AspNetCore.Culture").split("=").slice(-1)[0];
    var calendarLanguage = currentLanguage == "ar-EG" ? "ar" : currentLanguage == "fr-FR" ? "fr" : "en";
    var classesScheduleList;
    var getClassesSchedule = () => {
        return $.ajax({
            url: '/Class/ClassesScheduleForCalendar',
            type: 'GET',
            dataType: 'json'
        });
    }

    // Calendar variables
    var calendar;
    var data = {
        id: '',
        eventName: '',
        eventDescription: '',
        eventLocation: '',
        startDate: '',
        endDate: '',
        allDay: false
    };

    // View event variables
    var viewEventName;
    var viewAllDay;
    var viewEventDescription;
    var viewEventLocation;
    var viewStartDate;
    var viewEndDate;
    var viewModal;

    // Private functions
    var initCalendarApp = function () {
        // Define variables
        var calendarEl = document.getElementById('kt_calendar_app');
        var todayDate = moment().startOf('day');
        var YM = todayDate.format('YYYY-MM');
        var YESTERDAY = todayDate.clone().subtract(1, 'day').format('YYYY-MM-DD');
        var TODAY = todayDate.format('YYYY-MM-DD');
        var TOMORROW = todayDate.clone().add(1, 'day').format('YYYY-MM-DD');
        var Data = [];

        getClassesSchedule().then(data => {
            data.data.forEach(cs => {
                var classSchedule = {};
                console.log(cs);
                classSchedule.id = `${cs.id}`;
                classSchedule.title = cs.classSchedule.className;
                classSchedule.daysOfWeek = [`${cs.weekDayId - 1}`];
                classSchedule.startTime = cs.classSchedule.startTime;
                classSchedule.endTime = cs.classSchedule.endTime;
                classSchedule.location = cs.classSchedule.gymLocation.name;
                classSchedule.description = "";
                classSchedule.className = "";
                Data.push(classSchedule);
            });
            console.log(Data);

            // Init calendar
            calendar = new FullCalendar.Calendar(calendarEl, {
                locale: calendarLanguage,
                height: 500,
                initialView: 'timeGridWeek',
                headerToolbar: {
                    left: 'prev,next',
                    center: 'title',
                    right: 'timeGridWeek,timeGridDay'
                },
                initialDate: TODAY,
                navLinks: true,
                dayMaxEvents: true, // allow "more" link when too many events

                // Select dates action
                select: function (arg) {
                    formatArgs(arg);
                },

                // Click event
                eventClick: function (arg) {
                    formatArgs({
                        id: arg.event.id,
                        title: arg.event.title,
                        description: arg.event.extendedProps.description,
                        location: arg.event.extendedProps.location,
                        startStr: arg.event.startStr,
                        endStr: arg.event.endStr,
                        allDay: arg.event.allDay
                    });

                    handleViewEvent();
                },
                events: Data,
            });

            calendar.render();
        });
    }

    // Handle view event
    const handleViewEvent = () => {
        viewModal.show();

        // Detect all day event
        var eventNameMod;
        var startDateMod;
        var endDateMod;

        // Generate labels
        if (data.allDay) {
            eventNameMod = 'All Day';
            startDateMod = moment(data.startDate).format('Do MMM, YYYY');
            endDateMod = moment(data.endDate).format('Do MMM, YYYY');
        } else {
            eventNameMod = '';
            startDateMod = moment(data.startDate).format('Do MMM, YYYY - h:mm a');
            endDateMod = moment(data.endDate).format('Do MMM, YYYY - h:mm a');
        }

        // Populate view data
        viewEventName.innerText = data.eventName;
        viewAllDay.innerText = eventNameMod;
        viewEventDescription.innerText = data.eventDescription ? data.eventDescription : '--';
        viewEventLocation.innerText = data.eventLocation ? data.eventLocation : '--';
        viewStartDate.innerText = startDateMod;
        viewEndDate.innerText = endDateMod;
    }

    // Format FullCalendar reponses
    const formatArgs = (res) => {
        data.id = res.id;
        data.eventName = res.title;
        data.eventDescription = res.description;
        data.eventLocation = res.location;
        data.startDate = res.startStr;
        data.endDate = res.endStr;
        data.allDay = res.allDay;
    }

    // Function to check the media query and apply changes
    function checkWidth(mediaQuery) {
        const calendarDiv = document.querySelector('#kt_calendar_app');
        const scheduleDiv = document.querySelector('#class_schedule');
        if (mediaQuery.matches) {
            // If media query matches
            calendarDiv.classList.add('d-none');
            scheduleDiv.classList.remove('d-none');
        } else {
            // If media query does not match
            calendarDiv.classList.remove('d-none');
            scheduleDiv.classList.add('d-none');
        }
    }

    // Set up media query
    const mediaQuery = window.matchMedia('(max-width: 500px)');

    // Initial check
    checkWidth(mediaQuery);

    // Listen for changes in the media query
    mediaQuery.addListener((event) => {
        checkWidth(event);
    });

    return {
        // Public Functions
        init: function () {
            // View event modal
            const viewElement = document.getElementById('kt_modal_view_event');
            viewModal = new bootstrap.Modal(viewElement);
            viewEventName = viewElement.querySelector('[data-kt-calendar="event_name"]');
            viewAllDay = viewElement.querySelector('[data-kt-calendar="all_day"]');
            viewEventDescription = viewElement.querySelector('[data-kt-calendar="event_description"]');
            viewEventLocation = viewElement.querySelector('[data-kt-calendar="event_location"]');
            viewStartDate = viewElement.querySelector('[data-kt-calendar="event_start_date"]');
            viewEndDate = viewElement.querySelector('[data-kt-calendar="event_end_date"]');

            initCalendarApp();
        }
    };
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
    dashboard.init();
});