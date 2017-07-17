//

$(document).ready(function () {

    $("#btnSearch").on("click", function (event) {

        var movieName = $("#movie").val();

        $.ajax({
			url: "https://api.themoviedb.org/3/search/movie?api_key=6011a901608539ba12956c49c1405fd9&language=en-US&page=1&include_adult=false&query=" + movieName,
            type: "GET",
            dataType: "json"
        }).done(function (data) {
            console.log(data);
            $("#movieData").empty();
            
            for (var i = 0; i < data.results.length; i++) {

				var thisTitle = data.results[i].title;
				var thisDate = data.results[i].release_date;
				var thisRating = data.results[i].popularity;
				var temp = "<div>Title: " + thisTitle + " | Date: " + thisDate + " | Rating: " + thisRating + "</div>";
				$("#movieData").append(temp);
				
				var thisOverview = data.results[i].overview;
				var temp2 = "<div>Overview: " + thisOverview + "</div>";
				$("#movieData").append(temp2);
				
				var temp3 = "<div><br /></div>";
				$("#movieData").append(temp3);

            }            
        }).fail(function (xhr, status, error) {
            console.log(error);
        });

    });

});

