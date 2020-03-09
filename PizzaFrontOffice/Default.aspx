<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 78px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="listBoxStock" runat="server" style="position: relative; top: 79px; left: 2px; height: 141px; width: 141px"></asp:ListBox>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="LabelEnterName" runat="server" style="position: relative" Text="Please enter an item name"></asp:Label>
        </p>
        <asp:TextBox ID="TextBoxEnterName" runat="server" style="position: relative"></asp:TextBox>
        <asp:Button ID="ButtonApply" runat="server" style="position: relative; top: 46px; left: -127px; width: 90px" Text="Apply" />
        <asp:Button ID="ButtonDisplayAll" runat="server" style="position: relative; top: 47px; left: -112px; width: 90px" Text="Display All" />
        <asp:Button ID="ButtonAdd" runat="server" style="position: relative; top: 92px; left: -304px" Text="Add" />
        <asp:Button ID="ButtonEdit" runat="server" style="z-index: 1; left: 67px; top: 401px; position: absolute" Text="Edit" />
        <asp:Button ID="ButtonDelete" runat="server" style="z-index: 1; left: 119px; top: 400px; position: absolute" Text="Delete" />
    </form>

    </body>
</html>
