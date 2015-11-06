<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeRegistration.aspx.cs" Inherits="MyWebsite.Registraton.EmployeeRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <a href="../New.aspx">Home</a><br /><br />
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Employee ID "></asp:Label></td>
            <td>
                <asp:TextBox ID="txtID" runat="server"></asp:TextBox></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Employee Name "></asp:Label></td>
            <td>
                <asp:TextBox ID="txtEmpName" runat="server"></asp:TextBox></td>
            <td class="auto-style1">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Password "></asp:Label></td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            <td class="auto-style1">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Re-enter Password "></asp:Label></td>
            <td>
                <asp:TextBox ID="txtRePassword" runat="server" TextMode="Password"></asp:TextBox></td>
            <td class="auto-style1">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Email "></asp:Label></td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox></td>
            <td class="auto-style1">
                &nbsp;</td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Submit" Width="92px" OnClick="Button1_Click" /></td>
            <td class="auto-style1"></td>
        </tr>       
    </table>
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
