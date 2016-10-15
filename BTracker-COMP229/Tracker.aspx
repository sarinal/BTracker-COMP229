<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tracker.aspx.cs" Inherits="BTracker_COMP229.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-offset-2 col-md-8">
                <h1>Student List</h1>
                <a href="/InputStats.aspx" class="btn btn-success btn-sm">
                    <i class="fa fa-plus">Add Game</i>
                </a>
                <asp:GridView ID="GamesGridView" runat="server" AutoGenerateColumns="false"
                    CssClass="table table-bordered table-striped table-hover" DataKeyNames="GameID">
                    <Columns>
                        <asp:BoundField DataField="week" HeaderText="Week No." Visible="true" />
                        <asp:BoundField DataField="game_num" HeaderText="Game No." Visible="true" />
                        <asp:BoundField DataField="home_team" HeaderText="Home Team" Visible="true" />
                        <asp:BoundField DataField="home_score" HeaderText="Home Team Score" Visible="true" />
                        <asp:BoundField DataField="away_team" HeaderText="Away Team" Visible="true" />
                        <asp:BoundField DataField="away_score" HeaderText="Away Team Score" Visible="true" />
                        <asp:BoundField DataField="game_date" HeaderText="Date" Visible="true" 
                            DataFormatString="{0:MMM dd, yyyy}"/>

                        
                    </Columns>

                </asp:GridView>


            </div>
        </div>
    </div>
</asp:Content>
