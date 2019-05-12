<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Final_Web.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <p>
        
            Username:&nbsp;
        
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        
            Password: &nbsp;
        
        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
    </p>


    <asp:Button ID="Button1" runat="server" Text="Log In" OnClick="Button1_Click" />

</asp:Content>
