"use strict";
import { globalClass } from './custom.js';

// Class definition
var membershipsList = function () {
    // Shared variables
    var table;
    var datatable;
    var creationDateflatpickr;
    var creationMinDate, creationMaxDate;
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
                { render: DataTable.render.number(',', '.', 2), targets: 2 },
                { render: DataTable.render.number(',', '.', 2), targets: 3 },
                { orderable: false, targets: [4, 6] }, // Disable ordering on column 5 (status), 7 (actions)
            ],
            "lengthMenu": [[-1, 5, 10, 50], ["All", 5, 10, 50]],
            "pagingType": "full_numbers"
        });
            
        // Re-init functions on datatable re-draws
        datatable.on('draw', function () {
            // handleDeleteRows();
            // convertEnglishDigitsToArabicDigits();
        });
    }

    // datatable pageing tap number
    $.fn.DataTable.ext.pager.numbers_length = 5;

    // Search Datatable
    var handleSearchDatatable = () => {
        const filterSearch = document.querySelector('[memberships-list-filter="search"]');
        filterSearch.addEventListener('keyup', function (e) {
            datatable.search(e.target.value).draw();
        });
    }

    // Init Creation Date Flatpickr
    var initFlatpickr = () => {
        const element = document.querySelector('[memberships-list-creation-date-range-filter="filter"]');
        creationDateflatpickr = $(element).flatpickr({
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
        });
    }

    // Filter Datatable
    var handleTableFilter = function () {
        // Select filter options
        const filterForm = document.querySelector('[memberships-list-filter="form"]');
        const filterButton = filterForm.querySelector('[memberships-list-table-filter="filter"]');
        const resetButton = filterForm.querySelector('[memberships-list-table-reset="reset"]');
        const selectOption = filterForm.querySelector('[memberships-list-filter="status"]');
        const creationDateRangeFilter = filterForm.querySelector('[memberships-list-creation-date-range-filter="filter"]');

        // Filter datatable on submit
        filterButton.addEventListener('click', function () {
            // Get filter values
            handleSelectOptionFilter(selectOption.value);

            // Filter Daterange
            handleFlatpickrFilter(creationDateRangeFilter._flatpickr.selectedDates);

            // Filter datatable
            datatable.draw();
        });

        // Reset datatable
        resetButton.addEventListener('click', function () {
            // Reset Satus
            $(selectOption).val(null).trigger('change');

            // Reset Flatpickr
            creationDateflatpickr.clear();

            // Filter datatable
            $.fn.dataTable.ext.search = new Array(0);
            datatable.search("").draw();
        });
    }

    // Handle flatpickr
    var handleFlatpickrFilter = (creationDates) => {
        creationMinDate = creationDates[0] || creationDates[0] != undefined ? new Date(creationDates[0]) : null;
        creationMaxDate = creationDates[1] || creationDates[1] != undefined ? new Date(creationDates[1]) : null;

        // Datatable date filter
        $.fn.dataTable.ext.search.push(
            function (settings, data, dataIndex) {
                var min = creationMinDate;
                var max = creationMaxDate;
                var creationDate = new Date(moment($(data[5]).text(), 'DD/MM/YYYY'));

                if ((min === null && max === null) ||
                    (min <= creationDate && max === null) ||
                    (min <= creationDate && max >= creationDate)
                ) {
                    return true;
                }
                return false;
            }
        );
    }

    var handleSelectOptionFilter = (selectOptionValue) => {
        // Datatable date filter
        $.fn.dataTable.ext.search.push(
            function (settings, data, dataIndex) {
                var statusDate = data[4].trim();
                selectOptionValue = selectOptionValue != "" ? selectOptionValue : statusDate;

                if (statusDate === selectOptionValue && statusDate.length === selectOptionValue.length) {
                    return true;
                }
                return false;
            }
        );
    }

    // Edite Membership
    var editMembership = () => {
        document.querySelectorAll(".edit-membership-btn").forEach(e => {
            e.addEventListener("click", function () {
                window.location.href = `/Membership/EditMembership?id=${e.dataset.id}&branchId=${e.dataset.branchId}`;
            });
        });
    }

    // Delete Membership
    var deleteMembership = () => {
        // Select all delete buttons
        const deleteButtons = table.querySelectorAll('.delete-membership-btn');

        deleteButtons.forEach(d => {
            d.addEventListener("click", function (e) {
                // Select parent row
                const parent = e.target.closest('tr');

                $.ajax({
                    url: '/Membership/DeleteMembership',
                    type: 'POST',
                    data: {
                        id: e.target.dataset.id,
                        branchId: e.target.dataset.branchId
                    },
                    success: function (response) {
                        // Remove current row
                        datatable.row($(parent)).remove().draw();
                        globalClass.handleTooltip();
                        toastr.success("Membership Deleted Successfully!");
                    },
                    error: function (xhr, status, error) {
                        console.error('Error:', error);
                    }
                });

                // window.location.href = `/Membership/DeleteMembership?id=${e.dataset.id}&branchId=${e.dataset.branchId}`;
            });
        });
    }

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
    /*var convertEnglishDigitsToArabicDigits = () => {
        const deleteButtons = table.querySelectorAll('.convert-english-digits-to-arabic-digits');
        const arabicDigits = ['۰', '۱', '۲', '۳', '٤', '٥', '٦', '۷', '۸', '۹'];

        if (deleteButtons.length > 0) {
            deleteButtons.forEach(d => {
                d.style.direction = "ltr";
                d.style.fontSize = "medium";
                d.innerText = d.innerText.replace(/[0-9]/g, function (w) {
                    return arabicDigits[+w];
                });
            });
        } else {
            return;
        }
    }*/

    // Public methods
    return {
        init: function () {
            table = document.querySelector('#membership-list');

            if (!table) {
                return;
            }

            initDatatable();
            initFlatpickr();
            handleSearchDatatable();
            handleTableFilter();
            // handleDeleteRows();
            // convertEnglishDigitsToArabicDigits();
            editMembership();
            deleteMembership();
        }
    };
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
    membershipsList.init();
});