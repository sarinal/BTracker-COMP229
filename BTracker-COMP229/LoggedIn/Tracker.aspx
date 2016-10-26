<%@ Page Title="Tracker" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tracker.aspx.cs" Inherits="BTracker_COMP229.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Author: Sarina Luu, Sam Buensuceso
    Student#: 300838958, 300799984
    Date: October 25, 2016
    Version: 2.0
    File Name: Tracker.aspx--> 

    <div class="container">
        <div class="row">
            <div class="col-md-offset-2 col-md-8">
                <h1>Baseball Games</h1>
                <a href="/LoggedIn/InputStats.aspx" class="btn btn-success btn-sm">
                    <i class="fa fa-plus">Add Game</i>
                </a>
                <asp:GridView ID="GamesGridView" runat="server" AutoGenerateColumns="false"
                    CssClass="table table-bordered table-striped table-hover" DataKeyNames="GameID" OnRowDeleting="GamesGridView_RowDeleting">
                    <Columns>
                        <asp:BoundField DataField="week" HeaderText="Week No." Visible="true" />
                        <asp:BoundField DataField="game_num" HeaderText="Game No." Visible="true" />
                        <asp:BoundField DataField="home_team" HeaderText="Home Team" Visible="true" />
                        <asp:BoundField DataField="home_score" HeaderText="Home Team Score" Visible="true" />
                        <asp:BoundField DataField="away_team" HeaderText="Away Team" Visible="true" />
                        <asp:BoundField DataField="away_score" HeaderText="Away Team Score" Visible="true" />
                        <asp:BoundField DataField="game_date" HeaderText="Date" Visible="true" 
                            DataFormatString="{0:MMM dd, yyyy}"/>

                        <%--<asp:HyperLinkField HeaderText="Edit" Text="<i class='fa fa-pencil-square-o fa-lg'></i> Edit"
                            NavigateUrl="~/LoggedIn/InputStats.aspx.cs" ControlStyle-CssClass="btn btn-primary btn-sm"
                            runat="server" DataNavigateUrlFields="GameID" 
                            DataNavigateUrlFormatString="InputStats.aspx?GameID={0}" /> --%>

                        <asp:CommandField HeaderText="Delete" DeleteText="<i class='fa fa-trash-o fa-lg'></i> Delete"
                            ShowDeleteButton="true" ButtonType="Link" ControlStyle-CssClass="btn btn-danger btn-sm"/>
                        
                    </Columns>

                </asp:GridView>


            </div>
        </div>
    </div>
</asp:Content>
