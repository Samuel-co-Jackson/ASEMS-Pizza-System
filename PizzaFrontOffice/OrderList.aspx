<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="OrderList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 57px; top: 349px; position: absolute; margin-bottom: 0px" Text="Apply" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 128px; top: 351px; position: absolute" Text="Display All" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 64px; top: 406px; position: absolute" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 168px; top: 405px; position: absolute" Text="Delete" />
        <div>
        <asp:ListBox ID="lstOrder" runat="server" style="z-index: 1; left: 53px; top: 49px; position: absolute; height: 189px; width: 313px"></asp:ListBox>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 61px; top: 251px; position: absolute"></asp:Label>
        <asp:Label ID="lblOrderSearch" runat="server" style="z-index: 1; left: 61px; top: 301px; position: absolute; bottom: 542px;" Text="Please enter some order data:"></asp:Label>
        </div>
        <p>
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 116px; top: 405px; position: absolute" Text="Edit" />
        </p>
    </form>
</body>
</html>
