<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ikeregeWardNewEntries.aspx.cs" Inherits="Final_Web.ikeregeWardNewEntries" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="HeadIkerege" runat="server">
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <title>Ikerege Ward</title>
    <link href="css/bootstrap.min.css" rel="stylesheet"/>
    <link href="css/font-awesome.min.css" rel="stylesheet"/>
    <link href="css/datepicker3.css" rel="stylesheet"/>
    <link href="css/styles.css" rel="stylesheet"/>
    <!--Custom Font-->
    <link href="https://fonts.googleapis.com/css?family=Montserrat:300,300i,400,400i,500,500i,600,600i,700,700i" rel="stylesheet"/>

    <%-- This script is my everything --%>
<%--Call the ASP.Net Web API Controller method from the .aspx page using JSON.
 
Now we need to call the Web API controller method from the .aspx page.
To do this we need to create a JSON method using jQuery as in the following,--%>

    <script src="js/jquery-1.7.1.js" type="text/javascript"></script>   
       
    <script type="text/javascript">

        function Addfeature() {
            var feature = {};
            feature.months = $("#inputMonths").val();
            feature.rainfall = $("#inputRain").val();
            feature.temperature = $("#inputTemp").val();
            feature.al6 = $("#inputAL6").val();
            feature.al12 = $("#inputAL12").val();
            feature.al18 = $("#inputAL18").val();
            feature.al24 = $("#inputAL24").val();
            feature.WardId = $("#inputWardid").val();
   
   
            $.ajax({   

                url: "http://localhost:51217/api/NewFeatureEntry/", 
                type: "POST", 
                contentType: "application/xml;charset=utf-8",
                data: JSON.stringify(feature),   
                dataType: "json",   
                success: function (response) {   
                    alert(response);           
                },   

                error: function (xhr, status, error) {
                    var errorMessage = xhr.status + ':' + xhr.statusText
                    alert('Error - ' + ' ' + errorMessage);
   
                }   
            });   
        }        
   
        $(document).ready(function ()   
         {   
            $("#btnSave").click(function (e) {               

                Addfeature();   
                e.preventDefault();  
            });    
        });   
    </script>
    
</head>
<body style="height: 525px">

        <%-- Top navigation bar. --%>
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
            <li><a href="ikeregeWardMain.aspx"><em class="fa fa-dashboard">&nbsp;</em> Prevalence Report</a></li>
            <li ><a href="ikeregeWardCommodities.aspx"><em class="fa fa-calendar">&nbsp;</em> Commodities Report</a></li>
            <li ><a href="ikeregeWardFeatureForcast.aspx"><em class="fa fa-bar-chart">&nbsp;</em> Feature Forecast</a></li>
            <li><a href="ikeregeWardPrePred.aspx"><em class="fa fa-clone">&nbsp;</em> Prevalence Prediction</a></li>
            <li class="active"><a href="ikeregeWardNewEntries.aspx"><em class="fa fa-clone">&nbsp;</em> New Entries</a></li>
            <li ><a href="ikeregeWardAnalysisCharts.aspx"><em class="fa-fa-chart">&nbsp;</em>Analysis Charts</a></li>
            <li><a href="Login.aspx"><em class="fa fa-power-off">&nbsp;</em> Logout</a></li>
        </ul>
    </div><!--/.sidebar-->

    <div class="col-sm-9 col-sm-offset-3 col-lg-10 col-lg-offset-2 main">
        <div class="row">
            <div class="col-md-12">
                <div class="col-lg-12">
                    <div class="card bg-secondary shadow">
                        <div class="card-header bg-white border-0">
                            <div class="row align-items-center">
                                <div class="col-8">
                                    <div class="card-body">

                                              <form id="dataEntry" runat ="server">
                                                <h3>DATA ENTRY</h3>
                                                   <hr class="my-4" />
                                                  <h6>New Features</h6>
                                                                                                     <hr class="my-4" />
                                                <div class="pl-lg-4">

                                                 <div class="row">
                                                    <div class="col-lg-6">
                                                      <div class="form-group">
                                                        <label>Month</label>
                                                        <input type="date" id="inputMonths"class="form-control form-control-alternative"/>
                                                      </div>
                                                    </div>
                                                <div class="col-lg-6">
                                                        <div class="form-group">
                                                           <label>Ward ID</label>
                                                            <input type="text" id="inputWardid" class="form-control form-control-alternative"/>
                                                        </div>
                                                    </div>
                                                 </div>
                                                  <div class="row">
                                                    <div class="col-lg-6">
                                                      <div class="form-group">
                                                        <label>Rainfall</label>
                                                        <input type="number" id="inputRain" class="form-control form-control-alternative"/>
                                                      </div>
                                                    </div>
                                                    <div class="col-lg-6">
                                                      <div class="form-group">
                                                        <label>Temperature</label>
                                                        <input type="number" id="inputTemp" class="form-control form-control-alternative"/>
                                                      </div>
                                                    </div>
                                                  </div>
                                                  <div class="row">
                                                    <div class="col-lg-6">
                                                      <div class="form-group">
                                                        <label">AL6s</label>
                                                        <input type="number" id="inputAL6" class="form-control form-control-alternative"/>
                                                      </div>
                                                    </div>
                                                    <div class="col-lg-6">
                                                      <div class="form-group">
                                                        <label>AL12s</label>
                                                        <input type="number" id="inputAL12" class="form-control form-control-alternative"/>
                                                      </div>
                                                    </div>
                                                  </div>
                                                     <div class="row">
                                                    <div class="col-lg-6">
                                                      <div class="form-group">
                                                        <label>AL18s</label>
                                                        <input type="number" id="inputAL18"class="form-control form-control-alternative"/>
                                                      </div>
                                                    </div>
                                                    <div class="col-lg-6">
                                                      <div class="form-group">
                                                        <label>AL24s</label>
                                                        <input type="number" id="inputAL24" class="form-control form-control-alternative"/>
                                                      </div>
                                                    </div>
                                                  </div>

                                                    <%-- Button sasa --%>
                                                    <div class="row">
                                                        <div class="col-lg-1">
                                                                    <div class="col-4 text-right">
                                                                        <asp:Button Text ="Add Entry" runat="server" id ="btnSave"/>
                                                                    </div>    
                                                            </div>
                                                    </div>
                                                    <%-- End of button --%>

                                                </div>
                                                <hr class="my-4" />
                                              </form>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

</body>
</html>
