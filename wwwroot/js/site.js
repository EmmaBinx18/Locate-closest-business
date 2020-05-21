$(document).ready(function () {      
    $.get("/Login/LoggedIn", function (data) {  
        if(data == true){
            $("#loginButton").html('Login');
        }  
        else{
            $("#loginButton").html('Logout');  
        }
    }); 

    $("#openRegisterBusinessModal").click(function () {
        $.get("/Login/LoggedIn", function (data) {  
            if(data == false){
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
        if($("#loginButton").html() == 'Login'){
            $("#loginModal").modal('show');
        }
        else{
            $.get("/Login/Logout", function () {
                $("#loginButton").html('Login');
            });
        }
    });

    $('#adminLogout').click(function () {
        $.get("/Login/Logout", function () {
            $("#loginButton").html('Login');
        });
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
