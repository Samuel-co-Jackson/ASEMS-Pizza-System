<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDelete.aspx.cs" Inherits="StaffDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 84px; top: 112px; position: absolute" Text="Are you sure you want to delete this staff member?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 128px; top: 155px; position: absolute" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 223px; top: 156px; position: absolute" Text="No" />
    </form>
</body>
</html>
