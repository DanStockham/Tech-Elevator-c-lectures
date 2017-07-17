$(document).ready(function () {
    $("#randomButton").on("click", function (event) {
        $.ajax({
            url: "http://api.icndb.com/jokes/random?exclude=explicit",
            type: "GET",
            dataType: "json"
        }).done(function (data) {
            $("#message").html(data.value.joke);
        }).fail(function (xhr, status, error) {
            console.log(error);
        });
    });
});


