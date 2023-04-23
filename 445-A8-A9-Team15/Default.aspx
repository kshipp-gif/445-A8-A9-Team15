<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_445_A8_A9_Team15._Default" %>
<%@ Register tagPrefix="user" tagName="LoginControl" src="LoginControl.ascx" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Default Page</h1>
    <hr/>
    <div>
        <h3>How to sign up for services:</h3>
        <p>Users must register via the member register link which will grant access to the Member Page. The Member Page will contain links to all services.</p>
        <%-- <user:LoginControl ID="MyLogin" BackColor="#ccccff" runat="server"/> --%>
        <table id="LoginTable" cellpadding="4" runat="server">
            <tr>
                <td><asp:Button runat="server" ID="MemberPageBtn" Text="Member Page" OnClick="MemberPageBtn_Click"/></td>
                <td><asp:Button runat="server" ID="MemberLoginBtn" Text="Member Login" OnClick="MemberLoginBtn_Click"></asp:Button></td>
            </tr>
            <tr>
                <td><asp:Button runat="server" ID="StaffPageBtn" Text="Staff Page" OnClick="StaffPageBtn_Click"/></td>
                <td><asp:Button runat="server" ID="StaffLoginBtn" Text="Staff Login" OnClick="StaffLoginBtn_Click"></asp:Button></td>
            </tr>
        </table>
        <br/>
        <p><asp:Label runat="server" ID="Output"></asp:Label></p>
    </div>
    <hr/>
    <div>
        <h3>How to test services:</h3>
        <p>Users can test services by navigating to the respective pages from the Member Page. All services are listed with links in the service directory.</p>
        <p>The directory also includes test pages for the local component layer like Global.asax and DLL.</p>
        <hr/>
        <h3>Test cases and inputs:</h3>
        <ul>
            <li>Blah Service</li>
            <ul>
                <li>Blah test cases & inputs</li>
            </ul>
            <li>Blah Service</li>
            <ul>
                <li>Blah test cases & inputs</li>
            </ul>
            <li>Blah Service</li>
            <ul>
                <li>Blah test cases & inputs</li>
            </ul>
        </ul>
    </div>
</asp:Content>

<script language="c#" runat="server">
    void Page_Load(Object sender, EventArgs e)
    {
        
    }
</script>