<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomers" runat="server" style="z-index: 1; left: 71px; top: 45px; position: absolute; height: 257px; width: 302px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 71px; top: 426px; position: absolute; width: 100px" Text="Add" OnClick="btnAdd_Click" />
        <asp:Label ID="lblEnterPostcode" runat="server" style="z-index: 1; left: 76px; top: 317px; position: absolute; width: 293px; text-align: left" Text="Please Enter A Customers Postcode:"></asp:Label>
        <asp:TextBox ID="txtEnterPostcode" runat="server" style="z-index: 1; left: 72px; top: 343px; position: absolute; width: 302px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 73px; top: 391px; position: absolute; width: 151px" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 229px; top: 391px; position: absolute; width: 151px" Text="Display All" OnClick="btnDisplayAll_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 281px; top: 426px; position: absolute; width: 100px" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 176px; top: 426px; position: absolute; width: 100px" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 73px; top: 467px; position: absolute; width: 309px"></asp:Label>
    </form>
</body>
</html>
