using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;


namespace BTracker_COMP229
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    
                    LoginPlaceHolder.Visible = true;
                    PublicPlaceHolder.Visible = false;
                }
                else
                {
                    
                    LoginPlaceHolder.Visible = false;
                    PublicPlaceHolder.Visible = true;
                }
            }
            
        }
    }
}