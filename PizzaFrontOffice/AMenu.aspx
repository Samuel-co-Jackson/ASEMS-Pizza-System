<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AMenu.aspx.cs" Inherits="AMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 37px; top: 107px; position: absolute" Text="Name"></asp:Label>
        <asp:Label ID="lblMenuID" runat="server" style="z-index: 1; left: 37px; top: 72px; position: absolute" Text="Menu ID"></asp:Label>
        <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 33px; top: 137px; position: absolute" Text="Description"></asp:Label>
        <asp:Label ID="lblRecipeID" runat="server" style="z-index: 1; left: 34px; top: 165px; position: absolute" Text="Recipe ID"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 36px; top: 193px; position: absolute" Text="Price"></asp:Label>
        <asp:TextBox ID="txtMenuID" runat="server" style="z-index: 1; left: 124px; top: 69px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 127px; top: 106px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 126px; top: 134px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtRecipe" runat="server" style="z-index: 1; left: 124px; top: 163px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 123px; top: 195px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 35px; top: 230px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 109px; top: 232px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
