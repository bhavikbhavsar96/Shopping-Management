<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FinalProject.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <h2>Login</h2>
<p>
    Username:
    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
&nbsp;</p>
<p>
    Password:&nbsp;
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
</p>
<p>
    <asp:CheckBox ID="chkRememberMe" runat="server" Checked="True" Text="Remember Me" />
&nbsp;</p>
<p>
    <asp:Button ID="btnLogin" runat="server"  Text="Login" BackColor="White" Font-Bold="True" ForeColor="#336600" Height="37px" OnClick="btnLogin_Click1" Width="223px" BorderColor="Black" Font-Size="Medium" />
</p>
<p>
    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
</p>
</asp:Content>
