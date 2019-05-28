﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ikeregeWardFeatureForcast.aspx.cs" Inherits="Final_Web.ikeregeWardFeatureForcast" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <title>Ikerege Ward</title>
    <link href="css/bootstrap.min.css" rel="stylesheet"/>
    <link href="css/font-awesome.min.css" rel="stylesheet"/>
    <link href="css/datepicker3.css" rel="stylesheet"/>
    <link href="css/styles.css" rel="stylesheet"/>

    <!--Custom Font-->
    <link href="https://fonts.googleapis.com/css?family=Montserrat:300,300i,400,400i,500,500i,600,600i,700,700i" rel="stylesheet"/>
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
            <div class="form-group">
                <input type="text" class="form-control" placeholder="Search"/>
            </div>
        <ul class="nav menu">
            <li><a href="ikeregeWardMain.aspx"><em class="fa fa-dashboard">&nbsp;</em> Prevalence Report</a></li>
            <li ><a href="ikeregeWardCommodities.aspx"><em class="fa fa-calendar">&nbsp;</em> Commodities Report</a></li>
            <li class="active"><a href="ikeregeWardFeatureForcast.aspx"><em class="fa fa-bar-chart">&nbsp;</em> Feature Forecast</a></li>
            <li><a href="ikeregeWardPrePred.aspx"><em class="fa fa-clone">&nbsp;</em> Prevalence Prediction</a></li>
            <li><a href="ikeregeWardNewEntries.aspx"><em class="fa fa-clone">&nbsp;</em> New Entries</a></li>
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

                                                    <form id="buttons" runat="server">
                                                        <hr class="my-4" />
                                                                            <div class="row">
                                                                                <div class="col-lg-1">
                                                                                            <div class="col-4 text-right">
                                                                                                <asp:Button Text ="Add Entry" runat="server"  id="Button" OnClientClick='redirect()'/>
                                                                                            </div>    
                                                                                    </div>
                                                                                </div>
                                                        <hr class="my-4" />
                                                                            <div class="row">
                                                                                    <div class="col-lg-1">
                                                                                            <div class="col-4 text-right">
                                                                                                <asp:Button Text ="Refresh DB" runat="server" id ="Button1"/>
                                                                                            </div>
                                                                                    </div>
                                                                                </div>
                                                        <hr class="my-4" />
                                                                            <div class="row">
                                                                                    <div class="col-lg-1">
                                                                                            <div class="col-4 text-right">
                                                                                                <asp:Button Text ="Get Service" runat="server" id ="Button2"/>
                                                                                            </div>    
                                                                                    </div>
                                                                            </div>
                                                        </form>
                                            </div>
                                        </div>
                                    </div>        
                                 </div>
                            </div>
                        </div>
                    </div>
                </div>
                               <script type="text/javascript">
                                   function redirect() {
                                       location.href = 'ikeregeWardNewEntries.aspx';
                                   }
                        </script>
            </div>
       

</body>
</html>
