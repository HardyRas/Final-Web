$(document).ready(function () {
    $("#btnSave").on('click', function (e) {

        e.preventDefault();

        var feature = {};
        feature.months = $("#months").val();
        feature.rainfall = $("#rainfall").val();
        feature.temperature = $("#temperature").val();
        feature.al6 = ("#al6").val();
        feature.al12 = $("#al12").val();
        feature.al18 = ("#al18").val();
        feature.al24 = ("#al24").val();
        feature.wardid = ("#wardid").val();

        var jsonData = JSON.stringify({
            feature: feature
        });

        $.ajax({

            //my api call to the controller NewFeatureEntry
            url: "http://localhost:51217/api/NewFeatureEntry/AddNewFeature",
            type: "POST",
            contentType: "application/json",
            data: jsonData,

            success: function (response) {
                if (response.status == true) {
                    alert('SuccessFully Done');
                }
                else {
                    alert('Failed to Save Data');
                }
            },

            error: function () {
                alert('Error. Please Try Again');
            }
        });

    });
});   