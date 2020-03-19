<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDelete.aspx.cs" Inherits="StockDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:whitesmoke;">
    <form id="form1" runat="server">
        <div>
        </div>
        <br />
        <br />
        <p>
            <asp:Label ID="LabelDelete" runat="server" Text="Are you sure you want to delete the following item?"></asp:Label>
        </p>
        <asp:Button ID="ButtonYes" runat="server" OnClick="ButtonYes_Click" style="z-index: 1; left: 35px; top: 150px; position: absolute; width: 45px;" Text="Yes" BackColor="White" BorderColor="Black" />
        <asp:Button ID="ButtonNo" runat="server" style="z-index: 1; left: 100px; top: 150px; position: absolute; width: 45px;" Text="No" BackColor="White" BorderColor="Black" OnClick="ButtonNo_Click" />
    </form>
</body>
</html>
