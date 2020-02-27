<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDelete.aspx.cs" Inherits="CustomerDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDeleteCustomer" runat="server" style="z-index: 1; left: 90px; top: 143px; position: absolute" Text="Are you sure you want to delete this customer?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 90px; top: 171px; position: absolute; width: 141px; right: 981px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 235px; top: 171px; position: absolute; width: 140px" Text="No" />
    </form>
</body>
</html>
