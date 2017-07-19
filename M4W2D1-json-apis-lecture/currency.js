$(document).ready(function () {
    $("#btnCurrency").on("click", function (event) {
		var amount = $("#amount").val();
		var code = $("#code").val();
		var convertedAmount = 0.0;
		var factor = 0.0;
		var urlString = "http://api.fixer.io/latest?base=USD"
		$.ajax({
		  url: urlString,
		  dataType: "json"
		}).done(function(url) {
			console.log(url);
			if (url.rates != undefined){
				for (var rate in url.rates){
					$("#list").append("<div>" + rate + ": " + url.rates[rate] + "</div>");
					if (rate == code){
						factor = url.rates[rate];
					}
				}
				convertedAmount  = amount * factor;
				$("#result").after("<li>Converted amount is  " + convertedAmount + " " + code + "</li>");
			}
		});
	});
});

