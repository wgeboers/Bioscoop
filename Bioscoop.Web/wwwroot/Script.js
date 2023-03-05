

function initialize() {
    var latlng = new google.maps.LatLng(51.583957, 4.795526);
    var options = {
        zoom: 14, center: latlng,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    var map = new google.maps.Map(document.getElementById("map"), options);
}