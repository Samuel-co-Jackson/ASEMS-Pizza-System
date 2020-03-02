<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDelete.aspx.cs" Inherits="OrderDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 61px;
            left: 22px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 118px;
            left: 46px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 118px;
            left: 143px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style1" Text="Are you sure you would like to DELETE this order?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" CssClass="auto-style2" OnClick="btnYes_Click" Text="YES" />
        <asp:Button ID="btnNo" runat="server" CssClass="auto-style3" Text="NO" />
    </form>
</body>
</html>
