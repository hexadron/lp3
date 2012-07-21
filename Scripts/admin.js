$(function () {

    $('#ContentPlaceHolder1_TxtTiempoExpiracion').datepicker({
        minDate: 0
    })

    var validators = $('.validation span')

    $('#form1').click(function (evt) {
        var errors = validators.filter(function (i, e) {
            return $(e).css('display') != 'none' &&
                   $(e).css('visibility') != 'hidden'
        })

        if (errors.length > 0) {
            evt.preventDefault()
        }
    })

    var preventSubmit = function (evt) {
        evt.preventDefault()
    }

    var spinOptions = {
        lines: 9,
        length: 7,
        width: 2,
        radius: 5,
        rotate: 28,
        trail: 34,
        speed: 1.4,
        hwaccel: true,
        color: '#fff'
    };

    $('input[type=file]').on('change', function (evt) {
        $('form').on('submit', preventSubmit)
        var spin = new Spinner(spinOptions).spin(document.getElementById('loader'))
        upload(this.files[0], function (link) {
            spin.stop()
            $('#ContentPlaceHolder1_TxtFoto').val(link)
            $('form').off('submit', preventSubmit)
        })
    })

})

function upload(file, callback) {
    if (!file || !file.type.match(/image.*/)) return;

    var fd = new FormData();
    fd.append("image", file);
    fd.append("key", "6528448c258cff474ca9701c5bab6927");

    var xhr = new XMLHttpRequest();
    xhr.open("POST", "http://api.imgur.com/2/upload.json");
    xhr.onload = function () {
        var upload = JSON.parse(xhr.responseText).upload;
        callback(upload.links.original);
    }

    xhr.send(fd);
}