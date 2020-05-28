$(document).ready(function () { 
    var scripts = document.getElementsByTagName("script");
    var message = "";

    for (var i = 0, len = scripts.length; i < len; i++) {
        var src = scripts[i].getAttribute("src").split("?");
        message = src[1];
    }

    $('.display-success-message').css("display", "none");
    $('.display-error-message').css("display", "block");
    $('.display-error-message').html(message);
    setTimeout(function(){
        $('.display-error-message').css("display", "none");
    }, 3000); 
});