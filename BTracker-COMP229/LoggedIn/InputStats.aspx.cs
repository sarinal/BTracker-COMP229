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
        string[] ALTeams =  new string[] { "Baltimore Orioles", "Boston Red Sox", "Chicago White Sox", "Cleveland Indians", "Detroit Tigers", "Houston Astros", "Kansas City Royals", "Los Angeles Angels", "Minnesota Twins", "New York Yankees", "Oakland Athletics", "Seattle Mariners", "Tampa Bay Rays", "Texas Rangers", "Toronto Blue Jays" };
        string[] NLTeams = new string[] { "Arizona Diamondbacks", "Atlanta Braves", "Chicago Cubs", "Cincinnati Reds", "Colorado Rockies", "Los Angeles Dodgers", "Miami Marlins", "Milwaukee Brewers", "New York Mets", "Philadelphia Phillies", "Pittsburgh Pirates", "San Diego Padres", "San Francisco Giants", "St. Louis Cardinals", "Washington Nationals" };
        protected void Page_Load(object sender, EventArgs e)
        {
            //if ((!IsPostBack) && (Request.QueryString.Count > 0))
            //{
            //    this.GetGame();


            //}
        }

        
        //Generate Home Team Listbox via global array variable on click
        protected void HomeALList_Click(object sender, EventArgs e)
        {

            TeamHomeList.Items.Clear();
            for (int i=1;i<16; i++)
            {
                string teamNum = "AL" + i;
                string teamName = ALTeams[i-1];
                TeamHomeList.Items.Add(new ListItem(teamName, teamNum));
            }
            string Team = TeamHomeList.SelectedValue;
            HomeImage.ImageUrl = "~/Assets/images/" + Team + ".jpg";

        }

        //Generate Home Team Listbox via global array variable on click
        protected void HomeNLList_Click(object sender, EventArgs e)
        {
            TeamHomeList.Items.Clear();
            for (int i = 1; i < 16; i++)
            {
                string teamNum = "NL" + i;
                string teamName = NLTeams[i - 1];
                TeamHomeList.Items.Add(new ListItem(teamName, teamNum));
            }
            string Team = TeamHomeList.SelectedValue;
            HomeImage.ImageUrl = "~/Assets/images/" + Team + ".jpg";

        }

        //Generate Away Team Listbox via global array variable on click
        protected void AwayALList_Click(object sender, EventArgs e)
        {
            TeamAwayList.Items.Clear();
            for (int i = 1; i < 16; i++)
            {
                string teamNum = "AL" + i;
                string teamName = ALTeams[i-1];
                TeamAwayList.Items.Add(new ListItem(teamName, teamNum));
            }
            string Team = TeamAwayList.SelectedValue;
            AwayImage.ImageUrl = "~/Assets/images/" + Team + ".jpg";

        }

        //Generate Away Team Listbox via global array variable on click
        protected void AwayNLList_Click(object sender, EventArgs e)
        {
            TeamAwayList.Items.Clear();
            TeamAwayList.Items.Clear();
            for (int i = 1; i < 16; i++)
            {
                string teamNum = "NL" + i;
                string teamName = NLTeams[i - 1];
                TeamAwayList.Items.Add(new ListItem(teamName, teamNum));
            }
            string Team = TeamAwayList.SelectedValue;
            AwayImage.ImageUrl = "~/Assets/images/" + Team + ".jpg";

        }

        //Change Team image on index change
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


        //Save inputted info
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
                newGame.game_date = Convert.ToDateTime(GameDateTextbox.Text);

                db.games.Add(newGame);


                db.SaveChanges();

                Response.Redirect("~/LoggedIn/Tracker.aspx");

            }
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/LoggedIn/Tracker.aspx");
        }
    }
}