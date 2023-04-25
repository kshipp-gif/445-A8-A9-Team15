<%@ Page Language="C#" Title="Member Login" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MemberLogin.aspx.cs" Inherits="_445_A8_A9_Team15.MemberLogin" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Member Login</h2>
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
            <td><asp:CheckBox runat="server" ID="CookieCheckBox" Text="Remember me"/></td>

        </tr>
    </table>
    <hr/>
    <p><asp:Label runat="server" ID="Output"></asp:Label></p>
    <p>New user? Please <a href="MemberRegister.aspx">register here</a></p>
</asp:Content>