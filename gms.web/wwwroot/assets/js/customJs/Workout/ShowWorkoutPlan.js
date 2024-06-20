"use strict";
import { globalClass } from '../custom.js';

// Class definition
var showWorkoutPlan = function () {
    // Shared variables
    var table;
    var datatable;
    var currentLanguage = globalClass.checkLanguage(".AspNetCore.Culture").split("=").slice(-1)[0];
    var datatableLanguage = currentLanguage == "ar-EG" ? "ar" : currentLanguage == "fr-FR" ? "fr" : "en";
    const hostName = window.location.origin;
    var groupColumn = 1;

    // Init Datatable
    var initDatatable = function () {
        // Init datatable
        datatable = $(table).DataTable({
            "info": false,
            paging: false,
            lengthChange: false, 
            columnDefs: [{ visible: false, targets: [0, 1] },
                { orderable: false, targets: [1, 2, 3, 4, 5, 6] }],
            order: [[0, 'asc']],
            drawCallback: function (settings) {
                var api = this.api();
                var rows = api.rows({ page: 'current' }).nodes();
                var last = null;

                api.column(groupColumn, { page: 'current' })
                    .data()
                    .each(function (group, i) {
                        if (last !== group) {
                            $(rows)
                                .eq(i)
                                .before(
                                    '<tr class="group"><td colspan="5">' +
                                    group +
                                    '</td></tr>'
                                );

                            last = group;
                        }
                    });
            }
        });
    }

    // Public methods
    return {
        init: function () {
            table = document.querySelector('#workout_plan_activities_list');

            if (!table) {
                return;
            }

            initDatatable();
        }
    };
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
    showWorkoutPlan.init();
});