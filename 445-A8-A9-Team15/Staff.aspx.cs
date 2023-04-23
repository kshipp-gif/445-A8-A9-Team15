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

namespace JoseRequiredServicesTryItPage {
    public partial class WebForm2 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            XDocument xmlDoc = XDocument.Load(Server.MapPath("~/App_Data/Staff.xml"));
            // Extract the data you want into a list
            var data = xmlDoc.Descendants("Member")
                             .Select(m => new {
                                 Username = (string)m.Attribute("username"),
                                 Password = (string)m.Attribute("password")
                             })
                             .ToList();

            // Bind the list to the GridView
            GridView1.DataSource = data;
            GridView1.DataBind();
        }

        protected void Unnamed5_Click(object sender, EventArgs e) {
            // this is where we add member to staff
            string memberName = usernameInput.Text;
            string memberPassword = passwordInput.Text;
            // Load the XML file
            XDocument xmlDoc = XDocument.Load(Server.MapPath("~/App_Data/Staff.xml"));

            // Add the new Member element
            xmlDoc.Element("Members").Add(new XElement("Member",
                new XAttribute("username", memberName),
                new XAttribute("password", memberPassword)));

            // Save the updated XML file
            xmlDoc.Save(Server.MapPath("~/App_Data/Testing.xml"));

            // Re-bind the GridView to the updated XML file
            // Extract the data you want into a list
            var data = xmlDoc.Descendants("Member")
                             .Select(m => new {
                                 Username = (string)m.Attribute("username"),
                                 Password = (string)m.Attribute("password")
                             })
                             .ToList();

            // Bind the list to the GridView
            GridView1.DataSource = data;
            GridView1.DataBind();
        }
    }
}