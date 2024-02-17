"use strict";
import { globalClass } from './custom.js';

// Class definition
var MembershipList = function () {
    // Shared variables
    var table;
    var datatable;
    var flatpickr;
    var minDate, maxDate;
    var currentLanguage = globalClass.checkLanguage(".AspNetCore.Culture").split("=").slice(-1)[0];
    var datatableLanguage = currentLanguage == "ar-EG" ? "ar" : currentLanguage == "fr-FR" ? "fr" : "en";

    // Init Datatable
    var initDatatable = function () {
        // Init datatable
        datatable = $(table).DataTable({
            language: {
                url: `assets/plugins/localization/datatable-${datatableLanguage}.json`,
            },
            "info": true,
            'order': [],
            'pageLength': 5,
            'columnDefs': [
                { render: DataTable.render.number(',', '.', 2), targets: 3 },
                { render: DataTable.render.number(',', '.', 2), targets: 4 },
                { orderable: false, targets: [0, 5, 7] }, // Disable ordering on column 1 (photo), 4 (status), 5 (actions)
            ],
            "lengthMenu": [[-1, 5, 10, 50], ["All", 5, 10, 50]],
            "pagingType": "full_numbers"
        });

            
        // Re-init functions on datatable re-draws
        datatable.on('draw', function () {
            handleDeleteRows();
            // convertEnglishDigitsToArabicDigits();
        });
    }

    // datatable pageing tap number
    $.fn.DataTable.ext.pager.numbers_length = 5;

    // Init flatpickr
    var initFlatpickr = () => {
        const element = document.querySelector('#kt_ecommerce_sales_flatpickr');
        flatpickr = $(element).flatpickr({
            // locale: "ar",
            // weekNumbers: true,
            // altInput: true,
            // enableTime: true,
            // dateFormat: "Y-m-d H:i",
            // locale: flatpickrOptions,
            locale: globalClass.flatpickrLanguage,
            dateFormat: "Y-m-d",
            altFormat: "d/m/Y",
            mode: "range",
            //ranges: {
            //    'Today': [moment(), moment()],
            //    'Yesterday': [moment().subtract(1, 'days'), moment().subtract(1, 'days')],
            //    'Last 7 Days': [moment().subtract(6, 'days'), moment()],
            //    'Last 30 Days': [moment().subtract(29, 'days'), moment()],
            //    'This Month': [moment().startOf('month'), moment().endOf('month')],
            //    'Last Month': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')]
            //},
            onChange: function (selectedDates, dateStr, instance) {
                handleFlatpickr(selectedDates, dateStr, instance);
            },
        });
    }

    // Search Datatable
    var handleSearchDatatable = () => {
        const filterSearch = document.querySelector('[membership-list-filter="search"]');
        filterSearch.addEventListener('keyup', function (e) {
            datatable.search(e.target.value).draw();
        });
    }

    // Handle status filter dropdown
    var handleStatusFilter = () => {
        const filterStatus = document.querySelector('[membership-list-filter="status"]');
        $(filterStatus).on('change', e => {
            let value = e.target.value;
            //let value = e.target.innerText;
            console.log(value);
            if (value === 'all') {
                value = '';
            }
            datatable.column(5).search(value).draw();
        });
    }

    // Handle flatpickr
    var handleFlatpickr = (selectedDates, dateStr, instance) => {
        minDate = selectedDates[0] ? new Date(selectedDates[0]) : null;
        maxDate = selectedDates[1] ? new Date(selectedDates[1]) : null;

        // Datatable date filter
        $.fn.dataTable.ext.search.push(
            function (settings, data, dataIndex) {
                var min = minDate;
                var max = maxDate;
                var creationDate = new Date(moment($(data[6]).text(), 'DD/MM/YYYY'));

                if ((min === null && max === null) ||
                    (min <= creationDate && max === null) ||
                    (min <= creationDate && max >= creationDate)
                ) {
                    return true;
                }
                return false;
            }
        );
        datatable.draw();
    }

    // Handle clear flatpickr
    var handleClearFlatpickr = () => {
        const clearButton = document.querySelector('#kt_ecommerce_sales_flatpickr_clear');
        clearButton.addEventListener('click', e => {
            flatpickr.clear();
        });
    }

    // Handle DateRange Pickers
    //var createDateRangePickers = function () {
    //    // Check if jQuery included
    //    if (typeof jQuery == 'undefined') {
    //        return;
    //    }

    //    // Check if daterangepicker included
    //    if (typeof $.fn.daterangepicker === 'undefined') {
    //        return;
    //    }

    //    var elements = [].slice.call(document.querySelectorAll('[data-kt-daterangepicker="true"]'));
    //    var start = moment().subtract(29, 'days');
    //    var end = moment();

    //    elements.map(function (element) {
    //        if (element.getAttribute("data-kt-initialized") === "1") {
    //            return;
    //        }

    //        var display = element.querySelector('div');
    //        var attrOpens = element.hasAttribute('data-kt-daterangepicker-opens') ? element.getAttribute('data-kt-daterangepicker-opens') : 'left';
    //        var range = element.getAttribute('data-kt-daterangepicker-range');

    //        var cb = function (start, end) {
    //            var current = moment();

    //            if (display) {
    //                if (current.isSame(start, "day") && current.isSame(end, "day")) {
    //                    display.innerHTML = start.format('D MMM YYYY');
    //                } else {
    //                    display.innerHTML = start.format('D MMM YYYY') + ' - ' + end.format('D MMM YYYY');
    //                }
    //            }
    //        }

    //        if (range === "today") {
    //            start = moment();
    //            end = moment();
    //        }

    //        $(element).daterangepicker({
    //            startDate: start,
    //            endDate: end,
    //            opens: attrOpens,
    //            ranges: {
    //                'Today': [moment(), moment()],
    //                'Yesterday': [moment().subtract(1, 'days'), moment().subtract(1, 'days')],
    //                'Last 7 Days': [moment().subtract(6, 'days'), moment()],
    //                'Last 30 Days': [moment().subtract(29, 'days'), moment()],
    //                'This Month': [moment().startOf('month'), moment().endOf('month')],
    //                'Last Month': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')]
    //            }
    //        }, cb);

    //        cb(start, end);

    //        element.setAttribute("data-kt-initialized", "1");
    //    });
    //}

    // Delete cateogry
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

    // Convert English Digits To Arabic Digits
    //var convertEnglishDigitsToArabicDigits = () => {
    //    const deleteButtons = table.querySelectorAll('.convert-english-digits-to-arabic-digits');
    //    const arabicDigits = ['۰', '۱', '۲', '۳', '٤', '٥', '٦', '۷', '۸', '۹'];

    //    if (deleteButtons.length > 0) {
    //        deleteButtons.forEach(d => {
    //            d.style.direction = "ltr";
    //            d.style.fontSize = "medium";
    //            d.innerText = d.innerText.replace(/[0-9]/g, function (w) {
    //                return arabicDigits[+w];
    //            });
    //        });
    //    } else {
    //        return;
    //    }
    //}

    // Public methods
    return {
        init: function () {
            table = document.querySelector('#membership_list');

            if (!table) {
                return;
            }

            initDatatable();
            initFlatpickr();
            handleSearchDatatable();
            handleStatusFilter();
            handleDeleteRows();
            handleClearFlatpickr();
            // convertEnglishDigitsToArabicDigits();
        }
    };
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
    MembershipList.init();
});
