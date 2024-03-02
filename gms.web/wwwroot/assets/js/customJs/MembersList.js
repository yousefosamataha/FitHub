"use strict";
import { globalClass } from './custom.js';

// Class definition
var MembersList = function () {
    // Shared variables
    var table;
    var datatable;
    var joiningDateFlatpickr;
    var expiringDateFlatpickr;
    var joiningMinDate, joiningMaxDate, expiringMinDate, expiringMaxDate;
    var currentLanguage = globalClass.checkLanguage(".AspNetCore.Culture").split("=").slice(-1)[0];
    var datatableLanguage = currentLanguage == "ar-EG" ? "ar" : currentLanguage == "fr-FR" ? "fr" : "en";

    // Init Datatable
    var initDatatable = function () {
        //// Set date data order
        //const tableRows = table.querySelectorAll('tbody tr');

        //tableRows.forEach(row => {
        //    const dateRow = row.querySelectorAll('td');
        //    // const realDate = moment(dateRow[5].innerHTML, "DD MMM YYYY, LT").format(); // select date from 4th column in table
        //    const realDate = moment(dateRow[4].innerHTML).format("DD/MMM/YYYY");
        //    dateRow[4].setAttribute('data-order', realDate);
        //});

        // Init datatable
        datatable = $(table).DataTable({
            language: {
                url: `assets/plugins/localization/datatable-${datatableLanguage}.json`,
            },
            //responsive: true,
            //responsive: {
            //    details: {
            //        type: "column",
            //        target: -1
            //    }
            //},
            "info": true,
            'order': [],
            'pageLength': 10,
            'columnDefs': [
                { orderable: false, targets: [0, 2, 3, 7, 8] },
            ],
            "lengthMenu": [[-1, 5, 10, 50], ["All", 5, 10, 50]],
            "pagingType": "full_numbers"
        });

        // Re-init functions on datatable re-draws
        datatable.on('draw', function () {
            handleDeleteRows();
        });
    }

    // datatable pageing tap number
    $.fn.DataTable.ext.pager.numbers_length = 5;

    // Search Datatable
    var handleSearchDatatable = () => {
        const filterSearch = document.querySelector('[members-list-filter="search"]');
        filterSearch.addEventListener('keyup', function (e) {
            datatable.search(e.target.value).draw();
        });
    }

    // Filter Datatable
    var handleTableFilter = function () {
        // Select filter options
        const filterForm = document.querySelector('[members-list-filter="form"]');
        const filterButton = filterForm.querySelector('[members-list-table-filter="filter"]');
        const resetButton = filterForm.querySelector('[members-list-table-reset="reset"]');
        const selectOptions = filterForm.querySelectorAll('select');
        const dateRangeFilters = filterForm.querySelectorAll('[members-list-date-range-filter="filter"]');

        // Filter datatable on submit
        filterButton.addEventListener('click', function () {
            var filterString = '';

            // Get filter values
            selectOptions.forEach((item, index) => {
                if (item.value && item.value !== '') {
                    if (index !== 0) {
                        filterString += ' ';
                    }

                    // Build filter value options
                    filterString += item.value;
                }
            });

            // Filter Daterange
            handleFlatpickr(dateRangeFilters[0]._flatpickr.selectedDates, dateRangeFilters[1]._flatpickr.selectedDates);

            // Filter datatable
            datatable.search(filterString).draw();
        });

        // Reset datatable
        resetButton.addEventListener('click', function () {
            // Reset filter form
            selectOptions.forEach((item, index) => {
                // Reset Select2 dropdown
                $(item).val(null).trigger('change');
            });

            // Reset Flatpickr
            joiningDateFlatpickr.clear();
            expiringDateFlatpickr.clear();
            handleFlatpickr(new Array(0), new Array(0));

            // Filter datatable
            datatable.search('').draw();
        });
    }

    // Init expiringDate And joiningDate Flatpickr
    var initFlatpickr = () => {
        const filterForm = document.querySelector('[members-list-filter="form"]');
        const dateRangeFilters = filterForm.querySelectorAll('[members-list-date-range-filter="filter"]');

        joiningDateFlatpickr = dateRangeFilters[0].flatpickr({
            locale: globalClass.flatpickrLanguage,
            dateFormat: "Y-m-d",
            altFormat: "d/m/Y",
            mode: "range",
        });

        expiringDateFlatpickr = dateRangeFilters[1].flatpickr({
            locale: globalClass.flatpickrLanguage,
            dateFormat: "Y-m-d",
            altFormat: "d/m/Y",
            mode: "range",
        });
    }

    // Handle expiringDate And joiningDate Flatpickr Search
    var handleFlatpickr = (joiningSelectedDates, expiringSelectedDates) => {
        joiningMinDate = joiningSelectedDates[0] || joiningSelectedDates[0] != undefined ? new Date(joiningSelectedDates[0]) : null;
        joiningMaxDate = joiningSelectedDates[1] || joiningSelectedDates[1] != undefined ? new Date(joiningSelectedDates[1]) : null;
        expiringMinDate = expiringSelectedDates[0] || expiringSelectedDates[0] != undefined ? new Date(expiringSelectedDates[0]) : null;
        expiringMaxDate = expiringSelectedDates[1] || expiringSelectedDates[1] != undefined ? new Date(expiringSelectedDates[1]) : null;

        // Datatable date filter
        $.fn.dataTable.ext.search.push(
            function (settings, data, dataIndex) {
                var joiningMin = joiningMinDate;
                var joiningMax = joiningMaxDate;
                var expiringMin = expiringMinDate;
                var expiringMax = expiringMaxDate;
                var joiningDate = new Date(moment($(data[5]).text(), 'DD/MM/YYYY'));
                var expiringDate = new Date(moment($(data[6]).text(), 'DD/MM/YYYY'));

                if (
                    (joiningMin === null && joiningMax === null && expiringMin === null && expiringMax === null) ||
                    (joiningMin <= joiningDate && joiningMax >= joiningDate && expiringMin === null && expiringMax === null) ||
                    (joiningMin === null && joiningMax === null && expiringMin <= expiringDate && expiringMax >= expiringDate) ||
                    (joiningMin <= joiningDate && joiningMax >= joiningDate && expiringMin <= expiringDate && expiringMax >= expiringDate)
                ) {
                    return true;
                } else {
                }
                return false;
            }
        );
    }

    // Hook export buttons
    var exportButtons = () => {
        const documentTitle = 'Members List Report';
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
        }).container().appendTo($('#members_list_views_export'));

        // Hook dropdown menu click event to datatable export buttons
        const exportButtons = document.querySelectorAll('#members_list_views_export_menu [data-members-list-export]');
        exportButtons.forEach(exportButton => {
            exportButton.addEventListener('click', e => {
                e.preventDefault();

                // Get clicked export value
                const exportValue = e.target.getAttribute('data-members-list-export');
                const target = document.querySelector('.dt-buttons .buttons-' + exportValue);

                // Trigger click event on hidden datatable export buttons
                target.click();
            });
        });
    }

    // Delet Rows
    var handleDeleteRows = () => {
        // Select all delete buttons
        const deleteButtons = table.querySelectorAll('[data-kt-ecommerce-membership-list-filter="delete_row"]');

        deleteButtons.forEach(d => {
            // Delete button on click
            d.addEventListener('click', function (e) {
                e.preventDefault();

                // Select parent row
                const parent = e.target.closest('tr');

                // Get category name
                const productName = parent.querySelector('[data-kt-ecommerce-membership-list-filter="product_name"]').innerText;

                // SweetAlert2 pop up
                Swal.fire({
                    text: "Are you sure you want to delete " + productName + "?",
                    icon: "warning",
                    showCancelButton: true,
                    buttonsStyling: false,
                    confirmButtonText: "Yes, delete!",
                    cancelButtonText: "No, cancel",
                    customClass: {
                        confirmButton: "btn fw-bold btn-danger",
                        cancelButton: "btn fw-bold btn-active-light-primary"
                    }
                }).then(function (result) {
                    if (result.value) {
                        Swal.fire({
                            text: "You have deleted " + productName + "!.",
                            icon: "success",
                            buttonsStyling: false,
                            confirmButtonText: "Ok, got it!",
                            customClass: {
                                confirmButton: "btn fw-bold btn-primary",
                            }
                        }).then(function () {
                            // Remove current row
                            datatable.row($(parent)).remove().draw();
                        });
                    } else if (result.dismiss === 'cancel') {
                        Swal.fire({
                            text: productName + " was not deleted.",
                            icon: "error",
                            buttonsStyling: false,
                            confirmButtonText: "Ok, got it!",
                            customClass: {
                                confirmButton: "btn fw-bold btn-primary",
                            }
                        });
                    }
                });
            })
        });
    }

    return {
        init: function () {
            table = document.querySelector('#members-list');

            if (!table) {
                return;
            }

            initDatatable();
            handleSearchDatatable();
            handleTableFilter();
            initFlatpickr();
            handleDeleteRows();
            exportButtons();
        }
    };
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
    MembersList.init();
});
