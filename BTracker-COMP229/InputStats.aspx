<%@ Page Title="Input Stats" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InputStats.aspx.cs" Inherits="BTracker_COMP229.InputStats" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-offset-3 col md 6">
                
                <h6>Home Team</h6>
                <asp:Button Text="American" ID="HomeALButton" CssClass="btn btn-primary btn-md" runat="server" onclick="HomeALList_Click" />
                <asp:Button Text="National" ID="HomeNLButton" CssClass="btn btn-warning btn-md" runat="server" onclick="HomeNLList_Click" />
                
                <asp:DropDownList ID="TeamHomeList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="TeamHomeList_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:Image ID="HomeImage" runat="server" ImageUrl="~/Assets/images/baseball_logo_sm.png"/>


                <label class="control-label" for="GameDateTextbox">Date </label>
                    <asp:TextBox runat="server" ID="GameDateTextbox" 
                        placeholder="Enrollment Date" requiered="true" TextMode="Date"></asp:TextBox>

                <h6>Away Team</h6>
                <asp:Button Text="American" ID="AwayALButton" CssClass="btn btn-primary btn-md" runat="server" onclick="AwayALList_Click" />
                <asp:Button Text="National" ID="AwayNLButton" CssClass="btn btn-warning btn-md" runat="server" onclick="AwayNLList_Click" />

                <asp:DropDownList ID="TeamAwayList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="TeamAwayList_SelectedIndexChanged">

                </asp:DropDownList>
                <asp:Image ID="AwayImage" runat="server" ImageUrl="~/Assets/images/baseball_logo_sm.png" />

                <label class="control-label" for="GameNumList">Game No. </label>
                <asp:DropDownList ID="GameNumList" runat="server">
                    <asp:ListItem Text="1"></asp:ListItem>
                    <asp:ListItem Text="2"></asp:ListItem>
                    <asp:ListItem Text="3"></asp:ListItem>
                    <asp:ListItem Text="4"></asp:ListItem>
                </asp:DropDownList>

                <label class="control-label" for="SpectatorsTextbox">No. of Spectators </label>
                <asp:TextBox ID="SpectatorsTextbox" runat="server"></asp:TextBox>

                <h4>Score</h4>
                <label class="control-label" for="HomeScoreTextbox">Home </label>
                <asp:TextBox ID="HomeScoreTextbox" runat="server"></asp:TextBox>


                <label class="control-label" for="AwayScoreTextbox">Away</label>
                <asp:TextBox ID="AwayScoreTextbox" runat="server"></asp:TextBox>

                <asp:Button Text="Save" ID="SaveButton" CssClass="btn btn-primary btn-lg" runat="server"/>
            </div>
        </div>
    </div>
</asp:Content>
