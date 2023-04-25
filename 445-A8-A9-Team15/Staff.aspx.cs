using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using JoseDllLibrary;
using System.Web.Security;
using System.Data;

namespace JoseRequiredServicesTryItPage {
    public partial class WebForm2 : System.Web.UI.Page {
        private FormsAuthenticationTicket staffCookie;
        protected void Page_Load(object sender, EventArgs e) {
            if (!this.cookieChecker())
            {
                Response.Redirect("~/Login.aspx");
            }
            XDocument xmlDoc = XDocument.Load(Server.MapPath("~/App_Data/Staff.xml"));
            // Extract the data you want into a list
            var data = xmlDoc.Descendants("Member")
                             .Select(m => new {
                                 Username = (string)m.Attribute("username"),
                                 Password = (string)m.Attribute("password")
                             })
                             .ToList();

            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("~/App_Data/Staff.xml"));

            // Bind the list to the GridView
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        private bool cookieChecker()
        {
            string username;
            try
            {
                HttpCookie cookie = Request.Cookies.Get("staffCookie");
                if (cookie == null)
                {

                    return false;
                }
                staffCookie = FormsAuthentication.Decrypt(cookie.Value);
            }
            catch (ArgumentException)
            {
                return false;
            }

            if (staffCookie == null)
            {
                return false;
            }
            else
            {
                username = staffCookie.Name;
            }
            userName.Text = username;
            return true;
        }

        protected void Unnamed5_Click(object sender, EventArgs e) {
            // this is where we add member to staff
            EncryptionAndDecrypion Encryptor = new EncryptionAndDecrypion();
            string memberName = usernameInput.Text;
            string memberPassword = passwordInput.Text;

            string encryptedPassword = Encryptor.encrypt(memberPassword);
            // Load the XML file
            string filepath = HttpRuntime.AppDomainAppPath + @"\App_Data\Staff.xml";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filepath);
            XmlElement rootElement = xmlDoc.DocumentElement; // grab XML root node
            XmlNodeList nodeList = xmlDoc.SelectNodes("members/member");

            foreach (XmlNode staffNode in nodeList) {
                foreach (XmlNode inNode in staffNode.ChildNodes) {
                    if(inNode.InnerText == memberName) {
                        // already exists
                        return;
                    }
                }
            }

            XmlElement newStaff = xmlDoc.CreateElement("member", rootElement.NamespaceURI);
            rootElement.AppendChild(newStaff);

            XmlElement newStaffName = xmlDoc.CreateElement("username", rootElement.NamespaceURI);
            newStaff.AppendChild(newStaffName);
            newStaffName.InnerText = memberName;

            XmlElement newStaffPassword = xmlDoc.CreateElement("password", rootElement.NamespaceURI);
            newStaff.AppendChild(newStaffPassword);
            newStaffPassword.InnerText = encryptedPassword;
            
            // Save the updated XML file
            xmlDoc.Save(Server.MapPath("~/App_Data/Staff.xml"));

            // Re-bind the GridView to the updated XML file
            // Extract the data you want into a list
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("~/App_Data/Staff.xml"));

            // Bind the list to the GridView
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void homePageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void LogOutButton_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["staffCookie"] != null)
            {
                Response.Cookies["staffCookie"].Expires = DateTime.Now.AddDays(-1);
            }
            Response.Redirect("~/Default.aspx");
        }
    }
}