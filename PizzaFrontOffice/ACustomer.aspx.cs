using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PizzaClasses;

public partial class ACustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance of the clsCustomer class
        clsCustomer ACustomer = new clsCustomer();
        //capture the first name 
        ACustomer.Customerfirstname = txtFirstname.Text;
        //capture the last name
        ACustomer.Customerlastname = txtLastname.Text;
        //capture the house no
        ACustomer.Customerhouseno = txtHouseNo.Text;
        //capture the street name
        ACustomer.Customerstreetname = txtStreetName.Text;
        //capture the city
        ACustomer.Customercity = txtCity.Text;
        //capture the postcode
        ACustomer.Customerpostcode = txtPostcode.Text;
        //capture the phone number
        ACustomer.Customerphoneno = Convert.ToInt64(txtPhoneNo.Text);
        //capture the email address
        ACustomer.Customeremail = txtEmail.Text;
        //store the customer in the session object
        Session["ACustomer"] = ACustomer;
        //redirect to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }
}