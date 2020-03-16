<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblWelcome" runat="server" Font-Bold="True" Font-Size="XX-Large" style="z-index: 1; left: 225px; top: 61px; position: absolute" Text="Welcome to the ASEMS Pizza Management System!"></asp:Label>
        <asp:Button ID="btnStaff" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 166px; top: 182px; position: absolute; height: 72px; width: 202px" Text="Manage Staff" />
        <asp:Button ID="btnCustomer" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 447px; top: 302px; position: absolute; height: 72px; width: 265px" Text="Manage Customers" OnClick="btnCustomer_Click" />
        <asp:Button ID="btnOrder" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 777px; top: 413px; position: absolute; height: 72px; width: 206px" Text="Manage Orders" OnClick="btnOrder_Click" />
        <asp:Button ID="btnMenu" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 170px; top: 413px; position: absolute; height: 72px; width: 202px" Text="Manage Menu" />
        <asp:Button ID="btnStock" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 774px; top: 186px; position: absolute; height: 72px; width: 204px" Text="Manage Stock" OnClick="btnStock_Click" />
    </form>
</body>
</html>
