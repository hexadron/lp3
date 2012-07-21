var formatMiliseconds = function(miliseconds) {
  var in_seconds = Math.floor(miliseconds / 1000);
  var seconds = in_seconds % 60;
  var in_minutes = Math.floor(in_seconds / 60);
  var minutes = in_minutes % 60;
  var in_hours = Math.floor(in_minutes / 60);
  var hours = in_hours % 24;
  var in_days = Math.floor(in_hours / 24);
  
  return  $.trim((in_days > 0  ? in_days + "d " : "") +
            (hours > 0    ? hours + "h " : "") +
            (minutes > 0  ? minutes + "m " : "") +
            (seconds > 0  ? seconds + "s " : ""));
};

var calcTimeToDate = function(date, callback, endCallback) { 
  var doWork = function() {
    var now = new Date();
    if (date > now) {
      var milisecondsDifference = date - now
      callback(formatMiliseconds(milisecondsDifference))
      setTimeout(doWork, 1000)
    } else {
      endCallback()
    }
  }
  setTimeout(doWork, 1000)
}

var showExpiration = function () {
  $('.product-time').each(function (i, el) {
    var self = $(el)
    var date = new Date(self.data('expirein'))
    
    calcTimeToDate(date, function(timeToDie) {
      self.find('.experin').html(timeToDie)
    }, function() {
      self.html('producto expirado')
    })
    
  })
}

$(function () {

    $('.qtyhidden').each(function (i, e) {
        var tr = $(e).closest('tr')
        var id = tr.attr('id')
        tr.find('input[type="text"]').val($(e).val())
        tr.find('input[type="hidden"]').eq(1).val(id)
                
    })

    showExpiration()


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

});