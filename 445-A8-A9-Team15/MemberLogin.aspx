<%@ Page Language="C#" Title="Member Login" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MemberLogin.aspx.cs" Inherits="_445_A8_A9_Team15.MemberLogin" %>
<%@ Register tagPrefix="user" tagName="LoginControl" src="LoginControl.ascx" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Member Login</h2>
    <user:LoginControl ID="MyLogin" BackColor="#ccccff" runat="server"/>
    <p>New user? Please <a href="MemberRegister.aspx">register here</a></p>
</asp:Content>