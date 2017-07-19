/// <reference path="../jquery-3.1.1.js" />
$(document).ready(function () {

    // AJAX request - when billing zip code changes
    // send an asynchronous request to get the tax rate
    $("#BillingPostalCode").on("change", function (e) {
        var zip = $("#BillingPostalCode").val();
        var subtotal = $("#subtotal span").text();
        subtotal = subtotal.substr(1, subtotal.length);

        $.ajax({
            url: "/api/GetTax",
            type: "GET",
            data: {
                billingZipCode: zip,
                subtotal: subtotal
            },
            dataType: "json"
        }).done(function (data) {
            var tax = parseFloat(data).toFixed("2");
            $("#tax span").text("$" + tax);
            updateGrandTotal();
        });
    });

    // AJAX request - when form is submitted, asynchronously
    // send the message to the chat server and clear the text field
    $("#chatroom #form0").on("submit", function (e) {

        var message = $("#message").val();

        $.ajax({
            url: "chat/index",
            type: "POST",
            data: {
                message: message
            },
            dataType: "json"
        });

        $("#message").val('');
        e.preventDefault();
        return false;

    });
    

});