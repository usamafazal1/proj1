using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proj1
{
    public class accounts
    {
        //class for accounts//
        public string userName { get; set; }
        public string passWord { get; set; }

        //constructor to pass username, password to each new object (account)//
        public accounts(string username, string password)
        {
            this.userName = username;
            this.passWord = password;
        }

        List<accounts> accList = new List<accounts>(); //list containing accounts//
       
        //list method of accounts class which contains admin account//
        public List<accounts> acclistGen()
        {
            accounts admin = new accounts("admin", "admin"); 
            accList.Add(admin); //admin account added as the first//
            return accList;
        }
    }      

    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //when the page is loaded for the first time, isPostBack is false, so we use this//
            {
                if (Session["page"] == null) //at the start it is null, so this is true//
                {
                    accounts Admin = new accounts("","");
                    Session["accounts"] = Admin.acclistGen(); //account list is returned//
                    Session["page"] = "start"; //session not null anymore//

                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<accounts> accList = (List<accounts>)Session["accounts"];
            for (int i = 0; i < accList.Count; i++)
            {

                if (userName.Text == accList[i].userName && passWord.Text == accList[i].passWord)
                {
                    Session["user"] = accList[i].userName;
                    Response.Redirect("LandingPage.aspx");
                    break;
                }
                else
                {
                    if (Session["user"] == null)
                    {

                        Label3.Text = "No record found for this ID";

                    }
                    else
                    {
                        Label3.Text = "Enter the correct password or username";
                    }

                }
            }
        }
    }
}