<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AMenu.aspx.cs" Inherits="AMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 34px;
            top: 251px;
            position: absolute;
        }
        .auto-style2 {
            z-index: 1;
            left: 85px;
            top: 251px;
            position: absolute;
        }
        .auto-style3 {
            position: absolute;
            top: 224px;
            left: 34px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 37px; top: 107px; position: absolute" Text="Name"></asp:Label>
        <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 33px; top: 137px; position: absolute" Text="Description"></asp:Label>
        <asp:Label ID="lblRecipeID" runat="server" style="z-index: 1; left: 34px; top: 165px; position: absolute" Text="Recipe ID"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 36px; top: 193px; position: absolute" Text="Price"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 127px; top: 106px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 126px; top: 134px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtRecipe" runat="server" style="z-index: 1; left: 124px; top: 163px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 123px; top: 195px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" CssClass="auto-style1" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="auto-style2" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style3"></asp:Label>
    </form>
</body>
</html>
