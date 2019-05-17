using FinalProject.FinalProjectDatasetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class Register : System.Web.UI.Page
    {

        tblUserTableAdapter adpUser = new tblUserTableAdapter();
        FinalProjectDataset.tblUserDataTable tblUser = new FinalProjectDataset.tblUserDataTable();

       
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtUsername.Text;
            string password = Encryptor.EncryptText(txtPassword.Text);
            string role = DropDownList1.SelectedItem.Value;

            

            if (DropDownList1.SelectedIndex != -1)
            {
                   int result = adpUser.InsertQuery(name, password, role);
                   lblMessage.Text = "User inserted";
            }
            
           
        }
    }
}