$(document).ready(function () {      

    // $.get("/Login/LoggedIn", function (data) {  
    //     console.log(data);
    //     if(data == true){
    //         $("#login-button").html('Login');
    //     }  
    //     else{
    //         $("#login-button").html('Logout');  
    //     }
    // }); 

    if(!isUserLoggedIn()){
        $("#login-button").html('Login');
    }  
    else{
        $("#login-button").html('Logout');  
    }

    $("#open-register-business-modal").click(function () {
        // $.get("/Login/LoggedIn", function (data) {  
        //     console.log(data);
        //     if(data == true){
        //         $("#login-admin").modal('show');
        //     }  
        //     else{
        //         $("#register-business-modal").modal('show');  
        //         $("#step1").css("display", "block");
        //         $("#step2").css("display", "none");
        //         $("#view-requests").css("display", "none");
        //     }
        // }); 
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
            // $.get("/Login/Logout", function () {
            //     $("#login-button").html('Login');
            // });
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

var map;
var infowindow;
var usersPosition;
var searchMarkers = [];

var myStyles = [
    {
        featureType: "poi",
        elementType: "labels",
        stylers: [
            { visibility: "off" }
        ]
    }
];

window.onload = function () {
    if (this.navigator.geolocation) {
        this.navigator.geolocation.getCurrentPosition(function (position) {
            usersPosition = new google.maps.LatLng(position.coords.latitude, position.coords.longitude);
            infowindow = new google.maps.InfoWindow();

            map = new google.maps.Map(
                document.getElementById('dvMap'), { center: usersPosition, zoom: 18, styles: myStyles });

            var marker = new google.maps.Marker({
                map: map,
                position: usersPosition,
                label: "You Are Here"
            });
        })
    }
}

function performSearch() {
    clearMarkers();

    var pServiceCategory = document.getElementById("essentialServiceOptions").options[document.getElementById("essentialServiceOptions").selectedIndex].text;
    //alert(usersPosition.lat() + " :: " + usersPosition.lng());

    $.ajax({
        type: 'GET',
        url: 'Home/MapsNearbySearch',
        data: {
            "lat": usersPosition.lat(),
            "lng" : usersPosition.lng(),
            "category" : pServiceCategory,
            "searchRadius" : 2500
        },
        success: function (returnData)
        {

            if (returnData.status === "OK") {
                clearMarkers(map);
                for (var i = 0; i < returnData.results.length; i++) {
                    createMarker(returnData.results[i]);
                }
            }
        }
    });
    
    map.setZoom(14);
}

function createMarker(place) {
    if (place.business_status == "OPERATIONAL") {

        var marker = new google.maps.Marker({
            map: map,
            position: place.geometry.location,
            label: place.name
        });

        google.maps.event.addListener(marker, 'click', function () {
            infowindow.setContent(place.business_status);
            infowindow.open(map, this);
        });

        searchMarkers.push(marker);
    }         
}

function clearMarkers(map) {
    for (var i = 0; i < searchMarkers.length; i++) {
        searchMarkers[i].setMap(null);
    }
    searchMarkers = [];
}

function isUserLoggedIn(){
    var userId = $("#userId").val();
    return (userId && userId.length > 0);
}

function logout(){
    $("#userId").val("");
    $("#login-button").html('Login');
}