﻿using System;
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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Register.aspx");
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            var userStore = new UserStore<IdentityUser>();

            var userManager = new UserManager<IdentityUser>(userStore);

            

            var user = userManager.Find(UserNameTextBox.Text, PasswordTextBox.Text);

            

            if (user != null)
            {
                
                var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                
                authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = false }, userIdentity);

                
                Response.Redirect("~/Default.aspx");

            }
            else 
            {
                StatusLabel.Text = "Invalid Username or Password";
                AlertFlash.Visible = true;
            }
        }
    }
}