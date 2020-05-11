<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Index.aspx.vb" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 510px;
        }
    </style>
</head>
<body>
    <form runat="server">

    
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Button" />
    <asp:Image ID="Image1" runat="server" />

    <table style="width: 100%;">
        <tr>
            <td class="auto-style1">
                Title</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Objects</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Tags</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Brands</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Celebrities</td>
            <td>&nbsp;</td>
        </tr>
    </table>
        </form>
</body>
</html>
