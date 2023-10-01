

[...document.querySelectorAll('.app-sidebar-menu-primary.menu>.menu-item .menu-item .menu-link')].forEach(function (item) {
    item.addEventListener('click', function () {
        [...document.querySelectorAll('.app-sidebar-menu-primary.menu>.menu-item .menu-item .menu-link')].forEach(function (e) {
            e.classList.remove("active");
        });
        item.classList.add("active");
    });
});