using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PizzaClasses;

public partial class CustomerViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create an instance of the clsCustomer class
        clsCustomer ACustomer = new clsCustomer();
        //get the data from the session object
        ACustomer = (clsCustomer)Session["ACustomer"];
        //display the first name for this entry
        Response.Write(ACustomer.Customerfirstname);
        //display the last name for this entry
        Response.Write(ACustomer.Customerlastname);
        //display the house number for this entry
        Response.Write(ACustomer.Customerhouseno);
        //display the street name for this entry
        Response.Write(ACustomer.Customerstreetname);
        //display the city for this entry
        Response.Write(ACustomer.Customercity);
        //display the postcode for this entry
        Response.Write(ACustomer.Customerpostcode);
        //display the phone number for this entry
        Response.Write(ACustomer.Customerphoneno);
        //display the email for this entry
        Response.Write(ACustomer.Customeremail);
    }
}