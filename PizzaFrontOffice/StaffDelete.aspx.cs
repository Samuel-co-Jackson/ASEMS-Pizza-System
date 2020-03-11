using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PizzaClasses;

public partial class AStaff : System.Web.UI.Page
{
    Int32 staffId;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        staffId = Convert.ToInt32(Session["staffId"]);
        if(IsPostBack == false)
        {
            DisplayRoles();
            if(staffId != -1)
            {
                DisplayStaff();
            }
        }
    }

    private void DisplayStaff()
    {
        clsStaffCollection StaffList = new clsStaffCollection();
        StaffList.ThisStaff.Find(staffId);
        ddlRole.SelectedIndex = StaffList.ThisStaff.staffRoleId;
        txtFirstName.Text = StaffList.ThisStaff.firstName;
        txtLastName.Text = StaffList.ThisStaff.lastName;
        txtDOB.Text = Convert.ToString(StaffList.ThisStaff.dateOfBirth);
        txtDOH.Text = Convert.ToString(StaffList.ThisStaff.dateOfHire);
        txtPostcode.Text = StaffList.ThisStaff.postCode;
        txtCity.Text = StaffList.ThisStaff.cityOfResidence;
        txtStreet.Text = StaffList.ThisStaff.streetName;
        txtHouseNo.Text = StaffList.ThisStaff.houseNumber;
        txtEmail.Text = StaffList.ThisStaff.contactEmail;
        txtPhone.Text = StaffList.ThisStaff.contactPhoneNo;
        chkHoliday.Checked = StaffList.ThisStaff.onHoliday;
    }

    private void DisplayRoles()
    {
        clsRoleCollection Roles = new clsRoleCollection();
        ddlRole.DataSource = Roles.allRoles;
        ddlRole.DataValueField = "roleId";
        ddlRole.DataTextField = "roleName";
        ddlRole.DataBind();
    }

    void DeleteStaff()
    {
        clsStaffCollection StaffList = new clsStaffCollection();
        StaffList.ThisStaff.Find(staffId);
        StaffList.Delete();
    }

    protected void btnSave_Click1(object sender, EventArgs e)
    {
        DeleteStaff();
        Response.Redirect("StaffList.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}