<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MenuList.aspx.cs" Inherits="MenuList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 85px;
            left: 61px;
            z-index: 1;
            width: 277px;
            height: 222px;
        }
        .auto-style2 {
            position: absolute;
            top: 315px;
            left: 62px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 344px;
            left: 64px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 378px;
            left: 66px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 417px;
            left: 59px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 418px;
            left: 129px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 463px;
            left: 56px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 464px;
            left: 98px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 464px;
            left: 140px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstMenu" runat="server" CssClass="auto-style1"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" CssClass="auto-style2"></asp:Label>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style3" Text="Please Enter a Pizza Name"></asp:Label>
        <asp:TextBox ID="txtPizzaName" runat="server" CssClass="auto-style4"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" CssClass="auto-style5" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplay" runat="server" CssClass="auto-style6" Text="Display" OnClick="btnDisplay_Click" />
        <asp:Button ID="btnAdd" runat="server" CssClass="auto-style7" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" CssClass="auto-style8" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" CssClass="auto-style9" Text="Delete" OnClick="btnDelete_Click" />
    </form>
</body>
</html>
