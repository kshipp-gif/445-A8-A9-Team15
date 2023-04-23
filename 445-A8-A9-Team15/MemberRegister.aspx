<%@ Page Language="C#" Title="Member Register" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MemberRegister.aspx.cs" Inherits="_445_A8_A9_Team15.MemberRegister" %>
<%@ Register tagPrefix="user" tagName="LoginControl" src="LoginControl.ascx" %>
<%@ Register tagPrefix="captcha" tagName="CaptchaControl" src="CaptchaControl.ascx" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Member Registration</h2>
    <table id="RegisterTable" runat="server">
        <tr>
            <td>User Name:</td>
            <td><asp:TextBox runat="server" ID="UsernameText"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Password:</td>
            <td><asp:TextBox runat="server" ID="PasswordText" TextMode="Password"></asp:TextBox></td>
        </tr>
    </table>
    <captcha:CaptchaControl runat="server" />
    <br/>
    <asp:TextBox runat="server" ID="CaptchaGuessText"></asp:TextBox>
    <table>
        <tr>
            <td></td>
            <td><asp:Button runat="server" ID="RegisterButton" Text="Register an Account" OnClick="RegisterButton_Click"></asp:Button></td>
            <td><asp:Button runat="server" ID="LoginBtn" Text="Login" OnClick="LoginBtn_Click"></asp:Button></td>
            <td><asp:Button runat="server" ID="HomeBtn" Text="Back Home" OnClick="HomeBtn_Click"></asp:Button></td>
        </tr>
    </table>
    <hr/>
    <p><asp:Label runat="server" ID="Output"></asp:Label></p>
</asp:Content>
