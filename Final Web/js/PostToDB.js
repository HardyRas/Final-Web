function btnSave_Click()
{

    var FeatureVariable = {};
    FeatureVariable.Month = $("#inputMonths").val();
    FeatureVariable.Rainfall = $("#inputRainfall").val();
    FeatureVariable.Temperature= $("#inputTemperature").val();
    FeatureVariable.AL6= $("#inputAL6").val();
    FeatureVariable.AL12 = $("#inputAL12").val();
    FeatureVariable.AL18 = $("#inputAL18").val();
    FeatureVariable.AL24 = $("#inputAL24").val();
    FeatureVariable.Ward_Id= $("#inputWardId").val();

    $.ajax({

        //my api call to the controller NewFeatureEntry
        method: "POST",
        url: "http://localhost:51217/NewFeatureEntry/AddNewFeature",
        contentType: "application/json",
        data: '{ model:' + JSON.stringify(FeatureVariable) + '}',
        success: function (result) {
            alert(result);
        }
    });

}