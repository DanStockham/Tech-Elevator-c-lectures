/// <reference path="../jquery-3.1.1.js" />
/// <reference path="../jquery.signalR-2.2.1.js" />

$(document).ready(function () {
    
    var connection = $.connection("/chatsocket");

    // A message is received from the broadcast server
    connection.received(function (data) {
        if (data.type == "members") {
            refreshMemberList(data.values);
        }
        else if (data.type == "newmessage") {
            addToChatWindow(data.values);
        }
    });

    // Open a Connection    
    connection.start().done(function () {
        console.log("Connected");
    });    

});

function refreshMemberList(members) {
    $("#members ul").empty();
    for (var i = 0; i < members.length; i++) {
        var listItem = $("<li>").text(members[i]);
        $("#members ul").append(listItem);
    }
}

function addToChatWindow(message) {
    var time = new Date(message.SentDate).toLocaleTimeString([], { hour: '2-digit', minute: '2-digit' });
    var p = $("<p>").addClass("message");
    var userspan = $("<span>").addClass("username").text(message.Username)
    var timespan = $("<span>").addClass("time").text(time);
    var br = $("<br />");
    var messagespan = $("<span>").text(message.Message);

    p.append(userspan).append(timespan).append(br).append(messagespan);
    $("#history").append(p);
}