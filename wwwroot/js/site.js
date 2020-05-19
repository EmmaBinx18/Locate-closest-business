$(document).ready(function () {      
    $("#openRegisterBusinessModal").click(function () {
        $("#registerBusinessModal").modal('show');  
        $("#step1").css("display", "block");
        $("#step2").css("display", "none");
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
});
