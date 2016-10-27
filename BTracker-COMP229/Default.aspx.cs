using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BTracker_COMP229.Models;
using System.Web.ModelBinding;
using System.Web.UI.HtmlControls;

namespace BTracker_COMP229
{
    public partial class Default : System.Web.UI.Page
    {
        string[] ALTeams = new string[] { "Baltimore Orioles", "Boston Red Sox", "Chicago White Sox", "Cleveland Indians", "Detroit Tigers", "Houston Astros", "Kansas City Royals", "Los Angeles Angels", "Minnesota Twins", "New York Yankees", "Oakland Athletics", "Seattle Mariners", "Tampa Bay Rays", "Texas Rangers", "Toronto Blue Jays" };
        string[] NLTeams = new string[] { "Arizona Diamondbacks", "Atlanta Braves", "Chicago Cubs", "Cincinnati Reds", "Colorado Rockies", "Los Angeles Dodgers", "Miami Marlins", "Milwaukee Brewers", "New York Mets", "Philadelphia Phillies", "Pittsburgh Pirates", "San Diego Padres", "San Francisco Giants", "St. Louis Cardinals", "Washington Nationals" };
        protected void Page_Load(object sender, EventArgs e)
        {
            
            generateGames();
        }

        /*This method creates a new div for each row in the games table
         * it generates html table code to display the information in each table field
         * as well as the appropriate team image
         */
        protected void generateGames()
        {
            using (BTrackerContext db = new BTrackerContext())
            {
                var Games = (from allGames in db.games
                             select allGames);
                int count = 0; //to ensure that each newly created div has a unique id

                foreach (var game in Games)
                {
                    HtmlGenericControl divNew = new HtmlGenericControl("div");
                    placeholder.Controls.Add(divNew);
                    count = count + 1;
                    divNew.ID = "newDivRow"+ count;



                    Table newTable = new Table();



                    TableRow r1 = new TableRow();
                    TableCell c1r1 = new TableCell();
                    TableCell c2r1 = new TableCell();
                    TableCell c3r1 = new TableCell();
                    c1r1.Controls.Add(new LiteralControl("<h1>HOME TEAM </h1> "));
                    c2r1.Controls.Add(new LiteralControl("<h5>" + game.game_date.ToString("MMM dd, yyyy") + "</h5>"));
                    c3r1.Controls.Add(new LiteralControl("<h1>AWAY TEAM</h1>"));
                    r1.Cells.Add(c1r1);
                    r1.Cells.Add(c2r1);
                    r1.Cells.Add(c3r1);
                    newTable.Rows.Add(r1);

                    TableRow r2 = new TableRow();
                    TableCell c1r2 = new TableCell();
                    TableCell c2r2 = new TableCell();
                    TableCell c3r2 = new TableCell();
                    c1r2.Controls.Add(new LiteralControl("<h5>" + game.home_team + "</h5>"));
                    c2r2.Controls.Add(new LiteralControl("<h5> Week: " + game.week + " Game: " + game.game_num + "<br/> Spectators: " + game.spectators + "</h5>"));
                    c3r2.Controls.Add(new LiteralControl("<h5>" + game.away_team + "</h5>"));
                    r2.Cells.Add(c1r2);
                    r2.Cells.Add(c2r2);
                    r2.Cells.Add(c3r2);
                    newTable.Rows.Add(r2);

                    TableRow r3 = new TableRow();
                    TableCell c1r3 = new TableCell();
                    TableCell c2r3 = new TableCell();
                    TableCell c3r3 = new TableCell();
                    c1r1.Style.Add(HtmlTextWriterStyle.Padding, "5px");
                    c1r3.Controls.Add(new LiteralControl("<img src = 'Assets/images/" + game.home_team + ".png' width='200px '>"));
                    c2r3.Controls.Add(new LiteralControl("<img src = 'Assets/images/versus.png'width='200px ' height='200px '>"));
                    c1r3.Style.Add(HtmlTextWriterStyle.Padding, "5px");
                    c3r3.Controls.Add(new LiteralControl("<img src = 'Assets/images/" + game.away_team + ".png' width='200px '>"));
                    r3.Cells.Add(c1r3);
                    r3.Cells.Add(c2r3);
                    r3.Cells.Add(c3r3);
                    newTable.Rows.Add(r3);

                    TableRow r4 = new TableRow();
                    TableCell c1r4 = new TableCell();
                    TableCell c2r4 = new TableCell();
                    TableCell c3r4 = new TableCell();

                    //determines who is the winner of the game
                    if (game.home_team == game.winner)
                    { 
                    c1r4.Controls.Add(new LiteralControl("<h3>WINNER!!</h3>"));
                    }
                    else
                    {
                        c3r4.Controls.Add(new LiteralControl("<h3>WINNER!!</h3>"));
                    }
                    c2r4.Controls.Add(new LiteralControl("<h1>" + game.home_score + " - " + game.away_score + "</h1>"));
                    
                    r4.Cells.Add(c1r4);
                    r4.Cells.Add(c2r4);
                    r4.Cells.Add(c3r4);
                    newTable.Rows.Add(r4);

                    
                    divNew.Controls.Add(newTable);
                        }
            }
        }


        //Generates the team list for the corresponding listbox when click - American league teams 
        protected void ALButton_Click(object sender, EventArgs e)
        {
            TeamList.Items.Clear();
            TeamList.Items.Add(new ListItem("--select team--", ""));
            for (int i = 1; i < 16; i++)
            {
                string teamNum = "AL" + i;
                string teamName = ALTeams[i - 1];
                TeamList.Items.Add(new ListItem(teamName, teamNum));
            }
            string Team = TeamList.SelectedValue;
        }

        //Generates the team list for the corresponding listbox when click - National league teams 
        protected void NLButton_Click(object sender, EventArgs e)
        {
            TeamList.Items.Clear();
            TeamList.Items.Add(new ListItem("--select team--", ""));
            for (int i = 1; i < 16; i++)
            {
                string teamNum = "NL" + i;
                string teamName = NLTeams[i - 1];
                TeamList.Items.Add(new ListItem(teamName, teamNum));
            }
            string Team = TeamList.SelectedValue;
        }


        //Displays the team stat info for the selected team when listbox index is changed
        protected void TeamList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string selectedTeam = TeamList.SelectedItem.Text;
            using (BTrackerContext db = new BTrackerContext())
            {
                var Teams = (from allTeams in db.teams
                             select allTeams);

                foreach (var t in Teams)
                {
                    if (t.team1 == selectedTeam)
                    {
                        teamimage.ImageUrl = "~/Assets/images/" + selectedTeam + ".png";

                        TeamLabel.Text = t.team1;

                        WinsLabel.Text = "W: " + Convert.ToString(t.wins);
                        LossesLabel.Text = "L: " + Convert.ToString(t.losses);

                        DivisionLabel.Text = t.division;

                    }
                }
            }
        }
    }
}