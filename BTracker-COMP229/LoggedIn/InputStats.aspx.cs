using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BTracker_COMP229.Models;
using System.Web.ModelBinding;


namespace BTracker_COMP229
{
    public partial class InputStats : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if ((!IsPostBack) && (Request.QueryString.Count > 0))
            //{
            //    this.GetGame();


            //}
        }

        protected void GetGame()
        {
            
            int GameID = Convert.ToInt32(Request.QueryString["GameID"]);

            
            using (BTrackerContext db = new BTrackerContext())
            {
               
                game updatedGame = (from student in db.games
                                          where student.GameID == GameID
                                          select student).FirstOrDefault();

                
                if (updatedGame != null)
                {
                    switch(updatedGame.home_team)
                    {
                        case "Baltimore Orioles": case "Boston Red Sox": case "Chicago White Sox": case "Cleveland Indians": case "Detroit Tigers": case "Houston Astros": case "Kansas City Royals": case "Los Angeles Angels": case "Minnesota Twins": case "New York Yankees": case "Oakland Athletics": case "Seattle Mariners": case "Tampa Bay Rays": case "Texas Rangers": case "Toronto Blue Jays":
                            
                            break;
                        default:
                            break;
                    }

                }
            }
        }

        protected void HomeALList_Click(object sender, EventArgs e)
        {
            TeamHomeList.Items.Clear();
                TeamHomeList.Items.Add(new ListItem("Baltimore Orioles", "AL1"));
                TeamHomeList.Items.Add(new ListItem("Boston Red Sox", "AL2"));
            string Team = TeamHomeList.SelectedValue;
            HomeImage.ImageUrl = "~/Assets/images/" + Team + ".jpg";

        }

        protected void HomeNLList_Click(object sender, EventArgs e)
        {
            TeamHomeList.Items.Clear();
            TeamHomeList.Items.Add(new ListItem("Arizona Diamondbacks", "NL1"));
            TeamHomeList.Items.Add(new ListItem("Atlanta Braves", "NL2"));
            string Team = TeamHomeList.SelectedValue;
            HomeImage.ImageUrl = "~/Assets/images/" + Team + ".jpg";

        }

        protected void AwayALList_Click(object sender, EventArgs e)
        {
            TeamAwayList.Items.Clear();
            TeamAwayList.Items.Add(new ListItem("Baltimore Orioles", "AL1"));
            TeamAwayList.Items.Add(new ListItem("Boston Red Sox", "AL2"));
            string Team = TeamAwayList.SelectedValue;
            AwayImage.ImageUrl = "~/Assets/images/" + Team + ".jpg";

        }

        protected void AwayNLList_Click(object sender, EventArgs e)
        {
            TeamAwayList.Items.Clear();
            TeamAwayList.Items.Add(new ListItem("Arizona Diamondbacks", "NL1"));
            TeamAwayList.Items.Add(new ListItem("Atlanta Braves", "NL2"));
            string Team = TeamAwayList.SelectedValue;
            AwayImage.ImageUrl = "~/Assets/images/" + Team + ".jpg";

        }

        protected void TeamAwayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Team = TeamAwayList.SelectedValue;
            AwayImage.ImageUrl = "~/Assets/images/" + Team + ".jpg";
        }

        protected void TeamHomeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Team = TeamHomeList.SelectedValue;
            HomeImage.ImageUrl = "~/Assets/images/" + Team + ".jpg";
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            using (BTrackerContext db = new BTrackerContext())
            {
                game newGame = new game();




                newGame.home_team = TeamHomeList.SelectedItem.Text;
                newGame.away_team = TeamAwayList.SelectedItem.Text;

                int homeScore = Convert.ToInt32(HomeScoreTextbox.Text);
                int awayScore = Convert.ToInt32(AwayScoreTextbox.Text);
                if (homeScore > awayScore)
                {
                    newGame.winner = TeamHomeList.SelectedItem.Text;
                    newGame.loser = TeamAwayList.SelectedItem.Text;
                }
                else
                {
                    newGame.winner = TeamAwayList.SelectedItem.Text;
                    newGame.loser = TeamHomeList.SelectedItem.Text;
                }

                newGame.spectators = Convert.ToInt32(SpectatorsTextbox.Text);
                newGame.game_num = Convert.ToInt32(GameNumList.SelectedItem.Text);
                newGame.home_score = homeScore;
                newGame.away_score = awayScore;
                newGame.week = Convert.ToInt32(WeekTextbox.Text);

                db.games.Add(newGame);


                db.SaveChanges();

                Response.Redirect("~/LoggedIn/Tracker.aspx");

            }
        }
    }
}