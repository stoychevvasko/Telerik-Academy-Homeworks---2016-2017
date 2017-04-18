(function(){
    let messageElement = document.getElementById('message'),
        site = 'http://telerikacademy.com/';

    
    function redirect(){
        return new Promise((resolve, reject) => {
            resolve('In 2 seconds you will be redirected to '),
            (error) => reject(error)
        })
    }

    function showRedirectionNotice(message){
        messageElement.innerText = message + site;

        return site;
    }

    function redirectWithDelay(site){
        setInterval(function () {
            window.location.href = site;
        }, 2000);
    }

    redirect()
        .then(showRedirectionNotice)
        .then(redirectWithDelay);
}());
