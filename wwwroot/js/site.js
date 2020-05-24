$(document).ready(function () {      
    $.get("/Login/LoggedIn", function (data) {  
        if(data == true){
            $("#login-button").html('Login');
        }  
        else{
            $("#login-button").html('Logout');  
        }
    }); 

    $("#open-register-business-modal").click(function () {
        $.get("/Login/LoggedIn", function (data) {  
            if(data == true){
                $("#login-admin").modal('show');
            }  
            else{
                $("#register-business-modal").modal('show');  
                $("#step1").css("display", "block");
                $("#step2").css("display", "none");
                $("#view-requests").css("display", "none");
            }
        }); 
    });

    $('#login-button').click(function () {
        if($("#login-button").html() == 'Login'){
            $("#login-admin").modal('show');
        }
        else{
            $.get("/Login/Logout", function () {
                $("#login-button").html('Login');
            });
        }
    });

    $('#admin-logout').click(function () {
        $.get("/Login/Logout", function () {
            $("#login-button").html('Login');
        });
    });
    
    $("#step1 .next-button").click(function() {
        $("#step1").css("display", "none");
        $("#step2").css("display", "block");
    });

    $("#step1 .view-businesses-button").click(function() {
        $("#step1").css("display", "none");
        $("#view-requests").css("display", "block");
    });

    $("#stages-button").click(function() {
        $("#stages").toggle();
    });

    $(".signup-link").click(function(){
        $("#signup-modal").modal('show');
        $("#login-admin").modal('hide');
    });

    $(".login-link").click(function(){
        $("#login-admin").modal('show');
        $("#signup-modal").modal('hide');
    });
});
