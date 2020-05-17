google.maps.event.addDomListener(window, 'load', initialize);
function initialize() {
    var autocomplete = new google.maps.places.Autocomplete(
        document.getElementById('Address'), 
        {
            componentRestrictions: { country: 'ZA' }, 
            types: ["geocode"]  // 'establishment' / 'address' / 'geocode'
        });
    google.maps.event.addListener(autocomplete, 'place_changed', function () {
        // Get the place details from the autocomplete object.
        var place = autocomplete.getPlace();
        $('#Address').val(place.formatted_address);  
        $('#Address_Latitude').val(place.geometry.location.lat());  
        $('#Address_Latitude').val(place.geometry.location.lng()); 
    });
}