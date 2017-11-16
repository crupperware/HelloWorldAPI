
//Function for checking if the API is running.
//Will set all elemets with the id="APIStatusLabel" to corrasponding status.
function checkAPIRunning() {
    $.ajax({
        url: "../HelloWorldAPI/api/Hello/GetHello/",
        dataType: 'json',
        success: function (data) {
            if (data != null && data.greeting === "Hello World") {
                $("#APIStatusLabel").text("Running").css("color", "green");
            }
            else {
                $("#APIStatusLabel").text("Not Running").css("color", "red");
            }
        },
        error: function (data) {
            $("#APIStatusLabel").text("Not Running").css("color", "red");

        }
    });
}


