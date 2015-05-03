$(function() {
    $('.store-menu-lg li, .store-menu-md li, .store-menu-sm li').hover(function () {
            $(this).find('a').css('color', 'grey');
        },
        function() {
            $(this).find('a').css('color', '');
        });
})