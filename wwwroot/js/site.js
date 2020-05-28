$(document).ready(function () {      
    if(!isUserLoggedIn()){
        $("#login-button").html('Login');
    }  
    else{
        $("#login-button").html('Logout');  
    }

    $("#open-register-business-modal").click(function () {
        if(!isUserLoggedIn()){
            $("#login-admin").modal('show');
        }  
        else{
            $("#register-business-modal").modal('show');  
            $("#step1").css("display", "block");
            $("#step2").css("display", "none");
            $("#view-requests").css("display", "none");
        }
    });

    $('#login-button').click(function () {
        if($("#login-button").html() == 'Login'){
            $("#login-admin").modal('show');
        }
        else{
            logout();
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

    $("#admin-logout").click(function() {
        logout();
    });
});

function isUserLoggedIn(){
    var userId = $("#userId").val();
    return (userId && userId.length > 0);
}

function logout(){
    $("#userId").val("");
    $("#login-button").html('Login');
}