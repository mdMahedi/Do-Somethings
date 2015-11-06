<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UseRoles.aspx.cs" Inherits="MyWebsite.Registraton.UseRoles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 319px">
    
        Give a Role Name
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Create Role" />
        <br />
        <br />
        Chose User Name
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
&nbsp; Chose Role Name
        <asp:DropDownList ID="DropDownList2" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Add User in Role" OnClick="Button2_Click" />
        <br />
        <br />
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
    
    </div>
    </form>
</body>
</html>
