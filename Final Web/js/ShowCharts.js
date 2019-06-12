window.onload = function () {

    var chart = document.getElementById("line-chart").getContext("2d");
    window.myLine = new Chart(chart).Line(lineChartData1, {
        responsive: true,
        scaleLineColor: "rgba(0,0,0,.2)",
        scaleGridLineColor: "rgba(0,0,0,.05)",
        scaleFontColor: "#c5c7cc"
    });

    var chart = document.getElementById("line-chart").getContext("2d");
    window.myLine = new Chart(chart).Line(lineChartData, {
        responsive: true,
        scaleLineColor: "rgba(0,0,0,.2)",
        scaleGridLineColor: "rgba(0,0,0,.05)",
        scaleFontColor: "#c5c7cc"
    });


    var chart2 = document.getElementById("line-chart2").getContext("2d");
    window.myLine = new Chart(chart2).Line(lineChartData2, {
        responsive: true,
        scaleLineColor: "rgba(0,0,0,.2)",
        scaleGridLineColor: "rgba(0,0,0,.05)",
        scaleFontColor: "#c5c7cc"
    });


    var chart3 = document.getElementById("line-chart3").getContext("2d");
    window.myLine = new Chart(chart3).Line(lineChartData3, {
        responsive: true,
        scaleLineColor: "rgba(0,0,0,.2)",
        scaleGridLineColor: "rgba(0,0,0,.05)",
        scaleFontColor: "#c5c7cc"
    });

    var chart4 = document.getElementById("line-chart4").getContext("2d");
    window.myLine = new Chart(chart4).Line(lineChartData4, {
        responsive: true,
        scaleLineColor: "rgba(0,0,0,.2)",
        scaleGridLineColor: "rgba(0,0,0,.05)",
        scaleFontColor: "#c5c7cc"
    });

    var chart5 = document.getElementById("line-chart5").getContext("2d");
    window.myLine = new Chart(chart5).Line(lineChartData5, {
        responsive: true,
        scaleLineColor: "rgba(0,0,0,.2)",
        scaleGridLineColor: "rgba(0,0,0,.05)",
        scaleFontColor: "#c5c7cc"
    });
};