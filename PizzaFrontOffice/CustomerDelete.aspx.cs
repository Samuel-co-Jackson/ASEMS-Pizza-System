using System;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PizzaClasses;

public partial class CustomerDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 CustomerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be deleted from the session object
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
    }

    //function to delete the selected customer record 
    void DeleteCustomer()
    {
        //create a new instance of the customer collection class
        clsCustomerCollection CustomerList = new clsCustomerCollection();
        //find the record to delete
        CustomerList.ThisCustomer.Find(CustomerID);
        //delete the record
        CustomerList.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteCustomer();
        //redirect to the main page
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("CustomerList.aspx");
    }
}