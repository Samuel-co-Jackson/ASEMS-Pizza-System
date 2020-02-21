﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStaff.aspx.cs" Inherits="AStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 506px;
            left: 629px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 386px; top: 48px; position: absolute; height: 19px" Text="ASEMS Pizza - Employee Record"></asp:Label>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 51px; top: 162px; position: absolute; bottom: 514px;" Text="First name:"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 51px; top: 200px; position: absolute" Text="Last name:"></asp:Label>
        <asp:Label ID="lblRole" runat="server" style="z-index: 1; left: 746px; top: 162px; position: absolute" Text="ASEMS Pizza role:"></asp:Label>
        <asp:DropDownList ID="ddlRole" runat="server" style="z-index: 1; left: 900px; top: 162px; position: absolute; bottom: 313px; width: 78px;" TabIndex="9">
        </asp:DropDownList>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 146px; top: 200px; position: absolute" TabIndex="2"></asp:TextBox>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 146px; top: 162px; position: absolute" TabIndex="1"></asp:TextBox>
        <p>
            <asp:Button ID="btnSave" runat="server" style="z-index: 1; left: 470px; top: 386px; position: absolute" Text="Save" OnClick="btnSave_Click1" TabIndex="12" />
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 876px; top: 402px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style1"></asp:Label>
        <asp:Label ID="lblDOB" runat="server" style="z-index: 1; left: 51px; top: 238px; position: absolute" Text="Date of birth:"></asp:Label>
        <asp:Label ID="lblDOH" runat="server" style="z-index: 1; left: 51px; top: 276px; position: absolute" Text="Date of hire:"></asp:Label>
        <asp:Label ID="lblPostcode" runat="server" style="z-index: 1; left: 376px; top: 276px; position: absolute" Text="Postcode:"></asp:Label>
        <asp:Label ID="lblCity" runat="server" style="z-index: 1; left: 376px; top: 162px; position: absolute" Text="City of residence:"></asp:Label>
        <asp:Label ID="lblStreet" runat="server" style="z-index: 1; left: 376px; top: 200px; position: absolute" Text="Street name:"></asp:Label>
        <asp:Label ID="lblHouseNo" runat="server" style="z-index: 1; left: 376px; top: 238px; position: absolute" Text="House number:"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 746px; top: 200px; position: absolute" Text="Contact email:"></asp:Label>
        <asp:Label ID="lblPhone" runat="server" style="z-index: 1; left: 746px; top: 238px; position: absolute" Text="Phone number:"></asp:Label>
        <asp:Label ID="lblHoliday" runat="server" style="z-index: 1; left: 746px; top: 276px; position: absolute" Text="On holiday:"></asp:Label>
        <asp:TextBox ID="txtDOB" runat="server" style="z-index: 1; left: 146px; top: 238px; position: absolute" TabIndex="3"></asp:TextBox>
        <asp:TextBox ID="txtDOH" runat="server" style="z-index: 1; left: 146px; top: 276px; position: absolute" TabIndex="4"></asp:TextBox>
        <asp:Button ID="btnSetDate" runat="server" style="z-index: 1; left: 146px; top: 310px; position: absolute; width: 128px; height: 22px;" Text="Set to today" OnClick="btnSetDate_Click" />
        <asp:TextBox ID="txtCity" runat="server" style="z-index: 1; left: 507px; top: 161px; position: absolute" TabIndex="5"></asp:TextBox>
        <asp:TextBox ID="txtStreet" runat="server" style="z-index: 1; left: 507px; top: 200px; position: absolute" TabIndex="6"></asp:TextBox>
        <asp:TextBox ID="txtHouseNo" runat="server" style="z-index: 1; left: 507px; top: 238px; position: absolute" TabIndex="7"></asp:TextBox>
        <asp:TextBox ID="txtPostcode" runat="server" style="z-index: 1; left: 507px; top: 276px; position: absolute" TabIndex="8"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 900px; top: 200px; position: absolute" TabIndex="10"></asp:TextBox>
        <asp:TextBox ID="txtPhone" runat="server" style="z-index: 1; left: 900px; top: 238px; position: absolute" TabIndex="11"></asp:TextBox>
        <asp:CheckBox ID="chkHoliday" runat="server" style="z-index: 1; left: 900px; top: 276px; position: absolute" TabIndex="12" />
    </form>
</body>
</html>
