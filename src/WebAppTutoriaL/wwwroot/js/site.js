/// <reference path="../lib/jquery/dist/jquery.min.js" />
//site.js
(function () {
    //var ele = $('#username');
    //ele.text = "Shawn Wildermuth";

    //var main = $('#main');

    //main.on('mouseenter', function () {
    //    main.style = "background-color: #888;";
    //});
    //main.on('mouseleave', function () {
    //    main.style = "";
    //});

    //var menuitems = $('ul.menu li a');
    //menuitems.on('click', function () {
    //    var me = $(this);
    //    alert(me.text());
    //});


    var $sidebarandwrapper = $('#sidebar,#wrapper');
    var $icon = $('#sidebarToggle i.fa');

    $('#sidebarToggle').on('click', function () {
        $sidebarandwrapper.toggleClass('hide-sidebar');
        if ($sidebarandwrapper.hasClass('hide-sidebar')) {
            $icon.removeClass('fa-angle-left');
            $icon.addClass('fa-angle-right');
        } else {
            $icon.addClass('fa-angle-left');
            $icon.removeClass('fa-angle-right');
        }
    })
})();