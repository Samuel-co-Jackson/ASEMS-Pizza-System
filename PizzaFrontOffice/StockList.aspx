<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="StockList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:whitesmoke;">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="ListBoxStock" runat="server" style="height: 160px; width: 160px; position: relative; top: 75px; left: 25px" OnSelectedIndexChanged="ListBoxStock_SelectedIndexChanged" BackColor="White"></asp:ListBox>
        <asp:Button ID="ButtonDisplayStock" runat="server" style="z-index: 1; left: 25px; top: 285px; position: absolute" Text="Display Stock" OnClick="ButtonDisplayStock_Click" BackColor="White" BorderColor="Black" />
        <asp:Button ID="ButtonAdd" runat="server" OnClick="ButtonAdd_Click" style="z-index: 1; left: 25px; top: 390px; position: absolute" Text="Add" BackColor="White" BorderColor="Black" />
        <asp:Button ID="ButtonDelete" runat="server" OnClick="ButtonDelete_Click" style="z-index: 1; left: 80px; top: 390px; position: absolute;" Text="Delete" BackColor="White" BorderColor="Black" />
        <asp:Button ID="ButtonEdit" runat="server" OnClick="ButtonEdit_Click" style="z-index: 1; left: 150px; top: 390px; position: absolute" Text="Edit" BackColor="White" BorderColor="Black" />
        <p>
        <asp:Label ID="LabelError" runat="server" style="z-index: 1; left: 25px; top: 564px; position: absolute" Text="[lblError]" Font-Bold="True"></asp:Label>
        </p>
        
        <asp:TextBox ID="TextBoxSearch" runat="server" style="position: relative; top: 74px; left: 17px" BackColor="White" BorderColor="Black"></asp:TextBox>
        <asp:Button ID="ButtonApply" runat="server" OnClick="ButtonApply_Click" style="z-index: 1; left: 135px; top: 285px; position: absolute" Text="Apply" BackColor="White" BorderColor="Black" />
        
        <asp:Label ID="LabelTitle" runat="server" Font-Bold="True" style="position: absolute; top: 15px; left: 25px" Text="ASEMS Pizza" BackColor="White" BorderColor="Black" Font-Size="20pt"></asp:Label>
        
        <asp:Label ID="LabelSubTitle" runat="server" Font-Bold="True" style="position: absolute; top: 45px; left: 25px" Font-Size="15pt" Text="Stock List"></asp:Label>
        
    </form>
</body>
</html>
