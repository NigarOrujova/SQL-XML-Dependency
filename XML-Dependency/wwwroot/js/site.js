// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


﻿ar connection = new signalR.HubConnectionBuilder().withUrl("/FoodDependencyHubs").build();
connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});
function InvokeFoods() {

}
connection.on("ReceivedFoods", function (foods) {

});