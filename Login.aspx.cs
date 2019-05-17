using FinalProject.FinalProjectDatasetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class Login : System.Web.UI.Page
    {
        tblUserTableAdapter adpUser = new tblUserTableAdapter();
        FinalProjectDataset.tblUserDataTable tblUser = new FinalProjectDataset.tblUserDataTable();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = Encryptor.EncryptText(txtPassword.Text.Trim());

            tblUser = adpUser.GetUserByUsernamePassword(username, password);

            if (tblUser.Count == 1)
            {
                var row = tblUser[0];   // read the only row

                // initialize FormsAuthentication
                FormsAuthentication.Initialize();

                // create a new ticket used for authentication
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
                    1,                              // ticket version
                    username,                       // username associated with ticket
                    DateTime.Now,                   // date/time issued
                    DateTime.Now.AddMinutes(30),    // date/time to expire
                    chkRememberMe.Checked,          // "true" for a persistent user cookie
                    row.Role,                       // user-data, in this case the roles
                    FormsAuthentication.FormsCookiePath);   // path cookie is valid for

                // encrypt the ticket using the machine key for secure transport
                string hashedTicket = FormsAuthentication.Encrypt(ticket);

                // create cookie
                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, hashedTicket);

                // set the cookie's expiration time to the ticket's expiration time
                if (ticket.IsPersistent)
                    cookie.Expires = ticket.Expiration;

                // add the cookie to the list for outgoing response
                Response.Cookies.Add(cookie);

                // redirect to requested URL, or to the role's homepage
                string returnUrl = Request.QueryString["ReturnUrl"];

                if (returnUrl == null)
                {
                    if (row.Role == "Admin")
                        returnUrl = "~/Admin/";
                    else if (row.Role == "Member")
                        returnUrl = "~/Member/";
                    else
                        returnUrl = "~/";
                }

                Session["Username"] = username;
                Session["Role"] = row.Role;

                Response.Redirect(returnUrl);
            }
            else
                lblMessage.Text = "Login failed. Please try again.";
        }
    }
}