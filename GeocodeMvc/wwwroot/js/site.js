// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $(function () {
        $('#TextBoxFrom').autocomplete({
            source: function (request, response) {
                $.ajax({
                    url: "http://localhost:5000/api/Place/SearchPlace",
                    data: { SearchText: request.term },
                    dataType: "json",
                    type: "GET",
                    success: function (data) {
                        if (data.length == 0) {
                            $('#FromPlaceId').val("");
                            $('#TransferMesssage').show();
                            return false;
                        }
                        else {
                            response($.map(data, function (item) {
                                return {
                                    label: item.name,
                                    long: item.longitude,
                                    lat: item.longitude
                                }
                            }));
                        }
                    },
                    error: function (x, y, z) {
                        alert('error');
                    }  
                });
            },
            messages: {
                noResults: "", results: ""
            },
            select: function (event, ui) {
                console.log(ui);
                $('#TextBoxFrom').val(ui.item.label);
                $('#TextBoxFromLong').val(ui.item.long);
                $('#TextBoxFromLat').val(ui.item.lat);
                return false;
            }
        });

        $('#TextBoxTo').autocomplete({
            source: function (request, response) {
                $.ajax({
                    url: "http://localhost:5000/api/Place/SearchPlace",
                    data: { SearchText: request.term },
                    dataType: "json",
                    type: "GET",
                    success: function (data) {
                        if (data.length == 0) {
                            $('#FromPlaceId').val("");
                            $('#TransferMesssage').show();
                            return false;
                        }
                        else {
                            response($.map(data, function (item) {
                                return {
                                    label: item.name,
                                    long: item.longitude,
                                    lat: item.longitude
                                }
                            }));
                        }
                    },
                    error: function (x, y, z) {
                        alert('error');
                    }
                });
            },
            messages: {
                noResults: "", results: ""
            },
            select: function (event, ui) {
                console.log(ui);
                $('#TextBoxTo').val(ui.item.label);
                $('#TextBoxToLong').val(ui.item.long);
                $('#TextBoxToLat').val(ui.item.lat);
                return false;
            }
        });
    });
});
