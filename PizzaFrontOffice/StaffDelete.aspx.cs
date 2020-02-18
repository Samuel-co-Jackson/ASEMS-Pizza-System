using PizzaClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffDelete : System.Web.UI.Page
{

    Int32 staffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        staffId = Convert.ToInt32(Session["staffId"]);
    }

    void DeleteStaff()
    {
        clsStaffCollection StaffList = new clsStaffCollection();
        StaffList.ThisStaff.Find(staffId);
        StaffList.Delete();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DeleteStaff();
        Response.Redirect("StaffList.aspx");
    }
}