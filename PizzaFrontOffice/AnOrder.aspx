<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form2 {
            height: 294px;
        }
        #form3 {
            height: 294px;
        }
        .auto-style1 {
            z-index: 1;
            left: 516px;
            top: 462px;
            position: absolute;
        }
        .auto-style2 {
            z-index: 1;
            left: 707px;
            top: 386px;
            position: absolute;
            width: 113px;
        }
        .auto-style3 {
            z-index: 1;
            left: 515px;
            top: 387px;
            position: absolute;
            width: 112px;
        }
        .auto-style4 {
            z-index: 1;
            left: 655px;
            top: 316px;
            position: absolute;
            width: 169px;
        }
        .auto-style5 {
            z-index: 1;
            left: 657px;
            top: 276px;
            position: absolute;
            width: 166px;
        }
        .auto-style6 {
            z-index: 1;
            left: 658px;
            top: 227px;
            position: absolute;
            width: 163px;
        }
        .auto-style7 {
            z-index: 1;
            left: 656px;
            top: 180px;
            position: absolute;
            width: 167px;
        }
        .auto-style8 {
            z-index: 1;
            left: 534px;
            top: 322px;
            position: absolute;
        }
        .auto-style9 {
            z-index: 1;
            left: 536px;
            top: 277px;
            position: absolute;
        }
        .auto-style10 {
            z-index: 1;
            left: 532px;
            top: 230px;
            position: absolute;
        }
        .auto-style11 {
            z-index: 1;
            left: 557px;
            top: 184px;
            position: absolute;
            bottom: 659px;
        }
        .auto-style12 {
            position: absolute;
            top: 95px;
            left: 601px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: 27px;
            left: 606px;
            z-index: 1;
        }
        .auto-style15 {
            position: absolute;
            top: 141px;
            left: 922px;
            z-index: 1;
            width: 240px;
            height: 209px;
        }
    </style>
</head>
<body style="background-color:lightgrey">
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" CssClass="auto-style10" Font-Size="Large"></asp:Label>
        <p>
            <asp:Label ID="lblStaffID" runat="server" Text="Staff ID" CssClass="auto-style11" Font-Size="Large"></asp:Label>
        </p>
        <asp:Label ID="lblOrderDate" runat="server" Text="Order Date" CssClass="auto-style9" Font-Size="Large"></asp:Label>
        <asp:Label ID="lblOrderStatus" runat="server" Text="Order Status" CssClass="auto-style8" Font-Size="Large"></asp:Label>
        <asp:TextBox ID="txtStaffID" runat="server" CssClass="auto-style7"></asp:TextBox>
        <asp:TextBox ID="txtCustomerID" runat="server" CssClass="auto-style6"></asp:TextBox>
        <asp:TextBox ID="txtOrderDate" runat="server" CssClass="auto-style5"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" Text="[lblError]" CssClass="auto-style1" ForeColor="#FF3300"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click1" Text="OK" CssClass="auto-style3" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" CssClass="auto-style2" />
        <asp:TextBox ID="txtOrderStatus" runat="server" CssClass="auto-style4"></asp:TextBox>
        <asp:Label ID="lblAddEdit" runat="server" CssClass="auto-style12" Font-Size="XX-Large" ForeColor="#0066FF" Text="Add/Edit Order"></asp:Label>
        <p>
            <asp:Label ID="Label1" runat="server" CssClass="auto-style13" Font-Size="XX-Large" Text="ASEMS Pizza"></asp:Label>
        </p>
    </form>
    <img class="auto-style15" src="Images/pizza.png" />
</body>
</html>
