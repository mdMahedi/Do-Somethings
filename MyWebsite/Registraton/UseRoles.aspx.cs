using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebsite.Registraton
{
    public partial class UseRoles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDropDown();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!Roles.RoleExists(TextBox1.Text))
            { Roles.CreateRole(TextBox1.Text); }
            else {lblMsg.Text = "Role already Exist.";}
            LoadDropDown();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string userName=DropDownList1.SelectedItem.ToString();
            string roleName=DropDownList2.SelectedItem.ToString();
            if (!Roles.IsUserInRole(userName, roleName))
            {
                Roles.AddUserToRole(userName, roleName);
                lblMsg.Text = "User Added in Role.";
            }
            else
            {
                lblMsg.Text="User already Exist in this Role.";
            }

        }

        void LoadDropDown() 
        {
            DropDownList1.Items.Clear();
            DropDownList2.Items.Clear();

            MembershipUserCollection currentUser = Membership.GetAllUsers();
            foreach (MembershipUser mu in currentUser)
            {
                DropDownList1.Items.Add(mu.UserName);
            }

            string[] currentRoles = Roles.GetAllRoles();
            foreach (string role in currentRoles)
            {
                DropDownList2.Items.Add(role);
            }
        }
    }
}