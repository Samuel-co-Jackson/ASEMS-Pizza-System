using PizzaClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false)
        {
            DisplayStaff("");
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //-1 indicates a new record
        Session["StaffId"] = -1;
        //redirect to the staff entry page
        Response.Redirect("AStaff.aspx");
    }

    void DisplayStaff(String lastNameFilter)
    {
        
        //lstStaff.DataSource = Staff.staffList;
        //lstStaff.DataValueField = "staffId";
        //lstStaff.DataTextField = "lastName";
        //lstStaff.DataBind();
        Int32 staffId;
        String staffFirstName;
        String staffLastName;
        Int32 staffRoleId;
        String staffRoleName;

        clsStaffCollection Staff = new clsStaffCollection();
        clsRoleCollection allRoles = new clsRoleCollection();
        Staff.ReportByLastName(lastNameFilter);

        Int32 RecordCount;
        Int32 Index = 0;
        RecordCount = Staff.Count;
        lstStaff.Items.Clear();

        while (Index < RecordCount)
        {
            
            staffId = Staff.staffList[Index].staffId;
            staffFirstName = Staff.staffList[Index].firstName;
            staffLastName = Staff.staffList[Index].lastName;
            staffRoleId = Staff.staffList[Index].staffRoleId;
            staffRoleName = allRoles.allRoles[staffRoleId].roleName;

            ListItem NewEntry = new ListItem(staffFirstName + " " + staffLastName + " | " + staffRoleName, staffId.ToString());
            lstStaff.Items.Add(NewEntry);
            Index++;
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 staffId;
        if(lstStaff.SelectedIndex != -1)
        {
            staffId = Convert.ToInt32(lstStaff.SelectedValue);
            Session["staffId"] = staffId;
            Response.Redirect("StaffDelete.aspx");
        }
        else
        {
            lblError.Text = "You must first select a record to delete.";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 staffId;
        if(lstStaff.SelectedIndex != -1)
        {
            staffId = Convert.ToInt32(lstStaff.SelectedValue);
            Session["staffId"] = staffId;
            Response.Redirect("AStaff.aspx");
        }
        else
        {
            lblError.Text = "Please select a staff member to edit.";
        }
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        //Removes any filtering by displaying just all staff (default)
        DisplayStaff("");
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //Displays all staff with last name that starts with the entered filter
        DisplayStaff(txtFilter.Text);
    }
}