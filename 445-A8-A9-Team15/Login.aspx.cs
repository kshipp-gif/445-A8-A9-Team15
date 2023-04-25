﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using JoseDllLibrary;

namespace _445_A8_A9_Team15
{
    public partial class Login : System.Web.UI.Page
    {

        

        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie myCookies = Request.Cookies["LoginCookie"];
            DateTime now = DateTime.Now;
            
        }

        public void createMemberCookie(string userName, string password)
        {
            HttpCookie loginCookie = new HttpCookie("username", "password");

            //set cookie values 
            loginCookie.Values["username"] = userName;
            loginCookie.Values["password"] = password;

            loginCookie.Expires = DateTime.Now.AddDays(5); //cookie expires in 5 days 

            loginCookie.Secure = true;

            Response.Cookies.Add(loginCookie);
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {

            AuthenticateUser(UsernameText.Text, PasswordText.Text);
        }

        public void AuthenticateUser(string username, string pwd)
        {
            EncryptionAndDecrypion Encryptor = new EncryptionAndDecrypion();
            string filepath = HttpRuntime.AppDomainAppPath + @"\App_Data\Member.xml";
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
                        Output.Text = "Success!";
                        Response.Redirect("Member.aspx"); // Redirect to the member page if credentials are valid
                    }
                    else // username exists but password does not match
                    {
                        Output.Text = "Password does not match username";
                    }
                }
            }
        }
    }
}