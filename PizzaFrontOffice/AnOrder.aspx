<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 13px;
            left: 105px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 54px;
            left: 105px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 86px;
            left: 105px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 125px;
            left: 109px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 166px;
            left: 109px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 190px;
            left: 0px;
        }
        .auto-style7 {
            position: absolute;
            top: 231px;
            left: 3px;
            z-index: 1;
            width: 67px;
        }
        .auto-style8 {
            position: absolute;
            top: 231px;
            left: 93px;
            z-index: 1;
            width: 86px;
        }
    </style>
</head>
<body style="position: relative; left: 3px; top: 3px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderID" runat="server" Text="Order ID"></asp:Label>
            <asp:TextBox ID="txtOrderID" runat="server" CssClass="auto-style1"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblEmployeeID" runat="server" Text="EmployeeID"></asp:Label>
        </p>
        <asp:Label ID="lblOrderDate" runat="server" Text="Order Date"></asp:Label>
        <p>
            <asp:Label ID="lblOrderStatus" runat="server" Text="Order Status"></asp:Label>
        </p>
        <asp:TextBox ID="txtCustomerID" runat="server" CssClass="auto-style2"></asp:TextBox>
        <asp:TextBox ID="txtEmployeeID" runat="server" CssClass="auto-style3"></asp:TextBox>
        <asp:TextBox ID="txtOrderDate" runat="server" CssClass="auto-style4"></asp:TextBox>
        <asp:TextBox ID="txtOrderStatus" runat="server" CssClass="auto-style5"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" CssClass="auto-style6" style="z-index: 1" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnOK" runat="server" CssClass="auto-style7" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style8" Text="Cancel" />
    </form>
</body>
</html>
