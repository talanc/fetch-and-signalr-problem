// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(function () {
    var resultsf = document.getElementById("fetch-results");
    var resultss = document.getElementById("signalr-results");

    if (resultsf && resultss) {
        // api controller
        fetch("api/values")
            .then(function (response) {
                return response.json();

            })
            .then(function (json) {
                resultsf.textContent = json;
            });

        // signalr

        var connection = new signalR.HubConnectionBuilder()
            .withUrl("/valuesHub")
            .build();

        connection.on("values", function (values) {
            resultss.textContent = JSON.stringify(values);
        });

        connection.start();
    }
});
