<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UseStateVariable.aspx.cs" Inherits="MyWebsite.Cookie.UseStateVariable" %>

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
                <asp:Label ID="lblFname" runat="server" Text="First Name"></asp:Label></td>
            <td>
                <asp:TextBox ID="fname" runat="server"></asp:TextBox></td>
            
        </tr>
        <tr>
            <td><asp:Label ID="Label1" runat="server" Text="Last Name"></asp:Label></td>
            <td>
                <asp:TextBox ID="lname" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Save" Width="90px" OnClick="Button1_Click" /></td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
