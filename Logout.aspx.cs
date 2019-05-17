using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Username"] = null;
            Session["Role"] = null;

            // and logout
            FormsAuthentication.SignOut();
            Response.Redirect("~/");
        }
    }
}