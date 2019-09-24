<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetambwegaWardAnalysisCharts.aspx.cs" Inherits="Final_Web.GetambwegaWardAnalysisCharts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <title>Getambwega Ward</title>
    <link href="css/getambwega.css" rel="stylesheet"/>
    <link href="css/font-awesome.min.css" rel="stylesheet"/>
    <link href="css/datepicker3.css" rel="stylesheet"/>
    <link href="css/styles.css" rel="stylesheet"/>

    <!--Custom Font-->
    <link href="https://fonts.googleapis.com/css?family=Montserrat:300,300i,400,400i,500,500i,600,600i,700,700i" rel="stylesheet"/>
    <!--[if lt IE 9]>
    <script src="js/html5shiv.js"></script>
    <script src="js/respond.min.js"></script>
    <![endif]-->
</head>
<body>

    <nav class="navbar navbar-custom navbar-fixed-top" role="navigation">
        <div class="container-fluid">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#sidebar-collapse">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="MalariaPrePred.aspx"><span>MalariaPrePred</span>SYS</a>
            </div>
        </div>
    </nav>
    <!-- Navigation end...kila kitu hapo kwa nav -->
    <!-- START OF SIDEBAR -->
   <div id="sidebar-collapse" class="col-sm-3 col-lg-2 sidebar">
        <div class="profile-sidebar">
            <div class="profile-userpic">
                <img src="http://placehold.it/50/30a5ff/fff" class="img-responsive" alt=""/>
            </div>
            <div class="profile-usertitle">
                <div class="profile-usertitle-name">Hardy</div>
                <div class="profile-usertitle-status"><span class="indicator label-success"></span>Online</div>
            </div>
            <div class="clear"></div>
        </div>
        <div class="divider"></div>
        <form role="search">
            <div class="form-group">
                <input type="text" class="form-control" placeholder="Search"/>
            </div>
        </form>
        <ul class="nav menu">
            <li><a href="GetambwegaWardMain.aspx"><em class="fa fa-dashboard">&nbsp;</em> Prevalence Report</a></li>
            <li ><a href="GetambwegaWardCommodities.aspx"><em class="fa fa-calendar">&nbsp;</em> Commodities Report</a></li>
            <li><a href="GetambwegaWardFeatureForcast.aspx"><em class="fa fa-bar-chart">&nbsp;</em> Feature Forecast</a></li>
            <li><a href="GetambwegaWardPrePred.aspx"><em class="fa fa-clone">&nbsp;</em> Prevalence Prediction</a></li>
            <li><a href="GetambwegaWardNewEntries.aspx"><em class="fa fa-clone">&nbsp;</em> New Entries</a></li>
            <li class="active"><a href="GetambwegaWardAnalysisCharts.aspx"><em class="fa-fa-clone">&nbsp;</em>Analysis Charts</a></li>
            <li><a href="Login.aspx"><em class="fa fa-power-off">&nbsp;</em> Logout</a></li>
        </ul>
    </div>
    <!-- END OF SIDEBAR -->

    <div class="col-sm-9 col-sm-offset-3 col-lg-10 col-lg-offset-2 main">
        <div class="row">
            <div class="col-md-12">
                <div class="col-lg-12">
            <ol class="breadcrumb">
                <li>
                    <a href="#">
                        <em class="fa fa-home"></em>
                    </a>
                </li>
                <li class="active">Analysis Charts</li>
            </ol>
                    </div>
                </div>
        </div><!--/.row-->

        <div class="row">
            <div class="col-md-12">
                <div class="col-lg-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        Prevalence vs Timeline
                        <ul class="pull-right panel-settings panel-button-tab-right">
                            <li class="dropdown">
                                <a class="pull-right dropdown-toggle" data-toggle="dropdown" href="#">
                                    <em class="fa fa-cogs"></em>
                                </a>
                                <ul class="dropdown-menu dropdown-menu-right">
                                    <li>
                                        <ul class="dropdown-settings">
                                            <li>
                                                <button onclick="loadPrevalvTGetambwega()">
                                                    <em class="fa fa-cog"></em> Getambwega Ward
                                                </button>
                                            </li>
                                            <li class="divider"></li>
                                            <li>
                                                <button onclick="loadKakraoPreVt()">
                                                    <em class="fa fa-cog"></em> Another Ward in Migori
                                                </button>
                                            </li>
                                            <li class="divider"></li>
                                            <li>
                                                <button onclick="loadGurarWarPreVt()">
                                                    <em class="fa fa-cog"></em> Gurar Ward
                                                </button>
                                            </li>
                                        </ul>
                                    </li>
                                </ul>
                            </li>
                        </ul>
                        <span class="pull-right clickable panel-toggle panel-button-tab-left"><em class="fa fa-toggle-up"></em></span>
                    </div>
                    <div class="panel-body">
                        <div class="canvas-wrapper">
                            <canvas class="main-chart" id="line-chart" height="200" width="600"></canvas>
                        </div>
                    </div>
                </div>
            </div>
                </div>
        </div><!--/.row-->

        <%-- RAINFALL TEMP --%>
        <div class="row">
            <div class="col-md-12">
                <div class="col-lg-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        Prevalence vs Rainfall and Temperature
                        <ul class="pull-right panel-settings panel-button-tab-right">
                            <li class="dropdown">
                                <a class="pull-right dropdown-toggle" data-toggle="dropdown" href="#">
                                    <em class="fa fa-cogs"></em>
                                </a>
                                <ul class="dropdown-menu dropdown-menu-right">
                                    <li>
                                        <ul class="dropdown-settings">
                                            <li class="divider"></li>
                                            <li>
                                                <button onclick="PrevRainTempGurar()">
                                                    <em class="fa fa-cog"></em> Another Ward
                                                </button>
                                            </li>
                                        </ul>
                                    </li>
                                </ul>
                            </li>
                        </ul>
                        <span class="pull-right clickable panel-toggle panel-button-tab-left"><em class="fa fa-toggle-up"></em></span>
                    </div>
                    <div class="panel-body">
                        <div class="canvas-wrapper">
                            <canvas class="main-chart" id="line-chart1" height="200" width="600"></canvas>
                        </div>
                    </div>
                </div>
                </div>
            </div>
        </div><!--/.row-->

        <%-- PREV VS AL6 --%>
        <div class="row">
            <div class="col-md-12">
                <div class =" col-lg-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        Prevalence vs AL6s
                        <ul class="pull-right panel-settings panel-button-tab-right">
                            <li class="dropdown">
                                <a class="pull-right dropdown-toggle" data-toggle="dropdown" href="#">
                                    <em class="fa fa-cogs"></em>
                                </a>
                                <ul class="dropdown-menu dropdown-menu-right">
                                    <li>
                                        <ul class="dropdown-settings">
                                            <li>
                                                <button onclick="PrevALsixGeta()">
                                                    <em class="fa fa-cog"></em> Getambwega Ward
                                                </button>
                                            </li>
                                            <li class="divider"></li>
                                            <li>
                                                <button onclick="PrevALsixKakra()">
                                                    <em class="fa fa-cog"></em> Another Ward in Migori
                                                </button>
                                            </li>
                                            <li class="divider"></li>
                                            <li>
                                                <button onclick="PrevALsixGurar()">
                                                    <em class="fa fa-cog"></em> Gurar Ward
                                                </button>
                                            </li>
                                        </ul>
                                    </li>
                                </ul>
                            </li>
                        </ul>
                        <span class="pull-right clickable panel-toggle panel-button-tab-left"><em class="fa fa-toggle-up"></em></span>
                    </div>
                    <div class="panel-body">
                        <div class="canvas-wrapper">
                            <canvas class="main-chart" id="line-chart2" height="200" width="600"></canvas>
                        </div>
                    </div>
                </div>
                </div>
            </div>
        </div><!--/.row-->
        <div class="row">
            <div class="col-md-12">
                <div class ="col-lg-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        Prevalence vs AL12s
                        <ul class="pull-right panel-settings panel-button-tab-right">
                            <li class="dropdown">
                                <a class="pull-right dropdown-toggle" data-toggle="dropdown" href="#">
                                    <em class="fa fa-cogs"></em>
                                </a>
                                <ul class="dropdown-menu dropdown-menu-right">
                                    <li>
                                        <ul class="dropdown-settings">
                                            <li>
                                                <button onclick="PrevALtwelGeta()">
                                                    <em class="fa fa-cog"></em> Getambwega Ward
                                                </button>
                                            </li>
                                            <li class="divider"></li>
                                            <li>
                                                <button onclick="PrevALtwelKakra()">
                                                    <em class="fa fa-cog"></em> Another Ward in Migori
                                                </button>
                                            </li>
                                            <li class="divider"></li>
                                            <li>
                                                <button onclick="PrevALtwelGurar()">
                                                    <em class="fa fa-cog"></em> Another Ward
                                                </button>
                                            </li>
                                        </ul>
                                    </li>
                                </ul>
                            </li>
                        </ul>
                        <span class="pull-right clickable panel-toggle panel-button-tab-left"><em class="fa fa-toggle-up"></em></span>
                    </div>
                    <div class="panel-body">
                        <div class="canvas-wrapper">
                            <canvas class="main-chart" id="line-chart3" height="200" width="600"></canvas>
                        </div>
                    </div>
                </div>
                </div>
            </div>
        </div><!--/.row-->
        <div class="row">
            <div class="col-md-12">
                <div class="col-lg-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        Prevalence vs AL18s
                        <ul class="pull-right panel-settings panel-button-tab-right">
                            <li class="dropdown">
                                <a class="pull-right dropdown-toggle" data-toggle="dropdown" href="#">
                                    <em class="fa fa-cogs"></em>
                                </a>
                                <ul class="dropdown-menu dropdown-menu-right">
                                    <li>
                                        <ul class="dropdown-settings">
                                            <li>
                                                <button onclick="PrevALeighGeta()">
                                                    <em class="fa fa-cog"></em> Getambwega Ward
                                                </button>
                                            </li>
                                            <li class="divider"></li>
                                            <li>
                                                <button onclick="PrevALeighKakra()">
                                                    <em class="fa fa-cog"></em> Another Ward in Migori
                                                </button>
                                            </li>
                                            <li class="divider"></li>
                                            <li>
                                                <button onclick="PrevALeighGurar()">
                                                    <em class="fa fa-cog"></em> Another Ward
                                                </button>
                                            </li>
                                        </ul>
                                    </li>
                                </ul>
                            </li>
                        </ul>
                        <span class="pull-right clickable panel-toggle panel-button-tab-left"><em class="fa fa-toggle-up"></em></span>
                    </div>
                    <div class="panel-body">
                        <div class="canvas-wrapper">
                            <canvas class="main-chart" id="line-chart4" height="200" width="600"></canvas>
                        </div>
                    </div>
               </div> 
                </div>
            </div>
        </div><!--/.row-->
        <div class="row">
            <div class="col-md-12">
                <div class="col-lg-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        Prevalence vs AL24s
                        <ul class="pull-right panel-settings panel-button-tab-right">
                            <li class="dropdown">
                                <a class="pull-right dropdown-toggle" data-toggle="dropdown" href="#">
                                    <em class="fa fa-cogs"></em>
                                </a>
                                <ul class="dropdown-menu dropdown-menu-right">
                                    <li>
                                        <ul class="dropdown-settings">
                                            <li>
                                                <button onclick="PrevALtwenGeta()">
                                                    <em class="fa fa-cog"></em> Getambwega Ward
                                                </button>
                                            </li>
                                            <li class="divider"></li>
                                            <li>
                                                <button onclick="PrevALtwenKakra()">
                                                    <em class="fa fa-cog"></em> Another Ward in Migori
                                                </button>
                                            </li>
                                            <li class="divider"></li>
                                            <li>
                                                <button onclick="PrevALtwenGurar()">
                                                    <em class="fa fa-cog"></em> Another Ward
                                                </button>
                                            </li>
                                        </ul>
                                    </li>
                                </ul>
                            </li>
                        </ul>
                        <span class="pull-right clickable panel-toggle panel-button-tab-left"><em class="fa fa-toggle-up"></em></span>
                    </div>
                    <div class="panel-body">
                        <div class="canvas-wrapper">
                            <canvas class="main-chart" id="line-chart5" height="200" width="600"></canvas>
                        </div>
                    </div>
                </div>
                </div>
            </div>
        </div><!--/.row-->


    <script src="js/jquery-1.11.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/chart.min.js"></script>
    <script src="js/chart-data.js"></script>
    <script src="js/easypiechart.js"></script>
    <script src="js/easypiechart-data.js"></script>
    <script src="js/bootstrap-datepicker.js"></script>
    <script src="js/custom.js"></script>

    <script>
        window.onload = function () {
            var chart = document.getElementById("line-chart").getContext("2d");
            window.myLine = new Chart(chart).Line(lineChartData, {
                responsive: true,
                scaleLineColor: "rgba(0,0,0,.2)",
                scaleGridLineColor: "rgba(0,0,0,.05)",
                scaleFontColor: "#c5c7cc"
            });
            var chart1 = document.getElementById("line-chart1").getContext("2d");
            window.myLine = new Chart(chart1).Line(lineChartData1, {
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
    </script>

            <script>

                //prevalence vs time functions
                function loadPrevalvTGetambwega() {
                    var chart = document.getElementById("line-chart").getContext("2d");
                    window.myLine = new Chart(chart).Line(lineChartDataGetaPVT,
                    {
                        responsive: true,
                        scaleLineColor: "rgba(0,0,0,.2)",
                        scaleGridLineColor: "rgba(0,0,0,.05)",
                        scaleFontColor: "#c5c7cc"
                    });
                }

                function loadKakraoPreVt(){
                    var chart1 = document.getElementById("line-chart").getContext("2d");
                    window.myLine = new Chart(chart1).Line(lineChartDataKakraPVT, {
                        responsive: true,
                        scaleLineColor: "rgba(0,0,0,.2)",
                        scaleGridLineColor: "rgba(0,0,0,.05)",
                        scaleFontColor: "#c5c7cc"
                    });
                }

                function loadGurarWarPreVt(){
                    var chart12 = document.getElementById("line-chart").getContext("2d");
                    window.myLine = new Chart(chart12).Line(lineChartDataGurarPVT, {
                        responsive: true,
                        scaleLineColor: "rgba(0,0,0,.2)",
                        scaleGridLineColor: "rgba(0,0,0,.05)",
                        scaleFontColor: "#c5c7cc"
                    });
                }


                //prevalence vs rain and temp functions
                function PrevRainTempGurar() {
                    var chart5 = document.getElementById("line-chart1").getContext("2d");
                    window.myLine = new Chart(chart5).Line(lineChartDataPvRTGurar, {
                        responsive: true,
                        scaleLineColor: "rgba(0,0,0,.2)",
                        scaleGridLineColor: "rgba(0,0,0,.05)",
                        scaleFontColor: "#c5c7cc"
                    });
                }

                //load gurar prevalence vs al6 (ikerege)
                function PrevALsixGurar() {
                    var chart2 = document.getElementById("line-chart2").getContext("2d");
                    window.myLine = new Chart(chart2).Line(lineChartDataGurarAL6, {
                        responsive: true,
                        scaleLineColor: "rgba(0,0,0,.2)",
                        scaleGridLineColor: "rgba(0,0,0,.05)",
                        scaleFontColor: "#c5c7cc"
                    });
                }
    </script>

        </div>
</body>
</html>
