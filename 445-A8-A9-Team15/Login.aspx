<%@ Page Title="Staff Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="_445_A8_A9_Team15.Login" %>
<%@ Register tagPrefix="user" tagName="LoginControl" src="LoginControl.ascx" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Staff Login</h2>
    <user:LoginControl ID="MyLogin" BackColor="#ccccff" runat="server"/>
</asp:Content>
