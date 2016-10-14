using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTracker_COMP229
{
    public partial class InputStats : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void HomeALList_Click(object sender, EventArgs e)
        {
            TeamHomeList.Items.Clear();
                TeamHomeList.Items.Add(new ListItem("Baltimore Orioles", "AL1"));
                TeamHomeList.Items.Add(new ListItem("Boston Red Sox", "AL2"));
            
        }

        protected void HomeNLList_Click(object sender, EventArgs e)
        {
            TeamHomeList.Items.Clear();
            TeamHomeList.Items.Add(new ListItem("Arizona Diamondbacks", "NL1"));
            TeamHomeList.Items.Add(new ListItem("Atlanta Braves", "NL2"));

        }

        protected void AwayALList_Click(object sender, EventArgs e)
        {
            TeamAwayList.Items.Clear();
            TeamAwayList.Items.Add(new ListItem("Baltimore Orioles", "AL1"));
            TeamAwayList.Items.Add(new ListItem("Boston Red Sox", "AL2"));

        }

        protected void AwayNLList_Click(object sender, EventArgs e)
        {
            TeamAwayList.Items.Clear();
            TeamAwayList.Items.Add(new ListItem("Arizona Diamondbacks", "NL1"));
            TeamAwayList.Items.Add(new ListItem("Atlanta Braves", "NL2"));

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
    }
}