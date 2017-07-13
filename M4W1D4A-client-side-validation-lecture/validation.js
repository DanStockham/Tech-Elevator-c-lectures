

$(document).ready(function () {

    // Validate takes an object, not a function
    // Objects in javascript use { .. } notation and are the same as key / value pairs
    $("#applicationForm").validate({

        debug: true,
        rules: {

            fName: {
                required: true,         //makes first name required
            },
            lName: {
                required: true,         //makes last name required
                minlength: 2,           //requires min length of 2 characters
                lettersonly: true       //using an additional jquery validation method
            },
            emailAddr: {
                email: true,            //require this field to only accept email                
                //required: {
                //    depends: function (element) {
                //        return $("#chkEmail").is(":checked");
                //    }
                //},
                techElevatorEmail: true, //uses custom validator for @techelevator.com
            },
            password: {
                required: true,         //requires password field
                minlength: 8,           //requires at least 8 characters
                strongpassword: true    //uses custom validator for strong password
            },
            verifyPassword: {
                equalTo: "#password"    //uses the CSS selector to match value of the field
            },
            //This one looks funky because it renders the error label before the checkbox
            //The way to make this truly good is override the error placement for checkbox which is tedious
			//See something like this http://stackoverflow.com/questions/26498899/jquery-validate-custom-error-message-location
            favoriteCompanies: {
                minlength: 2            //make sure the user selects 2 boxes if they select any at all
            }
        },
        messages: {
            fName: {
                required: "You must provide a first name"
            },
            lName: {
                required: "You must provide a last name",
                minlength: "Last name can't be less than 2 characters"
            }
        },
        errorClass: "error",
        validClass: "valid"

    });

});

//Create a custom validation rule that only permits email addresses that end with @techelevator.com
//https://jqueryvalidation.org/jQuery.validator.addMethod
$.validator.addMethod("techElevatorEmail", function (value, index) {
    return value.toLowerCase().endsWith("@techelevator.com");  // it would be safer to consider a regex here. 
}, "Please enter a techelevator.com email");

$.validator.addMethod("strongpassword", function (value, index) {
    return value.match(/[A-Z]/) && value.match(/[a-z]/) && value.match(/\d/);  //check for one capital letter, one lower case letter, one num
}, "Please enter a strong password (one capital, one lower case, and one number");

 


