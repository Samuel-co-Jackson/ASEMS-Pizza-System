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
        lstStaff.DataValueField = "StaffId";
        lstStaff.DataTextField = "StaffRoleId";
        lstStaff.DataBind();
    }
}