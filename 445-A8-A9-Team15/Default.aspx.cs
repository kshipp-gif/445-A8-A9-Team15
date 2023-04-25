using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
namespace _445_A8_A9_Team15
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }

        protected void MemberPageBtn_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies.Get("memberCookie");
            if (cookie != null)
            {
                FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(cookie.Value);
                if (ticket != null)
                {
                    bool persistence = ticket.IsPersistent;
                    if (persistence == false)
                    {
                        Response.Redirect("~/MemberLogin.aspx");
                    }
                    else
                    {
                        Response.Redirect("Member.aspx");
                    }

                }
                else
                {
                    Response.Redirect("~/MemberLogin.aspx");
                }
            }
            else
            {
                Response.Redirect("~/MemberLogin.aspx");
            }

        }

        protected void MemberLoginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("MemberLogin.aspx");
        }

        protected void StaffPageBtn_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies.Get("staffCookie");
            if (cookie != null)
            {
                FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(cookie.Value);
                if (ticket != null)
                {
                    bool persistence = ticket.IsPersistent;
                    if (persistence == false)
                    {
                        Response.Redirect("~/Login.aspx");
                    }
                    else
                    {
                        Response.Redirect("Staff.aspx");
                    }

                }
                else
                {
                    Response.Redirect("~/Login.aspx");
                }
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
            
            // Response.Redirect("Admin.aspx"); it really is admin page
        }

        protected void StaffLoginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

    }
}