<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="StockList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="ListBoxStock" runat="server" style="height: 142px; width: 142px; position: relative; top: 76px; left: 9px"></asp:ListBox>
        <asp:Button ID="ButtonDisplayStock" runat="server" style="position: relative; top: 144px; left: -126px" Text="Display Stock" OnClick="ButtonDisplayStock_Click" />
        <asp:Button ID="ButtonAdd" runat="server" OnClick="ButtonAdd_Click" style="z-index: 1; left: 26px; top: 335px; position: absolute" Text="Add" />
        <asp:Button ID="ButtonDelete" runat="server" OnClick="ButtonDelete_Click" style="z-index: 1; left: 131px; top: 336px; position: absolute" Text="Delete" />
        <p>
        <asp:Label ID="LabelError" runat="server" style="z-index: 1; left: 15px; top: 564px; position: absolute" Text="[lblError]"></asp:Label>
        </p>
        <asp:Button ID="ButtonEdit" runat="server" OnClick="ButtonEdit_Click" style="position: relative; top: 103px; left: 68px" Text="Edit" />
    </form>
</body>
</html>
