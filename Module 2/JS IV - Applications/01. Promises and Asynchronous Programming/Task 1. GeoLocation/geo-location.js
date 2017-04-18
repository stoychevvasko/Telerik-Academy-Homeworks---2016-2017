(function(){
    let locationElement = document.getElementById('geo-location-img')

    function getLocation(){
        return new Promise((resolve, reject) =>{
            navigator.geolocation.getCurrentPosition(
                (position) => resolve(position),
                (error) => reject(error)
            )
        })
    }

    function parseCoordinates(geolocation){
        if(geolocation.coords){
            return {
                latitude: geolocation.coords.latitude,
                longitude: geolocation.coords.longitude
            }
        }else {
            throw {
                message: "No coordinates element found",
                name: "UserException"
            };
        }
    }

    function drawMap(coordinates){
        let img = document.createElement('img'),
            imgSrc = "http://maps.googleapis.com/maps/api/staticmap?center=" +
                coordinates.latitude + "," +
                coordinates.longitude +
                "&zoom=13&size=500x500&sensor=false";

        img.setAttribute('src', imgSrc);
        locationElement.appendChild(img);
    }

    getLocation()
        .then(parseCoordinates)
        .then(drawMap);
}());
