<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDelete.aspx.cs" Inherits="StockDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="LabelDelete" runat="server" Text="Are you sure you want to delete the following item?"></asp:Label>
        </p>
        <asp:Button ID="ButtonYes" runat="server" OnClick="ButtonYes_Click" style="z-index: 1; left: 35px; top: 35px; position: relative; width: 45px;" Text="Yes" Height="26px" />
        <p>
            &nbsp;</p>
        <asp:Button ID="ButtonNo" runat="server" style="z-index: 1; left: 122px; top: 162px; position: absolute; height: 28px; width: 45px; margin-top: 0px" Text="No" />
    </form>
</body>
</html>
