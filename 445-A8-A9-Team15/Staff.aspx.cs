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
using System.Data;

namespace JoseRequiredServicesTryItPage {
    public partial class WebForm2 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("~/App_Data/Staff.xml"));

            // Bind the list to the GridView
            GridView1.DataSource = ds;
            GridView1.DataBind();
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
    }
}