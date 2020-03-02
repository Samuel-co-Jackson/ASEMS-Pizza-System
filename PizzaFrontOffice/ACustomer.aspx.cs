using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PizzaClasses;

public partial class ACustomer : System.Web.UI.Page
{
    Int32 CustomerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of Customers to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            //populate the list of Customers
            DisplayCustomers();
            //if this is not a new record
            if (CustomerID !=-1)
            {
                //display the current data for the record
                DisplayCustomers();
            }
        }

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (CustomerID == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
        } 
    }

    //function for adding new records
    void Add()
    {
        //create an instance of the customer class
        clsCustomerCollection CustomerList = new clsCustomerCollection();
        //validate the data on the web form
        String Error = CustomerList.ThisCustomer.Valid(txtFirstname.Text, txtLastname.Text, txtHouseNo.Text, txtStreetName.Text, txtCity.Text, txtPostcode.Text, txtPhoneNo.Text, txtEmail.Text);
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
            //add the record
            CustomerList.Add();
            //redirect to the main page
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered: " + Error;
        }
    }

    //function for Updating records
    void Update()
    {
        //create an instance of the customer class
        clsCustomerCollection CustomerList = new clsCustomerCollection();
        //validate the data on the web form
        String Error = ""; //CustomerList.ThisCustomer.Valid(txtFirstname.Text, txtLastname.Text, txtHouseNo.Text, txtStreetName.Text, txtCity.Text, txtPostcode.Text, txtPhoneNo.Text, txtEmail.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            CustomerList.ThisCustomer.Find(CustomerID);
            //get the data entered by the user
            CustomerList.ThisCustomer.Customerfirstname = txtFirstname.Text;
            CustomerList.ThisCustomer.Customerlastname = txtLastname.Text;
            CustomerList.ThisCustomer.Customerhouseno = txtHouseNo.Text;
            CustomerList.ThisCustomer.Customerstreetname = txtStreetName.Text;
            CustomerList.ThisCustomer.Customercity = txtCity.Text;
            CustomerList.ThisCustomer.Customerpostcode = txtPostcode.Text;
            CustomerList.ThisCustomer.Customerphoneno = Convert.ToInt64(txtPhoneNo.Text);
            CustomerList.ThisCustomer.Customeremail = txtEmail.Text;
            //add the record
            CustomerList.Update();
            //redirect to the main page
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered: " + Error;
        }
    }

    void DisplayCustomers()
    {
        //create an instance of the customer class
        clsCustomerCollection CustomerList = new clsCustomerCollection();
        //find the record to update
        CustomerList.ThisCustomer.Find(CustomerID);
        //display the data for this record
        txtFirstname.Text = CustomerList.ThisCustomer.Customerfirstname;
        txtLastname.Text = CustomerList.ThisCustomer.Customerlastname;
        txtHouseNo.Text = CustomerList.ThisCustomer.Customerhouseno;
        txtStreetName.Text = CustomerList.ThisCustomer.Customerstreetname;
        txtCity.Text = CustomerList.ThisCustomer.Customercity;
        txtPostcode.Text = CustomerList.ThisCustomer.Customerpostcode;
        txtPhoneNo.Text = CustomerList.ThisCustomer.Customerphoneno.ToString();
        txtEmail.Text = CustomerList.ThisCustomer.Customeremail;
    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main page
        Response.Redirect("CustomerList.aspx");
    }
}