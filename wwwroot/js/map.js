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