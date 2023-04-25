
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JoseDllLibrary;
using System.Xml;
using System.Web.Security;

namespace _445_A8_A9_Team15
{
    public partial class MemberLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void createCookieTicket(string username, bool isPersistent)
        {
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
                1,
                username,
                DateTime.Now,
                DateTime.Now.AddMinutes(30),
                isPersistent,
                "");
            string encryptedTicket = FormsAuthentication.Encrypt(ticket);
            HttpCookie cookie = new HttpCookie("memberCookie", encryptedTicket);
            Response.Cookies.Add(cookie);
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            AuthenticateUser(UsernameText.Text, PasswordText.Text);
        }

        public void AuthenticateUser(string username, string pwd)
        {
            EncryptionAndDecrypion Encryptor = new EncryptionAndDecrypion();
            string filepath = HttpRuntime.AppDomainAppPath + @"\App_Data\Members.xml";
            string user = username;
            string password = pwd;

            // Encrypt password
            string encryptedPassword = Encryptor.encrypt(password);

            // Open XML
            XmlDocument myDoc = new XmlDocument();
            myDoc.Load(filepath);
            XmlElement rootElement = myDoc.DocumentElement;

            foreach (XmlNode node in rootElement.ChildNodes)
            {
                if (node["username"].InnerText == user && user != "test")
                {
                    if (node["password"].InnerText == encryptedPassword)
                    {
                  
                        createCookieTicket(username, CookieCheckBox.Checked);
                        
                        Output.Text = "Success!";
                        Response.Redirect("Member.aspx"); // Redirect to the member page if credentials are valid
                    }
                    else // username exists but password does not match
                    {
                        Output.Text = "Password does not match username";
                    }
                }

                // For "test" user only
                if (node["username"].InnerText == user && user == "test")
                {
                    if (node["password"].InnerText == "password")
                    {
                        Output.Text = "Success!";
                        Response.Redirect("Default.aspx"); // Redirect to the member page if credentials are valid
                    }
                }
            }
        }
    }
}