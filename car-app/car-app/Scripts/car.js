$(function () {

    /* Get car list array */
    var getCars = function () {
        var list = $('#carList').val();
        return JSON.parse(list);
    }

    /* Get random number for provided range */
    var getRandomNumber = function (min, max) {
        return Math.floor(Math.random() * (max - min)) + min;
    }

    var _carList = getCars();
    var carCount = _carList.length;

    var newCar = _carList[getRandomNumber(0, carCount + 1)];
    $('#car').text(newCar);

    /* Specify/refer your speed trap app local address */
    $.connection.hub.url = "http://localhost:39728/signalr";
    var car = $.connection.trackerHub;

    var busted = false;

    /* If overspeed set busted status to false to stop timer */
    car.client.bustmessage = function (msg) {
        $('#bustmsg').text(msg);
        busted = true;
    };


    $.connection.hub.start().done(function () {

        var intervalID = setInterval(function () { carRunning() }, 3000);

        var carRunning = function () {
            if (busted) {
                clearInterval(intervalID);
            }
            else {
                var carSpeed = getRandomNumber(10, 200);
                $('#speed').text(carSpeed);
                car.server.send(newCar, carSpeed);
            }
        }
    });

});