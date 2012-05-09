$(function(){
	
	$('#da-slider').cslider({
		bgincrement	: 0
	});
				
	$.getJSON('https://api.twitter.com/1/statuses/user_timeline/carloshs92.json?callback=?',
		function(data){
			for(var i=0; i<2; i++)
			{
				$("#twitter ul").append("<li><img src='img/logo.png' alt='face"+i+"' width='50'/><span class='textTwitt'>"+data[i].text+"</span></li>");
			}
		}
	);
	
	$(".thumb").hover(
	function(){
		$(this).children('img').stop().animate({left:'-300'},1000);
	},
	function(){
		$(this).children('img').stop().animate({left:'-14'},800)
	});
			
});