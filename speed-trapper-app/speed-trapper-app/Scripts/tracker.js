$(function () {

    $.connection.hub.url = "/signalr";
    var sensor = $.connection.trackerHub;

    /* Show valid speed */
    sensor.client.validspeed = function (car, speed) {
        var dataHtml = "<div class='intro'>"
                     + "<b>" + car + "</b><br/>"
                     + "<b><label class='validspeed'>" + speed + "</label></b></div>";

        $('#stats').append(dataHtml);
    };

    /* Show overspeed car */
    sensor.client.overspeed = function (car, speed) {
        var dataHtml = "<div class='intro'>"
                     + "<b>" + car + "</b><br/>"
                     + "<b><label class='overspeed'>" + speed + "</label></b></div>";

        $('#stats').append(dataHtml);
    };

    $.connection.hub.start().done(function () {

        /* Set overspeed limit of cars */
        $('#setSpeed').click(function () {
            var speed = $('#speed').val();

            if (speed > 9 && speed < 201) {
                sensor.server.setLimit(speed);
                alert(speed + "km/hr overspeed is set");
            }
            else {
                alert("Invalid Speed limit [10km/hr - 200km/hr]");
            }
        });

    });

});