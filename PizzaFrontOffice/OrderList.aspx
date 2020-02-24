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
            top: 275px;
            position: absolute;
            bottom: 368px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 47px; top: 364px; position: absolute; margin-bottom: 0px; width: 82px;" Text="Apply" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 139px; top: 363px; position: absolute" Text="Display All" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 47px; top: 405px; position: absolute; width: 81px; height: 25px; right: 1382px;" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 232px; top: 404px; position: absolute; width: 85px;" Text="Delete" OnClick="btnDelete_Click" />
        <div>
        <asp:ListBox ID="lstOrder" runat="server" style="z-index: 1; left: 53px; top: 49px; position: absolute; height: 189px; width: 313px"></asp:ListBox>
            <asp:Label ID="lblError" runat="server" CssClass="auto-style1"></asp:Label>
        <asp:Label ID="lblOrderSearch" runat="server" Text="Please enter some order data:" CssClass="auto-style2"></asp:Label>
        </div>
        <p>
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 138px; top: 404px; position: absolute; width: 80px; right: 1292px;" Text="Edit" OnClick="btnEdit_Click" />
        </p>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtOrder" runat="server" style="position: relative; top: 200px; left: 47px; width: 206px"></asp:TextBox>
    </form>
</body>
</html>
