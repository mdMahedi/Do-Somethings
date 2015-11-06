using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace MyWebsite.Registraton
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string mail = uname.Text;
            //string pass = FormsAuthentication.HashPasswordForStoringInConfigFile(passw.Text, "SHA1");
            //DataAccessClass dac = new DataAccessClass();
            //if (dac.CheckLoginValueFromSQL(mail, pass))
            //{ FormsAuthentication.RedirectFromLoginPage(mail, true); }
            //else { lblMsg.Text = "Incorrect User Name or Password."; }
        }
    }
}