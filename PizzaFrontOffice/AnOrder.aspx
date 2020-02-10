<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style3 {
            position: relative;
            top: 5px;
            left: 23px;
        }
        .auto-style2 {
            position: absolute;
            top: 57px;
            left: 111px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <asp:Label ID="lblOrderID" runat="server" Text="Order ID"></asp:Label>
            <asp:TextBox ID="txtOrderID" runat="server" CssClass="auto-style1" style="position: relative; left: 43px; top: 5px"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblEmployeeID" runat="server" Text="EmployeeID"></asp:Label>
            <asp:TextBox ID="txtEmployeeID" runat="server" CssClass="auto-style3"></asp:TextBox>
        </p>
        <asp:Label ID="lblOrderDate" runat="server" Text="Order Date"></asp:Label>
        <asp:TextBox ID="txtOrderDate" runat="server" CssClass="auto-style4" style="position: relative; left: 29px; top: 2px"></asp:TextBox>
        <p>
            <asp:Label ID="lblOrderStatus" runat="server" Text="Order Status"></asp:Label>
            <asp:TextBox ID="txtOrderStatus" runat="server" CssClass="auto-style5" style="position: relative; left: 20px; top: 2px"></asp:TextBox>
        </p>
        <asp:Label ID="lblError" runat="server" CssClass="auto-style6" style="z-index: 1" Text="[lblError]"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" CssClass="auto-style2"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" CssClass="auto-style7" OnClick="btnOK_Click" style="position: relative; left: 0px; top: 0px; width: 75px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style8" style="position: relative; left: 23px; top: 0px; width: 73px" Text="Cancel" />
    </form>
</body>
</html>
