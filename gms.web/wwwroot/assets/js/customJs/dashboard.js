"use strict";
import { globalClass } from './custom.js';

// Class definition
var KTAppCalendar = function () {
    // Shared variables
    var currentLanguage = globalClass.checkLanguage(".AspNetCore.Culture").split("=").slice(-1)[0];
    var calendarLanguage = currentLanguage == "ar-EG" ? "ar" : currentLanguage == "fr-FR" ? "fr" : "en";

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

        // Init calendar
        calendar = new FullCalendar.Calendar(calendarEl, {
            locale: calendarLanguage,
            headerToolbar: {
                left: 'prev,next today',
                center: 'title',
                right: 'dayGridMonth,timeGridWeek,timeGridDay'
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
            events: [
                {
                    id: uid(),
                    title: 'All Day Event',
                    start: YM + '-01',
                    end: YM + '-02',
                    description: 'Toto lorem ipsum dolor sit incid idunt ut',
                    className: "fc-event-danger fc-event-solid-warning",
                    location: 'Federation Square'
                },
                {
                    id: uid(),
                    title: 'Reporting',
                    start: YM + '-14T13:30:00',
                    description: 'Lorem ipsum dolor incid idunt ut labore',
                    end: YM + '-14T14:30:00',
                    className: "fc-event-success",
                    location: 'Meeting Room 7.03'
                },
                {
                    id: uid(),
                    title: 'Company Trip',
                    start: YM + '-02',
                    description: 'Lorem ipsum dolor sit tempor incid',
                    end: YM + '-03',
                    className: "fc-event-primary",
                    location: 'Seoul, Korea'

                },
                {
                    id: uid(),
                    title: 'ICT Expo 2021 - Product Release',
                    start: YM + '-03',
                    description: 'Lorem ipsum dolor sit tempor inci',
                    end: YM + '-05',
                    className: "fc-event-light fc-event-solid-primary",
                    location: 'Melbourne Exhibition Hall'
                },
                {
                    id: uid(),
                    title: 'Dinner',
                    start: YM + '-12',
                    description: 'Lorem ipsum dolor sit amet, conse ctetur',
                    end: YM + '-13',
                    location: 'Squire\'s Loft'
                },
                {
                    id: uid(),
                    title: 'Repeating Event',
                    start: YM + '-09T16:00:00',
                    end: YM + '-09T17:00:00',
                    description: 'Lorem ipsum dolor sit ncididunt ut labore',
                    className: "fc-event-danger",
                    location: 'General Area'
                },
                {
                    id: uid(),
                    title: 'Repeating Event',
                    description: 'Lorem ipsum dolor sit amet, labore',
                    start: YM + '-16T16:00:00',
                    end: YM + '-16T17:00:00',
                    location: 'General Area'
                },
                {
                    id: uid(),
                    title: 'Conference',
                    start: YESTERDAY,
                    end: TOMORROW,
                    description: 'Lorem ipsum dolor eius mod tempor labore',
                    className: "fc-event-primary",
                    location: 'Conference Hall A'
                },
                {
                    id: uid(),
                    title: 'Meeting',
                    start: TODAY + 'T10:30:00',
                    end: TODAY + 'T12:30:00',
                    description: 'Lorem ipsum dolor eiu idunt ut labore',
                    location: 'Meeting Room 11.06'
                },
                {
                    id: uid(),
                    title: 'Lunch',
                    start: TODAY + 'T12:00:00',
                    end: TODAY + 'T14:00:00',
                    className: "fc-event-info",
                    description: 'Lorem ipsum dolor sit amet, ut labore',
                    location: 'Cafeteria'
                },
                {
                    id: uid(),
                    title: 'Meeting',
                    start: TODAY + 'T14:30:00',
                    end: TODAY + 'T15:30:00',
                    className: "fc-event-warning",
                    description: 'Lorem ipsum conse ctetur adipi scing',
                    location: 'Meeting Room 11.10'
                },
                {
                    id: uid(),
                    title: 'Happy Hour',
                    start: TODAY + 'T17:30:00',
                    end: TODAY + 'T21:30:00',
                    className: "fc-event-info",
                    description: 'Lorem ipsum dolor sit amet, conse ctetur',
                    location: 'The English Pub'
                },
                {
                    id: uid(),
                    title: 'Dinner',
                    start: TOMORROW + 'T18:00:00',
                    end: TOMORROW + 'T21:00:00',
                    className: "fc-event-solid-danger fc-event-light",
                    description: 'Lorem ipsum dolor sit ctetur adipi scing',
                    location: 'New York Steakhouse'
                },
                {
                    id: uid(),
                    title: 'Birthday Party',
                    start: TOMORROW + 'T12:00:00',
                    end: TOMORROW + 'T14:00:00',
                    className: "fc-event-primary",
                    description: 'Lorem ipsum dolor sit amet, scing',
                    location: 'The English Pub'
                },
                {
                    id: uid(),
                    title: 'Site visit',
                    start: YM + '-28',
                    end: YM + '-29',
                    className: "fc-event-solid-info fc-event-light",
                    description: 'Lorem ipsum dolor sit amet, labore',
                    location: '271, Spring Street'
                }
            ],

            // Handle changing calendar views
            datesSet: function () {
                // do some stuff
            }
        });

        calendar.render();
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

    // Generate unique IDs for events
    const uid = () => {
        return Date.now().toString() + Math.floor(Math.random() * 1000).toString();
    }

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
    KTAppCalendar.init();
});
