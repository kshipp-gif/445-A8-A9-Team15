<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginControl.ascx.cs" Inherits="_445_A8_A9_Team15.LoginControl" %>
<%@ Import Namespace="System.IO" %>
<%@ Import namespace="JoseDllLibrary" %>
<%@ Import Namespace="System.Xml" %>

<table id="MyTable" cellpadding="4" runat="server">
    <tr>
        <td>User Name:</td>
        <td><asp:TextBox runat="server" ID="UsernameText"></asp:TextBox></td>
    </tr>
    <tr>
        <td>Password:</td>
        <td><asp:TextBox runat="server" ID="PasswordText" TextMode="Password"></asp:TextBox></td>
    </tr>
    <tr>
        <td></td>
        <td><asp:LinkButton runat="server" ID="LoginButton" Text="Log In" OnClick="LoginButton_Click"></asp:LinkButton></td>
    </tr>
</table>
<hr/>
<p><asp:Label runat="server" ID="Output"></asp:Label></p>

<script language="c#" runat="server">
    public string UserName
    {
        get { return UsernameText.Text; }
        set { UsernameText.Text = value; }
    }

    public string Password
    {
        get { return PasswordText.Text; }
        set { PasswordText.Text = value; }
    }

    public void LoginButton_Click(object sender, EventArgs e)
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

</script>