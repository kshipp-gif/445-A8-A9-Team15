using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using JoseDllLibrary;

namespace _445_A8_A9_Team15
{
    public partial class MemberRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            EncryptionAndDecrypion Encryptor = new EncryptionAndDecrypion();
            string filepath = HttpRuntime.AppDomainAppPath + @"\App_Data\Members.xml";
            string user = UsernameText.Text;
            string password = PasswordText.Text;

            string encryptedPassword = Encryptor.encrypt(password); // hash

            XmlDocument myDoc = new XmlDocument();
            myDoc.Load(filepath); // open file
            XmlElement rootElement = myDoc.DocumentElement; // grab XML root node
            XmlNodeList nodeList = myDoc.SelectNodes("members/member");

            // Check if user already exists
            foreach (XmlNode node in nodeList) {
                foreach (XmlNode innerNode in node.ChildNodes)
                {
                    if (innerNode.InnerText == user)
                    {
                        Output.Text = String.Format("Account with username {0} already exists.", user);
                        return;
                    }
                }
            }

            // Captcha verification
            string captchaGuess = CaptchaGuessText.Text;
            string captchaActual = (string)HttpContext.Current.Session["CaptchaImageText"];
            
            if (captchaGuess == captchaActual)
            {
                // Add a new user into the XML
                XmlElement myMember = myDoc.CreateElement("member", rootElement.NamespaceURI);
                rootElement.AppendChild(myMember);

                XmlElement myUser = myDoc.CreateElement("username", rootElement.NamespaceURI);
                myMember.AppendChild(myUser);
                myUser.InnerText = user;

                XmlElement myPwd = myDoc.CreateElement("password", rootElement.NamespaceURI);
                myMember.AppendChild(myPwd);
                myPwd.InnerText = encryptedPassword;

                myDoc.Save(filepath);
                Output.Text = String.Format("Registration successful, welcome {0}. Please log in with your newly registered information.", user);
                return;
            }
            Output.Text = "Incorrect Captcha";
            return;
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("MemberLogin.aspx");
        }

        protected void HomeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}