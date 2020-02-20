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
            //DisplayRoles(); FILL IN THE ROLES
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

    protected void btnSave_Click1(object sender, EventArgs e)
    {
        if(staffId == -1)
        {
            Add();
        }
        else
        {
            Update();
        }
    }

    //function for adding new staff records

    void Add()
    {
        clsStaffCollection StaffList = new clsStaffCollection();
        String Error = ""; //StaffList.Valid(txtName.Text, txtAddress.Text, txtNotices.Text);
        if(Error == "")
        {
            StaffList.ThisStaff.staffRoleId = ddlRole.SelectedIndex;
            StaffList.ThisStaff.firstName = txtFirstName.Text;
            StaffList.ThisStaff.lastName = txtLastName.Text;
            StaffList.ThisStaff.dateOfBirth = Convert.ToDateTime(txtDOB.Text);
            StaffList.ThisStaff.dateOfHire = Convert.ToDateTime(txtDOH.Text);
            StaffList.ThisStaff.postCode = txtPostcode.Text;
            StaffList.ThisStaff.cityOfResidence = txtCity.Text;
            StaffList.ThisStaff.streetName = txtStreet.Text;
            StaffList.ThisStaff.houseNumber = txtHouseNo.Text;
            StaffList.ThisStaff.contactEmail = txtEmail.Text;
            StaffList.ThisStaff.contactPhoneNo = txtPhone.Text;
            StaffList.ThisStaff.onHoliday = chkHoliday.Checked;
            StaffList.Add();
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            lblError.Text = "There were problems with the data entered: " + Error;
        }
    }

    void Update()
    {
        clsStaffCollection StaffList = new clsStaffCollection();
        String Error = "";//StaffList.ThisStaff.Valid(txtName.Text, txtAddress.Text, txtNotices.Text)
        if(Error == "")
        {
            StaffList.ThisStaff.Find(staffId);
            StaffList.ThisStaff.staffRoleId = ddlRole.SelectedIndex;
            StaffList.ThisStaff.firstName = txtFirstName.Text;
            StaffList.ThisStaff.lastName = txtLastName.Text;
            StaffList.ThisStaff.dateOfBirth = Convert.ToDateTime(txtDOB.Text);
            StaffList.ThisStaff.dateOfHire = Convert.ToDateTime(txtDOH.Text);
            StaffList.ThisStaff.postCode = txtPostcode.Text;
            StaffList.ThisStaff.cityOfResidence = txtCity.Text;
            StaffList.ThisStaff.streetName = txtStreet.Text;
            StaffList.ThisStaff.houseNumber = txtHouseNo.Text;
            StaffList.ThisStaff.contactEmail = txtEmail.Text;
            StaffList.ThisStaff.contactPhoneNo = txtPhone.Text;
            StaffList.ThisStaff.onHoliday = chkHoliday.Checked;
            StaffList.update();
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            lblError.Text = "There was problem with data entered: " + Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }

    protected void btnSetDate_Click(object sender, EventArgs e)
    {
        txtDOH.Text = Convert.ToString(DateTime.Now);
    }
}