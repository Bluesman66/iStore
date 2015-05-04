$(function () {
    $('.store-menu-lg li, .store-menu-md li, .store-menu-sm li').hover(
        function () {
            $(this).css('cursor', 'pointer');
            $(this).find('a').css('color', 'grey');
        },
        function () {
            $(this).find('a').css('color', '');
            $(this).css('cursor', 'default');
        }).click(function (e) {
            e.stopPropagation();
            e.preventDefault();
            var href = $(this).find('a').attr('href');
            if (href) {
                window.location = href;
            }
        });

    $('.store-menu-lg li > a, .store-menu-md li > a, .store-menu-sm li > a').click(
        function (e) {
            e.stopPropagation();
            e.preventDefault();
            var href = $(this).attr('href');
            if (href) {
                window.location = href;
            }
        });

    $('ul.pagination li.disabled > a').click(function(e) {
        e.preventDefault();
    });
})