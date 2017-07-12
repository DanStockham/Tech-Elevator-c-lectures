/* ##################################################
Attaching Event Handlers via Javascript
################################################## */

// Blur
var fNameField = $("#fname");
fNameField.on("blur", function (event) {
    var blurredField = $(this);
    blurredField.val(blurredField.val().toUpperCase());
});

//Change
var activityField = $("#activity");
activityField.on("change", function (event) {
    $(this).val($(this).val().toUpperCase());
});

//Change
var programmingLanguageField = $("#programmingLanguage");
programmingLanguageField.on("change", function (event) {
    $("#languageMessage").html("You selected " + this.value);
});

//Focus
var usernameField = $("#username");
usernameField.on("focus", function (event) {
    $(this).css("background-color", "green");
    $(this).css("color", "white");
});

//Select
var messageField = $("#message");
messageField.on("select", function (event) {
    $("#selectedMessage").html("You selected the textbox");
});


//keyup
var birthDateField = $("#birthDate");
birthDateField.on("keyup", function (event) {
    $("#lastkey").html("The last key was " + event.key);
    $("#birthdateMessage").html($(this).val());
});

//MouseOver & MouseOut
var mouseOverBox = $("#mouseover");
mouseOverBox.on("mouseover", function (event) {
    $(this).css("background", "#860036");
});
mouseOverBox.on("mouseout", function (event) {
    $(this).css("background", "#F0b212");
});

//MouseDown & MouseUp
var mouseDownBox = $("#mousedown");
mouseDownBox.on("mousedown", function (event) {
    $(this).css("background", "#023264");
});
mouseDownBox.on("mouseup", function (event) {
    $(this).css("background", "#CC0000");
});

//Click
var clickBox = $("#click");
clickBox.on("click", function (event) {
    $(this).css("background", "blue");
});

//Double Click
var dblclickBox = $("#dblclick");
dblclickBox.on("dblclick", function (event) {
    $(this).css("background", "green");
});

//Context Menu
var rightclickBox = $("#rightclick");
rightclickBox.on("contextmenu", function (event) {
    event.preventDefault();
    $(this).css("background", "violet");
    return false;
});