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
    var checkbox = document.getElementById('open');
    var requestData = {
        "lat": usersPosition.lat(),
        "lng" : usersPosition.lng(),
        "category" : pServiceCategory,
        "searchRadius" : 2500
    };

    if (checkbox.checked == true)
    {
        requestData["opennow"] = true;
    }

    $.ajax({
        type: 'GET',
        url: 'Home/MapsNearbySearch',
        data: requestData,
        success: function (returnData)
        {
            if (returnData.status === "OK") {
                clearMarkers();
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
        var customIcon = {
            url: place.icon,
            scaledSize: new google.maps.Size(35, 35),
            origin: new google.maps.Point(0,0),
            anchor: new google.maps.Point(0, 0)
        };

        if (place.icon != "")
        {
            var marker = new google.maps.Marker({
                map: map,
                position: place.geometry.location,
                label: place.name,
                icon: customIcon
            });
        }
        else
        {
            var marker = new google.maps.Marker({
                map: map,
                position: place.geometry.location,
                label: place.name
            });
        }

        google.maps.event.addListener(marker, 'click', function () {
            var infoContent = place.name + "<br>Status: " + place.business_status;

            if (place.rating != null  && place.rating < 6) {infoContent += "<br>Rating: " + place.rating;}
            if (place.price_level != null  && place.price_level != "6") {infoContent += "<br>Price Level: " + place.price_level;}
            if (place.vicinity != null && place.vicinity != "") {infoContent += "<br>Vacinity: " + place.vicinity;}

            infowindow.setContent(infoContent);
            infowindow.open(map, this);
        });

        searchMarkers.push(marker);
    }         
}

function clearMarkers() {
    for (var i = 0; i < searchMarkers.length; i++) {
        searchMarkers[i].setMap(null);
    }
    searchMarkers = [];
}