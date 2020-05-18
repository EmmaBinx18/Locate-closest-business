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
        var town;
        for (var i = 0; i < place.address_components.length; i++) {
            for (var j = 0; j < place.address_components[i].types.length; j++) {

                if(place.address_components[i].types[j] === "locality"){
                    town = place.address_components[i].long_name;
                } else {
                    if(!town && place.address_components[i].types[j] === "administrative_area_level_2" )
                        town = place.address_components[i].long_name;
                }
            }
        }
        console.log(town);
        $('#Address').val(place.formatted_address);  
        $('#AddressLatitude').val(place.geometry.location.lat());  
        $('#AddressLongitude').val(place.geometry.location.lng()); 
        $('#AddressTown').val(town); 
    });
}