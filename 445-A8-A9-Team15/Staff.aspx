<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="JoseRequiredServicesTryItPage.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Welcome to the Staff & Admin Page!</h2>
            <p>
                
                Please enter the username and password of the user you want to add to the Staff page access:<br /><br />
                <asp:Label runat="server" Text="Username"></asp:Label><asp:TextBox runat="server" ID="usernameInput"></asp:TextBox><br /><br />
                <asp:Label runat="server" Text="Password"></asp:Label><asp:TextBox runat="server" ID="passwordInput"></asp:TextBox><br /><br />
                <asp:Button runat="server" Text="Add User to Staff" OnClick="Unnamed5_Click"/>
            </p>
        </div>
        <div>
            <%-- Area for displaying current Staff Accounts --%>
            <p>
                Below is a display of the current Staff Members:<br />
            </p>
            <br />
            <asp:GridView ID="GridView1" runat="server" Width="395px" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="username" HeaderText="username" SortExpression="username" />
                    <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
                </Columns>
            </asp:GridView>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
