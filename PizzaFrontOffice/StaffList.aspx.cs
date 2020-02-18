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
            DisplayStaff();
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //-1 indicates a new record
        Session["StaffId"] = -1;
        //redirect to the staff entry page
        Response.Redirect("AStaff.aspx");
    }

    void DisplayStaff()
    {
        clsStaffCollection Staff = new clsStaffCollection();
        lstStaff.DataSource = Staff.staffList;
        lstStaff.DataValueField = "staffId";
        lstStaff.DataTextField = "staffName";
        lstStaff.DataBind();
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 staffId;
        if(lstStaff.SelectedIndex != -1)
        {
            staffId = Convert.ToInt32(lstStaff.SelectedValue);
            Session["staffId"] = staffId;
            Response.Redirect("Delete.aspx");
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
}