<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BTracker_COMP229.Default" %>

<!DOCTYPE html>
<!--Author: Sarina Luu, Sam Buensuceso
    Student#: 300838958, 300799984
    Date: October 6, 2016
    File Name: Default.aspx   
    -->

<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <title><%= Title %></title>
    <!--CSS Section-->
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="Content/font-awesome.min.css" rel="stylesheet" />
    <link href="Content/app.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div id="banner" class="row">
            <div class="col-md-12">Title</div>
        </div>
        <div id="navigation" class="row">
            <div class="col-md-3"></div>
            <div class="col-md-6">
                <ul>
                    <li id="home">
                        <a >Home</a>
                    </li>
                    <li id="register">
                        <a>Register/Login</a>
                    </li>
                </ul>
            </div>
            <div class="col-md-3"></div>

        </div>
        <div id="mainContent">
            <div id="Game1">
            <div id="gameDescription" class="row">
                <div class="col-md-2 col-md-8 col-md-2"></div>
            </div>
            <div class="row">
                <div class="col-md-3"></div>
                <div class="col-md-2"></div>
                <div class="col-md-2"></div>
                <div class="col-md-2"></div>
                <div class="col-md-3"></div>
            </div>
            </div>
        </div>
    </form>
    <!--JavaScript Section-->
    <script src="Scripts/jquery-2.2.4.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/app.js"></script>
</body>
</html>
