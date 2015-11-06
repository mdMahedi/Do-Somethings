using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebsite.Cookie
{
    public partial class ResponseStateVariable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Response.Write(Request.Cookies["myCookie"]["fNam"]);
            string id = Request.QueryString["id"].ToString();

            string fnam = Session["fName"].ToString();
            string lnam = Application["lName"].ToString();

            Response.Write(fnam + ' ' + lnam);
        }
    }
}