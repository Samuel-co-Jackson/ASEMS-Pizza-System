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
    </style>
</head>
<body style="width: 718px; height: 470px">
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 37px; top: 114px; position: absolute" Text="Customer ID"></asp:Label>
        <p>
            <asp:Label ID="lblStaffID" runat="server" style="z-index: 1; left: 40px; top: 77px; position: absolute; bottom: 766px" Text="Staff ID"></asp:Label>
        </p>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 38px; top: 155px; position: absolute" Text="Order Date"></asp:Label>
        <asp:Label ID="lblOrderStatus" runat="server" style="z-index: 1; left: 42px; top: 197px; position: absolute" Text="Order Status"></asp:Label>
        <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 137px; top: 74px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 143px; top: 113px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 140px; top: 154px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 17px; top: 251px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click1" style="z-index: 1; left: 63px; top: 309px; position: absolute; width: 112px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 201px; top: 310px; position: absolute; width: 113px" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:TextBox ID="txtOrderStatus" runat="server" style="z-index: 1; left: 143px; top: 195px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
