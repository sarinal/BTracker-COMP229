﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTracker_COMP229
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            var autheticationManager = HttpContext.Current.GetOwinContext().Authentication;

            
            autheticationManager.SignOut();
            Response.Redirect("~/Login.aspx");
        }
    }
}