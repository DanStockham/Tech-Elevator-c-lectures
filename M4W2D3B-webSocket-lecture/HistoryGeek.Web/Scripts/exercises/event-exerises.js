/// <reference path="../jquery-3.1.1.js" />

$(document).ready(function () {

    // Shopping Cart
    $("#SameShipping").on("change", function () {
        if (this.checked) {
            // Set shipping to all billing addresses
            $("#ShippingAddress1").val($("#BillingAddress1").val());
            $("#ShippingAddress2").val($("#BillingAddress2").val());
            $("#ShippingCity").val($("#BillingCity").val());
            $("#ShippingState").val($("#BillingState").val());
            $("#ShippingPostalCode").val($("#BillingPostalCode").val());
        }
        else {
            // Clear out shipping addresses
            $("#ShippingAddress1").val("");
            $("#ShippingAddress2").val("");
            $("#ShippingCity").val("");
            $("#ShippingState").val("");
            $("#ShippingPostalCode").val("");
        }
    });

    $("#checkout input[name=ShippingType]").on("change", function () {
        var selectedCost = $("input[name=ShippingType]:checked").attr("data-cost");
        $("#order-summary #shipping span").text(selectedCost);
        
        updateGrandTotal();
    });


    // Game
    $("#game").parents("body").on("keydown", function (e) {        
        if (e.key == "ArrowRight") {
            goRight();
            checkNextStep();
        }
        else if (e.key == "ArrowUp") {
            goUp();
            checkNextStep();
            e.preventDefault();
            return false;
        }
        else if (e.key == "ArrowDown") {
            goDown();
            checkNextStep();
            e.preventDefault();
            return false;
        }
        else if (e.key == "ArrowLeft") {
            goLeft();
            checkNextStep();
        }
        
    });

    $("#btnRestart").on("click", restart);
});

function updateGrandTotal() {
    var subtotal = $("#subtotal span").text();
    subtotal = parseFloat(subtotal.substr(1, subtotal.length));

    var tax = $("#tax span").text();
    tax = (tax != "$-.--") ? parseFloat(tax.substr(1, tax.length)) : 0.00;

    var shipping = $("#shipping span").text();
    shipping = (shipping != "$-.--") ? parseFloat(shipping.substr(1, shipping.length)) : 0.00;
    
    var total = (subtotal + tax + shipping);
    $("#grandtotal span").text("$" + total.toFixed(2));
}


function goRight() {
    var ship = $(".ship");
    if (!ship.is(":last-child")) {
        ship.next().addClass("ship");
        ship.removeClass("ship");
    }
}

function goLeft() {
    var ship = $(".ship");
    if (!ship.is(":first-child")) {
        ship.prev().addClass("ship");
        ship.removeClass("ship");
    }
}

function goUp() {
    var ship = $(".ship");
    var row = ship.parent();
    if (!row.is(":first-child")) {
        var columnIndex = ship.index();
        row.prev().children().eq(columnIndex).addClass("ship");
        ship.removeClass("ship");
    }    
}

function goDown() {
    var ship = $(".ship");
    var row = ship.parent();
    if (!row.is(":last-child")) {
        var columnIndex = ship.index();
        row.next().children().eq(columnIndex).addClass("ship");
        ship.removeClass("ship");
    }
}

function checkNextStep() {
    var ship = $(".ship");
    if (ship.hasClass("iceberg") || ship.hasClass("pirate")) {
        $("h2").text("Pirate Explorer - Game Over");
        $("h2").addClass("gameover");
        ship.removeClass("ship");
    }
    else if (ship.hasClass("treasure")) {
        $("h2").text("Pirate Explorer - You Win!");
        $("h2").addClass("gamewin");
        ship.removeClass("ship");
    }
}

function restart() {
    $("#gameboard td:first").addClass("ship");
    $("h2").text("Pirate Game").removeClass("gameover");
    $("h2").text("Pirate Game").removeClass("gamewin");
}