// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $(function () {
        $('#InputSource').autocomplete({
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
                                    place_id: item.placeId,
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
                $('#InputSource').val(ui.item.label);
                $('#InputSourcePlaceId').val(ui.item.place_id);
                $('#InputSourceLongitude').val(ui.item.long);
                $('#InputSourceLatitude').val(ui.item.lat);
                return false;
            }
        });

        $('#InputDestination').autocomplete({
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
                                    place_id: item.placeId,
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
                $('#InputDestination').val(ui.item.label);
                $('#InputDestinationPlaceId').val(ui.item.place_id);
                $('#InputDestinationLongitude').val(ui.item.long);
                $('#InputDestinationLatitude').val(ui.item.lat);
                return false;
            }
        });
    });
});
