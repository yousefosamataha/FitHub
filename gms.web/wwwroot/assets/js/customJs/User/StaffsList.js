"use strict";
import { globalClass } from '../custom.js';

// Class definition
var StaffsList = function () {
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
                { orderable: false, targets: [0, 2, 3, 5] }
            ],
            "lengthMenu": [[-1, 5, 10, 50], ["All", 5, 10, 50]],
            "pagingType": "full_numbers"
        });

        // Re-init functions on datatable re-draws
        datatable.on('draw', function () {
        });
    }

    // datatable pageing tap number
    $.fn.DataTable.ext.pager.numbers_length = 5;

    // Search Datatable
    var handleSearchDatatable = () => {
        const filterSearch = document.querySelector('[staffs-list-filter="search"]');
        filterSearch.addEventListener('keyup', function (e) {
            datatable.search(e.target.value).draw();
        });
    }

    // Hook export buttons
    var exportButtons = () => {
        const documentTitle = 'Staffs List Report';
        var buttons = new $.fn.dataTable.Buttons(table, {
            buttons: [
                {
                    extend: 'excelHtml5',
                    title: documentTitle
                },
                {
                    extend: 'csvHtml5',
                    title: documentTitle
                },
                {
                    extend: 'pdfHtml5',
                    title: documentTitle,
                    //customize: function (doc) {
                    //    doc.defaultStyle =
                    //    {
                    //        font: 'Cairo',
                    //    };
                    //}
                }
            ]
        }).container().appendTo($('#staffs_list_views_export'));

        // Hook dropdown menu click event to datatable export buttons
        const exportButtons = document.querySelectorAll('#staffs_list_views_export_menu [data-staffs-list-export]');
        exportButtons.forEach(exportButton => {
            exportButton.addEventListener('click', e => {
                e.preventDefault();

                // Get clicked export value
                const exportValue = e.target.getAttribute('data-staffs-list-export');
                const target = document.querySelector('.dt-buttons .buttons-' + exportValue);

                // Trigger click event on hidden datatable export buttons
                target.click();
            });
        });
    }

    // Edite Staff
    var editStaff = () => {
        document.querySelectorAll(".edit-staff-btn").forEach(e => {
            e.addEventListener("click", function () {
                window.location.href = `/GymUser/EditStaff?id=${e.dataset.id}`;
            });
        });
    }

    return {
        init: function () {
            table = document.querySelector('#staffs-list');

            if (!table) {
                return;
            }

            initDatatable();
            handleSearchDatatable();
            exportButtons();
            editStaff();
        }
    };
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
    StaffsList.init();
});
