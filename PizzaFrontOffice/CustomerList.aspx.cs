using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PizzaClasses;

public partial class CustomerList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        //create an instance of the Customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        //set the data source to the list of customers in the collection
        lstCustomers.DataSource = Customers.CustomerList;
        //set the name of the primary key
        lstCustomers.DataValueField = "CustomerID";
        //set the data field to display
        lstCustomers.DataTextField = "Customerpostcode";
        //bind the data to the list
        lstCustomers.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["CustomerID"] = -1;
        //redirect to the data entry page
        Response.Redirect("ACustomer.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstCustomers.SelectedIndex != -1)
        {
            //get the primary key of the record to delete
            CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the delete page
            Response.Redirect("CustomerDelete.aspx");
        }
        //if no record has been selected
        else
        {
            //display an error 
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstCustomers.SelectedIndex != -1)
        {
            //get the primary key of the record to edit
            CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the edit page
            Response.Redirect("ACustomer.aspx");
        }
        //if no record has been selected
        else
        {
            //display an error 
            lblError.Text = "Please select a record to Edit from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //declare var to store the record count 
        Int32 RecordCount;
        RecordCount = DisplayPostcode(txtEnterPostcode.Text);
        lblError.Text = RecordCount + " Record Found";
    }

    Int32 DisplayPostcode(string PostcodeFilter)
    {
        Int32 CustomerID;
        string Customerpostcode;
        string Customerfirstname;
        //create an instance of the Shoes Collection
        clsCustomerCollection CustomerPostcode = new clsCustomerCollection();
        //invoke the shoe brand filter
        CustomerPostcode.ReportByPostcode(PostcodeFilter);
        //var to store the count of records
        Int32 RecordCount;
        //var to store the index for the loop
        Int32 Index = 0;
        //get the count of records
        RecordCount = CustomerPostcode.Count;
        //clear the list box
        lstCustomers.Items.Clear();
        //while there are records to process
        while (Index < RecordCount)
        {
            //get the primary key
            CustomerID = CustomerPostcode.CustomerList[Index].CustomerID;
            //get the shoe name
            Customerpostcode = CustomerPostcode.CustomerList[Index].Customerpostcode;
            Customerfirstname = CustomerPostcode.CustomerList[Index].Customerfirstname;
            //create a new entry for the list box
            ListItem NewEntry = new ListItem(Customerpostcode + " " + Customerfirstname, CustomerID.ToString());
            //add the shoes to the list
            lstCustomers.Items.Add(NewEntry);
            //move the index to the next record
            Index++;
        }
        return RecordCount;
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        //display all Customer
        DisplayPostcode("");
    }
    
}