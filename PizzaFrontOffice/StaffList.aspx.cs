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
        lstStaff.Items.Clear();
        lstStaff.DataSource = Staff.staffList;
        lstStaff.DataValueField = "staffId";
        lstStaff.DataTextField = "lastName";
        lstStaff.DataBind();
        //Int32 StudentNo;
        //string StudentPNumber;
        //string StudentFullName;
        //Int32 StudentCourseNo;

        //clsStudentCollection StudentList = new clsStudentCollection();
        //StudentList.ReportByCourse(CourseFilter);

        //Int32 RecordCount;
        //Int32 Index = 0;
        //RecordCount = StudentList.Count;
        //lstStudents.Items.Clear();

        //while (Index < RecordCount)
        //{
        //    StudentNo = StudentList.StudentList[Index].StudentNo;
        //    StudentPNumber = StudentList.StudentList[Index].StudentPNumber;
        //    StudentFullName = StudentList.StudentList[Index].StudentFullName;
        //    StudentCourseNo = StudentList.StudentList[Index].StudentCourseNo;

        //    ListItem NewEntry = new ListItem(StudentFullName + " " + StudentPNumber, StudentNo.ToString());
        //    lstStudents.Items.Add(NewEntry);
        //    Index++;
        //}
        //return RecordCount;
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
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByLastName("");
        lstStaff.Items.Clear();
        lstStaff.DataSource = Staff.staffList;
        lstStaff.DataValueField = "staffId";
        lstStaff.DataTextField = "lastName";
        lstStaff.DataBind();
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByLastName(txtFilter.Text);
        lstStaff.Items.Clear();
        lstStaff.DataSource = Staff.staffList;
        lstStaff.DataValueField = "staffId";
        lstStaff.DataTextField = "lastName";
        lstStaff.DataBind();
    }

    protected void lstStaff_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}