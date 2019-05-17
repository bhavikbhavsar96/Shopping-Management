using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnRegister.Visible = false;
            btnAccount.Visible = false;

            if (Session["Username"] != null)
            {
                btnLogin.Text = "Logout";
                btnLogin.PostBackUrl = "~/Logout.aspx";
            }

            if (Session["Role"] != null && Session["Role"].Equals("Member"))
            {
                btnAdmin.Visible = false;
                btnAccount.Visible = true;
            }
            if (Session["Role"] != null && Session["Role"].Equals("Admin"))
            {
                btnRegister.Visible = true;
               
            }
        }
    }
}