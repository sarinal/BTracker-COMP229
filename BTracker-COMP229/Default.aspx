<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BTracker_COMP229.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <!-- Author: Sarina Luu, Sam Buensuceso
    Student#: 300838958, 300799984
    Date: October 25, 2016
    Version: 2.0
    File Name: Default.aspx--> 
    
    <div class="container">
        <div class="row">
            <div class="col-sm-2 col-md-1"></div>
            <div class="col-sm-6 col-md-8"> 
                <h1> Welcome to Baseball Tracker! </h1>
                <div class="container" id="TeamStatsContainer" runat="server">
                    <h2>Check Team Stats</h2>
                    <div>
                        <asp:Button Text="American" ID="ALButton" CssClass="btn btn-primary btn-md" runat="server" OnClick="ALButton_Click" />
                        <asp:Button Text="National" ID="NLButton" CssClass="btn btn-warning btn-md" runat="server" OnClick="NLButton_Click" />
                    </div>
                    <div style="padding:5px">
                        <asp:DropDownList ID="TeamList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="TeamList_SelectedIndexChanged">
                            <asp:ListItem Text="--choose league--"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div style="width:30%; float:left; padding-bottom:10px; padding-left:5px">
                        <asp:Image ID="teamimage" runat="server" width="200px"/>
                    </div>
                    <div id="teaminfo" style="overflow:hidden">

                        <asp:Label ID="TeamLabel" runat="server" Text="" ForeColor="white" Font-Size="30px" Font-Names="Metrophobic" Font-Bold="true"></asp:Label>
                        <br />
                        <br />
                        <asp:Label ID="WinsLabel" runat="server" Text="" ForeColor="white" Font-Size="22px" Font-Names="Metrophobic" Font-Bold="true"></asp:Label>
                        <br />
                        <asp:Label ID="LossesLabel" runat="server" Text="" ForeColor="white" Font-Size="22px" Font-Names="Metrophobic"></asp:Label>
                        <br />
                        <br />
                        <asp:Label ID="DivisionLabel" runat="server" Text="" ForeColor="white" Font-Size="22px" Font-Names="Metrophobic" Font-Bold="true"></asp:Label>
                    </div>
                    <div class="container" id="TeamStatsPlaceHolder" runat="server"></div>
                </div>
                <div class="container" id="placeholder" runat="server"></div>
                </div>
            <div class="col-sm-2 col-md-1"></div>
            </div>
        </div>
</asp:Content>
