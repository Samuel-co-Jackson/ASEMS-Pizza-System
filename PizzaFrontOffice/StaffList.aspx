<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="StaffList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaff" runat="server" style="z-index: 1; left: 53px; top: 49px; position: absolute; height: 189px; width: 313px"></asp:ListBox>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 61px; top: 251px; position: absolute"></asp:Label>
        </p>
        <asp:Label ID="lblSearch" runat="server" style="z-index: 1; left: 61px; top: 301px; position: absolute" Text="Please enter some search data:"></asp:Label>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 57px; top: 349px; position: absolute; margin-bottom: 0px" Text="Apply" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 141px; top: 347px; position: absolute" Text="Display All" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 60px; top: 403px; position: absolute" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 127px; top: 401px; position: absolute" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 212px; top: 400px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
    </form>
</body>
</html>
