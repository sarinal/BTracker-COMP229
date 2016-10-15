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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                this.GetGames();
            }
        }

        private void GetGames()
        {
            
            using (BTrackerContext db = new BTrackerContext())
            {
                
                var Games = (from allGames in db.games
                                select allGames);

                
                GamesGridView.DataSource = Games.ToList();
                GamesGridView.DataBind();
            }
        }
    }
}