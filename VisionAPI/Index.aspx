<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Index.aspx.vb" Inherits="VisionAPI.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #339933;
            font-size: xx-large;
        }
        .auto-style2 {
            width: 528px;
            font-weight: bold;
            font-style: italic;
            text-decoration: underline;
            color: #FF6666;
            font-size: large;
        }
        .auto-style3 {
            width: 528px;
        }
        .auto-style4 {
            font-size: x-large;
        }
        .auto-style5 {
            background-color: #FFFFFF;
        }
        .auto-style6 {
            font-size: x-large;
            color: #006600;
        }
        .auto-style7 {
            color: #006600;
            background-color: #FFFFFF;
        }
        .auto-style8 {
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form runat="server">

    
    <table style="width: 100%;" border="1">
        <tr>
            <td class="auto-style1" colspan="2">
                <span class="auto-style4"><strong><span class="auto-style7">Infosys MS Azure Hackathon Experiment - Image Analysis using Vision APIs - A Step towards </span></strong></span><span class="auto-style6" style="font-family: Calibri; mso-ascii-font-family: Calibri; mso-fareast-font-family: Calibri; mso-bidi-font-family: Arial; font-variant: normal; text-transform: none; letter-spacing: 0pt; language: en-US; font-style: normal; vertical-align: baseline; mso-text-raise: 0%"><strong><span class="auto-style5">Internet of Recognition (Real Time Events Recognition)</span></strong></span></td>
            <td rowspan="7">

    
    <asp:Image ID="Image1" runat="server" Height="500px" Width="500px" ImageAlign="Middle" />

            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                    <asp:ListItem>Select Image Type From Storage</asp:ListItem>
                    <asp:ListItem>Traffic Accident</asp:ListItem>
                    <asp:ListItem>Celebrities</asp:ListItem>
                    <asp:ListItem>Violence</asp:ListItem>
                    <asp:ListItem>Guns</asp:ListItem>
                    <asp:ListItem>Brands</asp:ListItem>
                    <asp:ListItem>Mix</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>

    
    <asp:TextBox ID="TextBox1" runat="server" Width="632px"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Analyse" CssClass="auto-style8" Width="99px" />
            &nbsp;<br />
                <br />
                (You can enter a full URL manually as well and click Analyse)</td>
        </tr>
        <tr>
            <td class="auto-style2">
                Title</td>
            <td>
                <asp:Label ID="lbltitle" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Objects</td>
            <td>
                <asp:Label ID="lblObjects" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Tags</td>
            <td>
                <asp:Label ID="lblTags" runat="server" Text="Label" Visible="False"></asp:Label>
                <br />
                <br />
                <asp:Label ID="lblGuns" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Brands</td>
            <td>
                <asp:Label ID="lblBrands" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Celebrities</td>
            <td>
                <asp:Label ID="lblCelebs" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
        </tr>
    </table>
        </form>
</body>
</html>
