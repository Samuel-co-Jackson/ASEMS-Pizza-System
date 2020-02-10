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
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //capture the staff name
        AStaff.staffName = txtName.Text;
        //store the name in the session object
        Session["AStaff"] = AStaff;
        //redirect to the viewer page
        Response.Redirect("StaffViewer.aspx");
    }
}