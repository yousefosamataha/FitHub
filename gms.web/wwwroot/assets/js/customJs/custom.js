// [1] save activated tabs and navigate between them

function sideMenuTabClick(e, event) {
    sessionStorage.setItem("activated-menu-item-tab", e.dataset.menuItemTab);
}

function activeSideMenuTab() {
    let activeSideMenuTab = sessionStorage.getItem("activated-menu-item-tab");
    let menuItemList = document.querySelectorAll(".menu-item.menu-accordion");

    menuItemList.forEach(e => {
        e.querySelectorAll(".menu-item .menu-sub .menu-item").forEach(x => {
            if (x.dataset.menuItemTab == activeSideMenuTab) {
                x.querySelector(".menu-link").classList.add("active");
                const parentWithClass = x.closest('.menu-item.menu-accordion');
                parentWithClass.classList.add("show");
                parentWithClass.querySelector(".menu-link").classList.add("active");
            }
        });
    });
}

// [2] save Sidebar Minimiz Status

function sidebarMinimizeClick(e) {
    if (e.classList.contains("active")) {
        sessionStorage.setItem("sidebar-minimize", false);
    } else {
        sessionStorage.setItem("sidebar-minimize", true);
    }
}

function activeSidebarMinimize() {
    let sidebarMinimizeStatus = sessionStorage.getItem("sidebar-minimize");

    if (sidebarMinimizeStatus == "true") {
        document.getElementById("kt_app_sidebar_toggle").classList.add("active");
        document.querySelector("body").dataset.ktAppSidebarMinimize = "on";
    } else if (sidebarMinimizeStatus == "false") {
        document.getElementById("kt_app_sidebar_toggle").classList.remove("active");
        document.querySelector("body").dataset.ktAppSidebarMinimize = "";
    }
}



activeSideMenuTab();
activeSidebarMinimize();
