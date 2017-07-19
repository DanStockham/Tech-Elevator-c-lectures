/// <reference path="../jquery-3.1.1.js" />
/// <reference path="../jquery.validate.js" />

$(document).ready(function () {

    // Email address - required
    // Email address - .gov only (BONUS)
    // Password - required, length 8 or more
    // ConfirmPassword
    $("#register form").validate({
        errorClass: 'field-validation-error',
        rules: {
            EmailAddress: {
                required: true,
                email: true,
                govEmail: true,
            },

            Password: {
                required: true,
                minlength: 8,

            },

            ConfirmPassword: {
                required: true,
                equalTo: "#Password"
            }
        },

        messages: {
            EmailAddress: {
                required: "*",
                email: "Invalid email address",
            },
            Password: {
                required: "*",
                minlength: "Password must be {0} or more characters"
            },
            ConfirmPassword: {
                required: "*",
                equalTo: "Confirm Password does not match Password"
            }
        }
    });

    // Email address - required
    // Password - required
    $("#login form").validate({

        errorClass: "field-validation-error",
        rules: {
            EmailAddress: {
                required: true,
            },
            Password: {
                required: true
            }
        },
        messages: {
            EmailAddress: {
                required: "*",
            },
            Password: {
                required: "*"
            }
        }

    });

    var checkoutSubmitted = false;
    $("#checkout").validate({
        errorContainer: "#errorSummary",
        errorLabelContainer: "#errorSummary ul",
        wrapper: "li",        
        rules: {
            BillingAddress1: {
                required: true
            },
            BillingCity: {
                required: true
            },
            BillingState: {
                required: true,
                stateUS: true,
            },
            BillingPostalCode: {
                required: true,
            },
            ShippingAddress1: {
                required: true
            },
            ShippingCity: {
                required: true,
            },
            ShippingState: {
                required: true,
                stateUS: true,
            },
            ShippingPostalCode: {
                required: true,
            },
            NameOnCard: {
                required: true
            },
            CreditCardNumber: {
                required: true,
                creditcard: true,
            },
            ExpirationDate: {
                required: true
            }
        },

        messages: {
            BillingAddress1: {
                required: "Billing Address is required",
            },
            BillingCity: {
                required: "Billing City is required"
            },
            BillingState: {
                required: "Billing State is required",
                stateUS: "Invalid Billing State",
            },
            BillingPostalCode: {
                required: "Billing Postal Code is required",
            },
            ShippingAddress1: {
                required: "Shipping Address is required",
            },
            ShippingCity: {
                required: "Shipping City is required",
            },
            ShippingState: {
                required: "Shipping State is required",
                stateUS: "Invalid Shipping State",
            },
            ShippingPostalCode: {
                required: "Shipping Postal Code is required",
            },
            NameOnCard: {
                required: "Credit Card Name required"
            },
            CreditCardNumber: {
                required: "Credit Card No. required",
                creditcard: "Invalid Credit Card No.",
            },
            ExpirationDate: {
                required: "Credit Card Exp Date required"
            }
        },
        
    });
});


$.validator.addMethod("govEmail", function (value, index) {
    return value.toLowerCase().endsWith(".gov");  // it would be safer to consider a regex here. 
}, "Please enter a email ending in .gov");