<%@ Page Title="Staff Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="_445_A8_A9_Team15.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Staff Login</h2>
    <table id="StaffLoginTable" runat="server">
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
            <td><asp:Button runat="server" ID="LoginBtn" Text="Log in" OnClick="LoginBtn_Click"/></td>
            <td><asp:CheckBox runat="server" ID="CookieCheckBox" Text="Remember me"/></td>
        </tr>
    </table>
    <asp:Label runat="server" ID="Output"></asp:Label>
</asp:Content>
