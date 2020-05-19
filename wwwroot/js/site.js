$(document).ready(function () {      
    $("#openRegisterBusinessModal").click(function () { 
        // $("#registerBusinessModal").modal('show');  
        // $("#step1").css("display", "block");
        // $("#step2").css("display", "none");
        $("#signupModal").modal('show');
    });
    
    $("#step1 .nextButton").click(function() {
        $("#step1").css("display", "none");
        $("#step2").css("display", "block");
    });

    $("input").focus(function() {
        $(".errorSpace").css("display", "none");
    });

    $("textarea").focus(function() {
        $(".errorSpace").css("display", "none");
    });

    $("select").focus(function() {
        $(".errorSpace").css("display", "none");
    });

    $("#stagesButton").click(function() {
        $("#stages").toggle();
    });

    $(".signUpLink").click(function(){
        location.href = '/Home/Signup';
    });

    $(".loginLink").click(function(){
        $("#loginModal").modal('show');
    });
});
