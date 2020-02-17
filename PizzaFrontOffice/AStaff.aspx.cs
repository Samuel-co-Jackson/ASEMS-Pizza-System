using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PizzaClasses;

public partial class AStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSave_Click1(object sender, EventArgs e)
    {
        Add();
        Response.Redirect("StaffList.aspx");
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
}