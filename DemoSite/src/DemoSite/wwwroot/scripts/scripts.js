
$(document).ready(function () {/* affix the navbar after scroll below header */
    $('#nav').affix({
        offset: {
            top: $('header').height() - $('#nav').height()
        }
    });

    /* highlight the top nav as scrolling occurs */
    $('body').scrollspy({ target: '#nav' })

    /* smooth scrolling for scroll to top */
    $('.scroll-top').click(function () {
        $('body,html').animate({ scrollTop: 0 }, 1000);
    })

    /* smooth scrolling for nav sections */
    $('#nav .navbar-nav li>a').click(function () {
        var link = $(this).attr('href').replace(/\//g, "");
        var posi = $(link).offset().top - 60;
        $('body,html').animate({ scrollTop: posi }, 700);
        $('#nav .navbar-nav li').removeClass("active");
        $(this).parent().addClass("active");
    })

    if ($('#nav .navbar-nav .active').length == 0) {
        var path = window.location.pathname;
        var link = $('#nav .navbar-nav li a[href="' + path + '"]');
        if (link.length == 1) link.parent().addClass("active");
    }

});
