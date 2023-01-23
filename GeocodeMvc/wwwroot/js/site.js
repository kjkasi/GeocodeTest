// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $(function () {
        $('#TextBoxTransfer').autocomplete({
            source: function (request, response) {
                $.ajax({
                    url: "http://localhost:5000/api/Place/SearchPlace",
                    data: { SearchText: request.term },
                    dataType: "json",
                    type: "GET",
                    success: function (data) {
                        if (data.length == 0) {
                            $('#EventSourceId').val("");
                            $('#TransferMesssage').show();
                            return false;
                        }
                        else {
                            response($.map(data, function (item) {
                                return {
                                    label: item.name,
                                    value: item.placeId
                                }
                            }));
                        }
                    },
                    error: function (x, y, z) {
                        alert('error');
                    }  
                });
            }
        });
    });
});
