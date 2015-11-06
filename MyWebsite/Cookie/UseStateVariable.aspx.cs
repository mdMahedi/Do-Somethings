using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebsite.Cookie
{
    public partial class UseStateVariable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //HttpCookie hcookie = new HttpCookie("myCookie");
            //hcookie.Values["fNam"] = fname.Text;
            //hcookie.Values["lNam"] = lname.Text;
            //hcookie.Expires = System.DateTime.Now.AddDays(1);
            //Response.Cookies.Add(hcookie);

            Session["fName"] = fname.Text;
            Application["lName"] = lname.Text;

            Response.Redirect("ResponseStateVariable.aspx?id=100");
            Server.Transfer("ResponseStateVariable.aspx");
        }
    }
}