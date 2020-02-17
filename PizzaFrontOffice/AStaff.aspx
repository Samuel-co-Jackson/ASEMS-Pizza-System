<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStaff.aspx.cs" Inherits="AStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 325px;
            left: 81px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 61px; top: 54px; position: absolute; height: 19px" Text="ASEMS Pizza - Add or Update Staff"></asp:Label>
        <asp:Label ID="lblDetails" runat="server" style="z-index: 1; left: 59px; top: 132px; position: absolute" Text="Staff Member Details:"></asp:Label>
        <asp:Label ID="lblNotices" runat="server" style="z-index: 1; left: 394px; top: 135px; position: absolute" Text="Staff Member Notices:"></asp:Label>
        <asp:Label ID="lblDelete" runat="server" style="z-index: 1; left: 653px; top: 135px; position: absolute" Text="Delete Staff Member:"></asp:Label>
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 84px; top: 174px; position: absolute" Text="Employee's Name:"></asp:Label>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 81px; top: 213px; position: absolute" Text="Employee's Address:"></asp:Label>
        <asp:Label ID="lblRole" runat="server" style="z-index: 1; left: 84px; top: 256px; position: absolute" Text="Employee's Role:"></asp:Label>
        <asp:DropDownList ID="ddlRole" runat="server" style="z-index: 1; left: 221px; top: 254px; position: absolute">
        </asp:DropDownList>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 241px; top: 214px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 229px; top: 175px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtNotices" runat="server" style="z-index: 1; left: 395px; top: 170px; position: absolute; height: 97px; width: 296px; margin-top: 11px"></asp:TextBox>
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 750px; top: 179px; position: absolute; height: 58px; width: 168px" Text="Press here to Delete" />
        <p>
            <asp:Button ID="btnSave" runat="server" style="z-index: 1; left: 492px; top: 346px; position: absolute" Text="Save" OnClick="btnSave_Click1" />
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 824px; top: 345px; position: absolute" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style1"></asp:Label>
    </form>
</body>
</html>
