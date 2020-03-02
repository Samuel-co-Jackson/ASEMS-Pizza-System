<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 145px; top: 407px; position: absolute; width: 94px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 266px; top: 407px; position: absolute; width: 94px" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Label ID="lblFirstname" runat="server" style="z-index: 1; left: 101px; top: 77px; position: absolute; width: 94px" Text="Firstname:"></asp:Label>
        <asp:TextBox ID="txtFirstname" runat="server" style="z-index: 1; left: 210px; top: 78px; position: absolute; width: 155px; text-align: left"></asp:TextBox>
        <asp:Label ID="lblLastname" runat="server" style="z-index: 1; left: 100px; top: 115px; position: absolute; width: 94px" Text="Lastname:"></asp:Label>
        <asp:Label ID="lblPostcode" runat="server" style="z-index: 1; left: 96px; top: 255px; position: absolute; width: 94px" Text="Postcode:"></asp:Label>
        <asp:TextBox ID="txtPostcode" runat="server" style="z-index: 1; left: 205px; top: 258px; position: absolute; width: 155px"></asp:TextBox>
        <asp:Label ID="lblCity" runat="server" style="z-index: 1; left: 94px; top: 220px; position: absolute; width: 94px" Text="City:"></asp:Label>
        <asp:TextBox ID="txtCity" runat="server" style="z-index: 1; left: 207px; top: 221px; position: absolute; width: 155px"></asp:TextBox>
        <asp:TextBox ID="txtHouseNo" runat="server" style="z-index: 1; left: 208px; top: 150px; position: absolute; width: 155px"></asp:TextBox>
        <asp:Label ID="lblHouseNo" runat="server" style="z-index: 1; left: 98px; top: 149px; position: absolute; width: 94px" Text="House No:"></asp:Label>
        <asp:Label ID="lblStreetName" runat="server" style="z-index: 1; left: 96px; top: 186px; position: absolute; width: 94px" Text="Street Name:"></asp:Label>
        <asp:TextBox ID="txtStreetName" runat="server" style="z-index: 1; left: 207px; top: 186px; position: absolute; width: 155px"></asp:TextBox>
        <asp:Label ID="lblPhoneNo" runat="server" style="z-index: 1; left: 96px; top: 289px; position: absolute; width: 94px" Text="Phone No:"></asp:Label>
        <asp:TextBox ID="txtPhoneNo" runat="server" style="z-index: 1; left: 204px; top: 293px; position: absolute; width: 155px"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 204px; top: 327px; position: absolute; width: 155px"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 96px; top: 328px; position: absolute; width: 94px" Text="Email"></asp:Label>
        <asp:TextBox ID="txtLastname" runat="server" style="z-index: 1; left: 209px; top: 115px; position: absolute; width: 155px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 96px; top: 370px; position: absolute; width: 269px"></asp:Label>
    </form>
</body>
</html>
