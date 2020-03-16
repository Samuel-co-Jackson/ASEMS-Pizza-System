<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="OrderList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 44px;
            top: 468px;
            position: absolute;
        }
        .auto-style2 {
            z-index: 1;
            left: 57px;
            top: 277px;
            position: absolute;
            bottom: 558px;
        }
        .auto-style3 {
            position: absolute;
            top: 58px;
            left: 52px;
            z-index: 1;
            width: 288px;
            height: 190px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 47px; top: 364px; position: absolute; margin-bottom: 0px; width: 82px;" Text="Apply" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 139px; top: 363px; position: absolute" Text="Display All" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 44px; top: 405px; position: absolute; width: 100px; height: 42px; right: 1161px;" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 267px; top: 401px; position: absolute; width: 104px; height: 42px;" Text="Delete" OnClick="btnDelete_Click" />
        <div>
            <asp:Label ID="lblError" runat="server" CssClass="auto-style1"></asp:Label>
        <asp:Label ID="lblOrderSearch" runat="server" Text="Please enter some order data:" CssClass="auto-style2"></asp:Label>
        </div>
        <p>
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 161px; top: 403px; position: absolute; width: 80px; right: 1064px; height: 42px;" Text="Edit" OnClick="btnEdit_Click" />
        </p>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtOrder" runat="server" style="position: absolute; top: 318px; left: 49px; width: 206px; z-index: 1;"></asp:TextBox>
        <asp:ListBox ID="lstOrder" runat="server" CssClass="auto-style3"></asp:ListBox>
    </form>
</body>
</html>
