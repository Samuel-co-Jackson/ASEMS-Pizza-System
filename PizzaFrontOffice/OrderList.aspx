<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="OrderList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 430px;
            top: 633px;
            position: absolute;
        }
        .auto-style3 {
            position: absolute;
            top: 185px;
            left: 441px;
            z-index: 1;
            width: 288px;
            height: 190px;
        }
        .auto-style4 {
            z-index: 1;
            left: 583px;
            top: 563px;
            position: absolute;
            width: 98px;
            height: 42px;
        }
        .auto-style5 {
            z-index: 1;
            left: 734px;
            top: 561px;
            position: absolute;
            width: 104px;
            height: 42px;
        }
        .auto-style6 {
            z-index: 1;
            left: 272px;
            top: 549px;
            position: relative;
            width: 100px;
            height: 42px;
            right: -272px;
        }
        .auto-style7 {
            z-index: 1;
            left: 621px;
            top: 473px;
            position: relative;
            height: 41px;
            width: 149px;
        }
        .auto-style8 {
            position: absolute;
            top: 130px;
            left: 527px;
            z-index: 1;
        }
        .auto-style9 {
            z-index: 1;
            left: 435px;
            top: 490px;
            position: absolute;
            width: 123px;
            height: 40px;
            right: 952px;
        }
        .auto-style10 {
            position: absolute;
            top: 430px;
            left: 439px;
            width: 242px;
            z-index: 1;
            height: 29px;
        }
        .auto-style11 {
            z-index: 1;
            left: 439px;
            top: 395px;
            position: absolute;
        }
        .auto-style12 {
            position: absolute;
            top: 27px;
            left: 488px;
            z-index: 1;
        }
        .auto-style13 {
            width: 226px;
            height: 229px;
            position: absolute;
            left: 847px;
            top: 95px;
            z-index: 1;
        }
    </style>
</head>
<body style="background-color:lightgrey">
    <form id="form1" runat="server">
        <asp:Button ID="btnApply" runat="server" style="margin-bottom: 0px; " Text="Apply" OnClick="btnApply_Click" BackColor="#66CCFF" CssClass="auto-style9" />
        <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" CssClass="auto-style7" OnClick="btnDisplayAll_Click" BackColor="#66CCFF" />
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" CssClass="auto-style6" BackColor="#66CCFF" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" CssClass="auto-style5" BackColor="#66CCFF" />
        <div>
            <asp:Label ID="lblError" runat="server" CssClass="auto-style1" ForeColor="#FF3300"></asp:Label>
        </div>
        <p>
        <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" CssClass="auto-style4" BackColor="#66CCFF" />
        </p>
        <p>
            <img class="auto-style13" src="Images/pizza.png" /></p>
        <asp:TextBox ID="txtOrder" runat="server" CssClass="auto-style10"></asp:TextBox>
        <asp:ListBox ID="lstOrder" runat="server" CssClass="auto-style3"></asp:ListBox>
        <asp:Label ID="lblOrderStatus" runat="server" Text="Please enter an order status:" CssClass="auto-style11"></asp:Label>
        <asp:Label ID="lblTitle" runat="server" CssClass="auto-style8" Font-Size="X-Large" ForeColor="#0066FF" Text="Order Page"></asp:Label>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style12" Font-Size="XX-Large" Text="ASEMS Pizza"></asp:Label>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
