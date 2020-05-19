$(document).ready(function () {      
    $("#openRegisterBusinessModal").click(function () {
        var url = "/Login/LoggedIn";  
        $.get(url, function (data) {  
            if(data == true){
                $("#loginModal").modal('show');
            }  
            else{
                $("#registerBusinessModal").modal('show');  
                $("#step1").css("display", "block");
                $("#step2").css("display", "none");
            }
        }); 
    });

    $('#loginButton').click(function () {
        $("#loginModal").modal('show');
    });
    
    $("#step1 .nextButton").click(function() {
        $("#step1").css("display", "none");
        $("#step2").css("display", "block");
    });

    $("#stagesButton").click(function() {
        $("#stages").toggle();
    });

    $(".signUpLink").click(function(){
        $("#signupModal").modal('show');
        $("#loginModal").modal('hide');
    });

    $(".loginLink").click(function(){
        $("#loginModal").modal('show');
        $("#signupModal").modal('hide');
    });

    $(".list-unstyled a").click(function(){
        $(".list-unstyled").find(".active").removeClass("active");
        $(this).parent().addClass("active");
     });
});
