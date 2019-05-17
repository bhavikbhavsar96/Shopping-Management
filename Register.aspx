<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="FinalProject.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <h2>
    Register:</h2>
    <p>
        Username:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
    </p>
    <p>
        Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        Confirm Password:&nbsp;
        <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" ErrorMessage="Password doesn't match" ForeColor="#CC0000"></asp:CompareValidator>
    </p>
    <p>
        Role:
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="-1">Select a Role</asp:ListItem>
            <asp:ListItem>Member</asp:ListItem>
            <asp:ListItem>Admin</asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Required Field!!!" InitialValue="-1" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
    </p>
<p>
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
    </p>
    <p>
    <asp:Button ID="btnRegister" runat="server"  Text="Register" BackColor="White" Font-Bold="True" ForeColor="#336600" Height="37px"  Width="223px" BorderColor="Black" Font-Size="Medium" OnClick="btnRegister_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnCancel" runat="server"  Text="Cancel" BackColor="White" Font-Bold="True" ForeColor="#336600" Height="37px"  Width="223px" BorderColor="Black" Font-Size="Medium" CausesValidation="False" PostBackUrl="~/Admin/Default.aspx" ValidateRequestMode="Disabled" />
    </p>
</asp:Content>
