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
        txtName.Text = StaffList.ThisStaff.staffName;
        txtAddress.Text = StaffList.ThisStaff.staffAddress;
        ddlRole.SelectedIndex = StaffList.ThisStaff.staffRoleId;
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
            StaffList.ThisStaff.staffName = txtName.Text;
            StaffList.ThisStaff.staffAddress = txtName.Text;
            StaffList.ThisStaff.staffRoleId = ddlRole.SelectedIndex;
            StaffList.ThisStaff.staffHiredOn = DateTime.Now;
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
            StaffList.ThisStaff.staffName = txtName.Text;
            StaffList.ThisStaff.staffAddress = txtAddress.Text;
            StaffList.ThisStaff.staffRoleId = ddlRole.SelectedIndex;
            StaffList.ThisStaff.staffHiredOn = DateTime.Now;
            StaffList.update();
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            lblError.Text = "There was problem with data entered: " + Error;
        }
    }
}