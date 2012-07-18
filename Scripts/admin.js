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

    $('input[type=file]').on('change', function (evt) {
        $('form').on('submit', preventSubmit)
        upload(this.files[0], function (link) {
            $('#ContentPlaceHolder1_TxtFoto').val(link)
            $('form').off('submit', preventSubmit)
        })
    })

})

function upload(file, callback) {

    // file is from a <input> tag or from Drag'n Drop
    // Is the file an image?

    if (!file || !file.type.match(/image.*/)) return;

    // It is!
    // Let's build a FormData object

    var fd = new FormData();
    fd.append("image", file); // Append the file
    fd.append("key", "6528448c258cff474ca9701c5bab6927");
    // Get your own key: http://api.imgur.com/

    // Create the XHR (Cross-Domain XHR FTW!!!)
    var xhr = new XMLHttpRequest();
    xhr.open("POST", "http://api.imgur.com/2/upload.json"); // Boooom!
    xhr.onload = function () {
        // Big win!
        // The URL of the image is:
        var upload = JSON.parse(xhr.responseText).upload;
        callback(upload.links.original);
    }
    // Ok, I don't handle the errors. An exercice for the reader.
    // And now, we send the formdata
    xhr.send(fd);
}