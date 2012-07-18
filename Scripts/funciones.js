$(function () {

    $(".add").click(function () {
        var id = $(this).closest('.detail').data('shirt')
        $('#ContentPlaceHolder1_item').val(id).closest('form').submit();
    })

    $('#da-slider').cslider({
        bgincrement: 0
    });

    $.getJSON('https://api.twitter.com/1/statuses/user_timeline/carloshs92.json?callback=?',
		function (data) {
		    for (var i = 0; i < 3; i++) {
		        $("#twitter ul").append("<li><img src='img/twitt.png' alt='face" + i + "' width='50'/><span class='textTwitt'>" + data[i].text + "</span></li>");
		    }
		}
	);

    $(".thumb").hover(
	function () {
	    $(this).children('img').stop().animate({ left: '-300' }, 1000);
	},
	function () {
	    $(this).children('img').stop().animate({ left: '-14' }, 800)
	});

    $(".zoom").click(function (evt) {
        evt.stopPropagation();
        $(this).zoomTo();
    });
    $(window).click(function (evt) {
        evt.stopPropagation();
        $("body").zoomTo();
    });
    $("body").zoomTo();

});