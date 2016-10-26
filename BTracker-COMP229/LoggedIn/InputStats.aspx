<%@ Page Title="Input Stats" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InputStats.aspx.cs" Inherits="BTracker_COMP229.InputStats" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="inputstatsPage" class="container">
        <div class="row">
            <div class="col-md-2 col-sm-2"></div>
            <div class="col-md-8 col-sm-8">
                <h1>Stat Input</h1>
            </div>
            <div class="col-md-2 col-sm-2"></div>
            <br />

        </div>

        <div class="row">
            <div class="col-sm-1 col-md-1"></div>
            <div id="left" class="col-sm-5 col-md-4">
                <h3>Home Team</h3>
                <asp:Button Text="American" ID="HomeALButton" CssClass="btn btn-primary btn-md" runat="server" OnClick="HomeALList_Click" />
                <asp:Button Text="National" ID="HomeNLButton" CssClass="btn btn-warning btn-md" runat="server" OnClick="HomeNLList_Click" />
                <br />
                <asp:DropDownList ID="TeamHomeList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="TeamHomeList_SelectedIndexChanged">
                </asp:DropDownList>
                <br />
                <asp:Image ID="HomeImage" runat="server" CssClass="img" ImageUrl="~/Assets/images/baseball_logo_sm.png" />

            </div>
            <div id="middle" class="col-sm-3 col-md-2">
                <label class="control-label" for="GameDateTextbox">Date </label>
                <asp:TextBox runat="server" ID="GameDateTextbox"
                    placeholder="Enrollment Date" required="true" TextMode="Date"></asp:TextBox>
                <br />
                <label class="control-label" for="GameNumList">Game No. </label>
                <asp:DropDownList ID="GameNumList" runat="server">
                    <asp:ListItem Text="1"></asp:ListItem>
                    <asp:ListItem Text="2"></asp:ListItem>
                    <asp:ListItem Text="3"></asp:ListItem>
                    <asp:ListItem Text="4"></asp:ListItem>
                </asp:DropDownList>
                <br />
                <label class="control-label" for="WeekTextbox">Week </label>
                <asp:TextBox ID="WeekTextbox" runat="server"></asp:TextBox>
                <br />
                <label class="control-label" for="SpectatorsTextbox">No. of Spectators </label>
                <asp:TextBox ID="SpectatorsTextbox" runat="server"></asp:TextBox>
            </div>

            <div id="right" class="col-sm-5 col-md-4">
                <h3>Away Team</h3>
                <asp:Button Text="American" ID="AwayALButton" CssClass="btn btn-primary btn-md" runat="server" OnClick="AwayALList_Click" />
                <asp:Button Text="National" ID="AwayNLButton" CssClass="btn btn-warning btn-md" runat="server" OnClick="AwayNLList_Click" />
                <br />
                <asp:DropDownList ID="TeamAwayList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="TeamAwayList_SelectedIndexChanged">
                </asp:DropDownList>
                <br />
                <asp:Image ID="AwayImage" runat="server" CssClass="img" ImageUrl="~/Assets/images/baseball_logo_sm.png" />
            </div>
            <div class="col-sm-1 col-md-1"></div>

        </div>

        <div id="bottom" class="row">
            <div class="col-sm-2 col-md-3"></div>
            <div class="col-sm-8 col-md-6">
                <h3>Score</h3>
                <label class="control-label" for="HomeScoreTextbox">Home </label>
                <asp:TextBox ID="HomeScoreTextbox" runat="server"></asp:TextBox>

                &nbsp<i class="fa fa-minus" aria-hidden="true"></i>&nbsp
                <asp:TextBox ID="AwayScoreTextbox" runat="server"></asp:TextBox>
                <label class="control-label" for="AwayScoreTextbox">Away</label>
                <br />
                <asp:Button Text="Save" ID="SaveButton" CssClass="btn btn-primary btn-lg" runat="server" OnClick="SaveButton_Click" />
            </div>
            <div class="col-sm-2 col-md-3"></div>

        </div>
    </div>
</asp:Content>
