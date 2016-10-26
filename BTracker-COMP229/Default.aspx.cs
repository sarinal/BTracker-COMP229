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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            generateGames();
        }

        protected void generateGames()
        {
            using (BTrackerContext db = new BTrackerContext())
            {
                var Games = (from allGames in db.games
                             select allGames);

                foreach (var game in Games)
                {
                    System.Web.UI.HtmlControls.HtmlGenericControl divNew = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
                    placeholder.Controls.Add(divNew);
                    divNew.ID = "newDivRow";



                    Table newTable = new Table();


                    TableRow r1 = new TableRow();
                    TableCell c1r1 = new TableCell();
                    TableCell c2r1 = new TableCell();
                    TableCell c3r1 = new TableCell();
                    c1r1.Controls.Add(new LiteralControl("<h1>HOME TEAM </h1> "));
                    c2r1.Controls.Add(new LiteralControl(game.game_date.ToString("MMM dd, yyyy")));
                    c3r1.Controls.Add(new LiteralControl("<h1>AWAY TEAM</h1>"));
                    r1.Cells.Add(c1r1);
                    r1.Cells.Add(c2r1);
                    r1.Cells.Add(c3r1);
                    newTable.Rows.Add(r1);

                    TableRow r2 = new TableRow();
                    TableCell c1r2 = new TableCell();
                    TableCell c2r2 = new TableCell();
                    TableCell c3r2 = new TableCell();
                    c1r2.Controls.Add(new LiteralControl(game.home_team));
                    c2r2.Controls.Add(new LiteralControl("Week: " + game.week + " Game: " + game.game_num + "<br/> Spectators: " + game.spectators));
                    c3r2.Controls.Add(new LiteralControl(game.away_team));
                    r2.Cells.Add(c1r2);
                    r2.Cells.Add(c2r2);
                    r2.Cells.Add(c3r2);
                    newTable.Rows.Add(r2);

                    TableRow r3 = new TableRow();
                    TableCell c1r3 = new TableCell();
                    TableCell c2r3 = new TableCell();
                    TableCell c3r3 = new TableCell();
                    c1r3.Controls.Add(new LiteralControl("<img src = 'Assets/images/" + game.home_team + ".png'>"));
                    c2r3.Controls.Add(new LiteralControl("<img src = 'Assets/images/versus.png'>"));
                    c3r3.Controls.Add(new LiteralControl("<img src = 'Assets/images/" + game.away_team + ".png'>"));
                    r3.Cells.Add(c1r3);
                    r3.Cells.Add(c2r3);
                    r3.Cells.Add(c3r3);
                    newTable.Rows.Add(r3);

                    TableRow r4 = new TableRow();
                    TableCell c1r4 = new TableCell();
                    TableCell c2r4 = new TableCell();
                    TableCell c3r4 = new TableCell();
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
        protected void createGameTable ()
        {
            using (BTrackerContext db = new BTrackerContext())
            {
                var Games = (from allGames in db.games
                             select allGames);
                Table newTable = new Table();

                
                    TableRow r1 = new TableRow();
                TableCell c1r1 = new TableCell();
                TableCell c2r1= new TableCell();
                TableCell c3r1 = new TableCell();
                c1r1.Controls.Add(new LiteralControl("HOME TEAM"));
                c1r1.Controls.Add(new LiteralControl(" TEAM"));
                c1r1.Controls.Add(new LiteralControl("AWAY TEAM"));
                    
            }
        }

        protected Table testcreatetable ()
        {
            Table Table1 = new Table();

            int numrows = 3;
            int numcells = 2;
            for (int j = 0; j < numrows; j++)
            {
                TableRow r = new TableRow();
                for (int i = 0; i < numcells; i++)
                {
                    TableCell c = new TableCell();
                    c.Controls.Add(new LiteralControl("row "
                        + j.ToString() + ", cell " + i.ToString()));
                    r.Cells.Add(c);
                }
                Table1.Rows.Add(r);
            }
            return Table1;
        }
    }
}