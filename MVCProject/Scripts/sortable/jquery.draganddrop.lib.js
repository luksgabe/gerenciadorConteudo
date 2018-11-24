$(function () {
    $('.thumbnail-sortable').sortable({
        placeholderClass: 'col-sm-6 col-md-4'
    });
    $('.table-sortable tbody').sortable({
        handle: 'span'
    });
    $('.list-group-sortable').sortable({
        placeholderClass: 'list-group-item'
    });
    $('.list-group-sortable-exclude').sortable({
        placeholderClass: 'list-group-item',
        items: ':not(.disabled)'
    });
    $('.list-group-sortable-handles').sortable({
        placeholderClass: 'list-group-item',
        handle: 'span'
    });
    $('.list-group-sortable-connected').sortable({
        placeholderClass: 'list-group-item',
        connectWith: '.connected'
    });
});


var _gaq = _gaq || [];
_gaq.push(['_setAccount', 'UA-36251023-1']);
_gaq.push(['_setDomainName', 'jqueryscript.net']);
_gaq.push(['_trackPageview']);

(function () {
    var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
    ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
    var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
})();