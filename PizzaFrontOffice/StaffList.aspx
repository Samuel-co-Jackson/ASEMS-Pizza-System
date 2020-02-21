<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="StaffList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 225px; top: 309px; position: absolute"></asp:TextBox>
        </div>
        <asp:ListBox ID="lstStaff" runat="server" style="z-index: 1; left: 53px; top: 49px; position: absolute; height: 189px; width: 313px" OnSelectedIndexChanged="lstStaff_SelectedIndexChanged"></asp:ListBox>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 474px; top: 140px; position: absolute"></asp:Label>
        </p>
        <asp:Label ID="lblSearch" runat="server" style="z-index: 1; left: 60px; top: 312px; position: absolute" Text="Filter Staff by last name:"></asp:Label>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 107px; top: 369px; position: absolute; margin-bottom: 0px" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 228px; top: 369px; position: absolute" Text="Display All" OnClick="btnDisplayAll_Click" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 83px; top: 254px; position: absolute" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 188px; top: 255px; position: absolute" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 298px; top: 256px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
    </form>
</body>
</html>
