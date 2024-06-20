"use strict";
import { globalClass } from '../custom.js';

// Class definition
var workoutPlansList = function () {
    // Shared variables
    var table;
    var datatable;
    var currentLanguage = globalClass.checkLanguage(".AspNetCore.Culture").split("=").slice(-1)[0];
    var datatableLanguage = currentLanguage == "ar-EG" ? "ar" : currentLanguage == "fr-FR" ? "fr" : "en";
    const hostName = window.location.origin;

    // Init Datatable
    var initDatatable = function () {
        // Init datatable
        datatable = $(table).DataTable({
            language: {
                url: `${hostName}/assets/plugins/localization/datatable-${datatableLanguage}.json`,
            },
            "info": true,
            'order': [],
            'pageLength': 6,
            'columnDefs': [
                { orderable: false, targets: [0, 2, 5] }, // Disable ordering on column 5 (status), 7 (actions)
            ],
            "lengthMenu": [[-1, 5, 10, 50], ["All", 5, 10, 50]],
            "pagingType": "full_numbers"
        });
    }

    // datatable pageing tap number
    $.fn.DataTable.ext.pager.numbers_length = 5;

    // Search Datatable
    var handleSearchDatatable = () => {
        const filterSearch = document.querySelector('[workoutPlans-list-filter="search"]');
        filterSearch.addEventListener('keyup', function (e) {
            datatable.search(e.target.value).draw();
        });
    }

    // Show WorkoutPlan
    var showWorkoutPlan = () => {
        // Select all delete buttons
        const showButtons = table.querySelectorAll('.show-workout-plan-btn');

        showButtons.forEach(s => {
            s.addEventListener("click", function (e) {
                window.location.href = `/Workout/ShowWorkoutPlan?workoutPlanId=${this.dataset.id}`;
            });
        });
    }

    // Public methods
    return {
        init: function () {
            table = document.querySelector('#workoutPlans_list');

            if (!table) {
                return;
            }

            initDatatable();
            handleSearchDatatable();
            showWorkoutPlan();
        }
    };
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
    workoutPlansList.init();
});