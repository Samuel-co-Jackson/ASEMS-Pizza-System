<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStock.aspx.cs" Inherits="AStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:whitesmoke;">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="LabelName" runat="server" style="z-index: 1; left: 16px; top: 195px; position: absolute" Text="Item Name"></asp:Label>
        <asp:Label ID="LabelDescription" runat="server" style="position: absolute; z-index: 1; left: 16px; top: 234px" Text="Description"></asp:Label>
        <asp:Label ID="LabelQuantity" runat="server" style="z-index: 1; left: 16px; top: 271px; position: absolute" Text="Quantity"></asp:Label>
        <asp:Label ID="LabelPrice" runat="server" style="z-index: 1; left: 17px; top: 314px; position: absolute" Text="Price"></asp:Label>
        <asp:Label ID="LabelError" runat="server" style="z-index: 1; left: 15px; top: 564px; position: absolute" Text="[lblError]" Font-Bold="True"></asp:Label>
        <asp:TextBox ID="TextBoxName" runat="server" style="z-index: 1; left: 101px; top: 196px; position: absolute" BackColor="White" BorderColor="Black"></asp:TextBox>
        <asp:TextBox ID="TextBoxDescription" runat="server" style="z-index: 1; left: 101px; top: 234px; position: absolute; bottom: 408px;" BackColor="White" BorderColor="Black"></asp:TextBox>
        <asp:TextBox ID="TextBoxQuantity" runat="server" style="z-index: 1; left: 101px; top: 272px; position: absolute; bottom: 370px;" BackColor="White" BorderColor="Black"></asp:TextBox>
        <asp:TextBox ID="TextBoxPrice" runat="server" style="z-index: 1; left: 101px; top: 312px; position: absolute" BackColor="White" BorderColor="Black"></asp:TextBox>
        <asp:Button ID="ButtonOK" runat="server" OnClick="ButtonOK_Click" style="z-index: 1; left: 35px; top: 605px; position: absolute; width: 39px;" Text="Ok" BackColor="White" BorderColor="Black" />
        <asp:Button ID="ButtonCancel" runat="server" style="z-index: 1; left: 101px; top: 605px; position: absolute" Text="Cancel" BackColor="White" BorderColor="Black" />
    </form>
</body>
</html>
