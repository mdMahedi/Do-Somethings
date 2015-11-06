using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace MyWebsite.Registraton
{
    public partial class EmployeeRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int eid = Convert.ToInt32(txtID.Text);
            string eName = txtEmpName.Text;
            string Passwrd = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "SHA1");
            string rePasswrd = FormsAuthentication.HashPasswordForStoringInConfigFile(txtRePassword.Text,"SHA1");
            string mail = txtEmail.Text;

            DataAccessClass dac = new DataAccessClass();
            if (dac.InsertEmployeeRegistration(eid, eName, Passwrd, rePasswrd,mail))
                lblMsg.Text = "Registration Successfully Added..";
            else
                lblMsg.Text = "Sorry,,, Please Enter your Info Correctly.";
        }
    }
}