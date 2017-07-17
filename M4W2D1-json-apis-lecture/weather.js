
$(document).ready(function () {

    $("#btnWeather").on("click", function (event) {
		var city = $("#city").val();
		var state = $("#state").val();
		var key = "ef5a156e62f050d2";
		var urlString = "http://api.wunderground.com/api/" + key + "/conditions/q/" + state + "/" + city + ".json"
		$.ajax({
		  url: urlString,
		  dataType: "json"
		}).done(function(url) {
			console.log(url);
			if (url.current_observation != undefined)
			{
				var temp_f = url.current_observation.temp_f;
				$("#conditions").html("Current temperature in " + city + " is: " + temp_f + "ºF");
			}
		});
	});
});
