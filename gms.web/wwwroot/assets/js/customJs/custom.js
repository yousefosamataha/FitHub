"use strict";

// Class definition
var globalClass = function () {
    // [1] Activat SideMenu Tab
    var activeSideMenuTab = function () {
        let pathname = window.location.pathname;

        document.querySelectorAll("[side-menu-item='true']").forEach(x => {
            if (pathname === x.querySelector("a").getAttribute("href")) {
                x.querySelector("a").classList.add("active");
                const parentWithClass = x.closest('.menu-item.menu-accordion');
                const grandparentWithClass = x.closest('.menu-item.menu-accordion.grand-parent');
                if (grandparentWithClass) {
                    grandparentWithClass.classList.add("show");
                    grandparentWithClass.querySelector(".menu-link").classList.add("active");
                    parentWithClass.classList.add("show");
                }else if (parentWithClass) {
                    parentWithClass.classList.add("show");
                    parentWithClass.querySelector(".menu-link").classList.add("active");
                }
            }
        });
    }

    // [2] Sidebar Minimiz Status
    var sidebarMinimizeClick = function () {
        if (document.getElementById("kt_app_sidebar_toggle")) {
            document.getElementById("kt_app_sidebar_toggle").addEventListener("click", () => {
                if (document.getElementById("kt_app_sidebar_toggle").classList.contains("active")) {
                    sessionStorage.setItem("sidebar-minimize", false);
                } else {
                    sessionStorage.setItem("sidebar-minimize", true);
                }
            });
        }
    }

    var activeSidebarMinimize = function () {
        let sidebarMinimizeStatus = sessionStorage.getItem("sidebar-minimize");

        if (sessionStorage.getItem("sidebar-minimize") == "true") {
            document.getElementById("kt_app_sidebar_toggle").classList.add("active");
            document.querySelector("body").dataset.ktAppSidebarMinimize = "on";
        } else if (sidebarMinimizeStatus == "false") {
            document.getElementById("kt_app_sidebar_toggle").classList.remove("active");
            document.querySelector("body").dataset.ktAppSidebarMinimize = "";
        }
    }

    // [3] Check Language
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

    // [4] Specify Flatpickr Language
    function specifyFlatpickrLanguage() {
        let currentLanguage = getCookie(".AspNetCore.Culture").split("=").slice(-1)[0];
        let flatpickrOptions = currentLanguage === "ar-EG" ? {
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

        return flatpickrOptions;
    }

    // [5] SignOut Button Submit Action
    function signOut() {
        $("#SignOutButton").on('click', function () {
            $(this).parent().submit();
        });
    }

    // [6] Declare Toastr Options
    toastr.options = {
        "closeButton": true,
        "debug": false,
        "newestOnTop": true,
        "progressBar": false,
        "positionClass": "toastr-top-center",
        "preventDuplicates": false,
        "onclick": null,
        "showDuration": "300",
        "hideDuration": "1000",
        "timeOut": "500000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    };

    // [7] Handle Delete Tooltip
    var handleDeleteTooltip = function () {
        document.querySelectorAll(".tooltip").forEach(e => e.remove());
    }

    return {
        init: function () {
            activeSideMenuTab();
            sidebarMinimizeClick();
            activeSidebarMinimize();
            signOut();
        },
        checkLanguage: function (cname) {
            return getCookie(cname);
        },
        flatpickrLanguage: specifyFlatpickrLanguage(),
        handleTooltip: () => handleDeleteTooltip()
    };
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
    globalClass.init();
});

export { globalClass };