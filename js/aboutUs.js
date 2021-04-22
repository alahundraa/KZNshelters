function initMap() {
    const our_office = {lat: 55.79225274647401, lng: 49.12247575167198};
    const map = new google.maps.Map(document.getElementById("map"), {
        center: our_office,
        zoom: 15,
    });
    const marker = new google.maps.Marker({
        position: our_office,
        map: map,
    });
}
