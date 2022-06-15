using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RealProjectH3.Authen
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            divMsg.Visible = false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckFieldValue()== false)
            {
                if (txtUsername.Text == "admin" && txtPassword.Text == "123")
                {
                    Response.Redirect("~/Student/StudentRegistration.aspx");
                }
            }
        }

        private bool CheckFieldValue()
        {
            bool IsReq = false;

            if (txtUsername.Text == "")
            {
                IsReq = true;
                lblMsg.Text = "Username can't be empty";
            }
            else if (txtPassword.Text == "")
            {
                IsReq = true;
                lblMsg.Text = "Password can't be empty";
            }

            if (IsReq == true)
            {
                divMsg.Visible = true;
            }
            else
            {
                divMsg.Visible = false;
            }

            return IsReq;
        }
    }
}