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

        //add the new record
        Add();
        //redirect to the viewer page
        Response.Redirect("CustomerViewer.aspx");

        
        ////create an instance of the clsCustomer class
        //clsCustomer ACustomer = new clsCustomer();
        ////capture the first name 
        //ACustomer.Customerfirstname = txtFirstname.Text;
        ////capture the last name
        //ACustomer.Customerlastname = txtLastname.Text;
        ////capture the house no
        //ACustomer.Customerhouseno = txtHouseNo.Text;
        ////capture the street name
        //ACustomer.Customerstreetname = txtStreetName.Text;
        ////capture the city
        //ACustomer.Customercity = txtCity.Text;
        ////capture the postcode
        //ACustomer.Customerpostcode = txtPostcode.Text;
        ////capture the phone number
        //ACustomer.Customerphoneno = Convert.ToInt64(txtPhoneNo.Text);
        ////capture the email address
        //ACustomer.Customeremail = txtEmail.Text;
        ////store the customer in the session object
        //Session["ACustomer"] = ACustomer;
       
    }

    //function for adding new records
    void Add()
    {
        //create an instance of the customer class
        clsCustomerCollection CustomerList = new clsCustomerCollection();
        //validate the data on the web form
        String Error = ""; //CustomerList.ThisCustomer.Valid(txtFirstname.Text, txtLastname.Text, txtHouseNo.Text, txtStreetName.Text, txtCity.Text, txtPostcode.Text, txtPhoneNo.Text, txtEmail.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            CustomerList.ThisCustomer.Customerfirstname = txtFirstname.Text;
            CustomerList.ThisCustomer.Customerlastname = txtLastname.Text;
            CustomerList.ThisCustomer.Customerhouseno = txtHouseNo.Text;
            CustomerList.ThisCustomer.Customerstreetname = txtStreetName.Text;
            CustomerList.ThisCustomer.Customercity = txtCity.Text;
            CustomerList.ThisCustomer.Customerpostcode = txtPostcode.Text;
            CustomerList.ThisCustomer.Customerphoneno = Convert.ToInt64(txtPhoneNo.Text);
            CustomerList.ThisCustomer.Customeremail = txtEmail.Text;
            CustomerList.Add();
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            lblError.Text = "There were problems with the data entered: " + Error;
        }
    }
}