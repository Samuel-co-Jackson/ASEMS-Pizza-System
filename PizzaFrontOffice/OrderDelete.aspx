<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDelete.aspx.cs" Inherits="OrderDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 195px;
            left: 447px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 273px;
            left: 516px;
            z-index: 1;
            width: 119px;
            height: 37px;
        }
        .auto-style3 {
            position: absolute;
            top: 271px;
            left: 703px;
            z-index: 1;
            width: 119px;
            height: 37px;
        }
        .auto-style12 {
            position: absolute;
            top: 33px;
            left: 566px;
            z-index: 1;
        }
        .auto-style13 {
            width: 226px;
            height: 229px;
            position: absolute;
            left: 975px;
            top: 54px;
            z-index: 1;
        }
    </style>
</head>
<body style="background-color:lightgrey">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDelete" runat="server" CssClass="auto-style1" Text="Are you sure you would like to DELETE this order?" Font-Size="X-Large" ForeColor="#FF3300"></asp:Label>
        <asp:Button ID="btnYes" runat="server" CssClass="auto-style2" OnClick="btnYes_Click" Text="YES" Font-Size="Large" />
        <asp:Button ID="btnNo" runat="server" CssClass="auto-style3" Text="Cancel" Font-Size="Large" />
        <p>
            <asp:Label ID="Label1" runat="server" CssClass="auto-style12" Font-Size="XX-Large" Text="ASEMS Pizza"></asp:Label>
        </p>
    </form>
    <img class="auto-style13" src="Images/pizza.png" />
</body>
</html>
