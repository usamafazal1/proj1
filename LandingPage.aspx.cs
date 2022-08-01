﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proj1
{
    public partial class LandingPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            else if ((string)Session["user"] != "admin")
            {
                accountants.Attributes.Add("class", "nav-link disabled");
            }
            else if ((string)Session["user"] == "admin")
            {
                bill.Attributes.Add("class", "nav-link disabled");
            }


            Label_User.Text = "Welcome,     You are " + (string)Session["user"] + "!     ";
        }

        protected void Button_LogOut_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            Response.Redirect("LoginPage.aspx");
        }


    }
}