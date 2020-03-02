<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MenuDelete.aspx.cs" Inherits="MenuDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 147px;
            left: 100px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 179px;
            left: 98px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 179px;
            left: 141px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblQuestion" runat="server" CssClass="auto-style1" Text="Are you sure you want to delete this Menu item?"></asp:Label>
        <p>
            <asp:Button ID="btnYes" runat="server" CssClass="auto-style2" OnClick="btnYes_Click" Text="Yes" />
        </p>
        <asp:Button ID="btnNo" runat="server" CssClass="auto-style3" OnClick="btnNo_Click" Text="No" />
    </form>
</body>
</html>
