using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PizzaClasses;

public partial class AnOrder : System.Web.UI.Page
{
    //scope of order id
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be processed
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if(IsPostBack == false)
        {
            //populate the list of orders
            
            //if this is not a new order
            if (OrderID != -1)
            {
                DisplayOrder();
            }
        }
    }

    protected void btnOK_Click1(object sender, EventArgs e)
    {
        if (OrderID == -1)
        {
            //add new record
            Add();

        }
        else
        {
            //update the record
            Update();
        }
    }

    void DisplayOrder()
    {
        //create an instance of the order
        clsOrderCollection Orders = new clsOrderCollection();
        //find the record to update
        Orders.ThisOrder.Find(OrderID);
        //display the data for this record
        txtCustomerID.Text = Orders.ThisOrder.CustomerID.ToString();
        txtStaffID.Text = Orders.ThisOrder.StaffID.ToString();
        txtOrderDate.Text = Orders.ThisOrder.OrderDate.ToString();
        txtOrderStatus.Text = Orders.ThisOrder.OrderStatus;
    }

    //function for adding new records
    void Add()
    {
        //create an instance of the order
        clsOrderCollection Orders = new clsOrderCollection();
        //validate the data on the web form
        String Error = Orders.ThisOrder.Valid(txtCustomerID.Text, txtStaffID.Text, txtOrderDate.Text, txtOrderStatus.Text);
        //if the data is OK then add it to the object
        if(Error == "")
        {
            
            //get the data entered by the user
            Orders.ThisOrder.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            Orders.ThisOrder.StaffID = Convert.ToInt32(txtStaffID.Text);
            Orders.ThisOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
            Orders.ThisOrder.OrderStatus = txtOrderStatus.Text;
            //add the record
            Orders.Add();
            //redirect to the main page
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were issues with the data entered: <br /><br /><br />" + Error;
        }
    }

    //update the order
    void Update()
    {
        //create an instance of the order
        clsOrderCollection Orders = new clsOrderCollection();
        //validate the data on the web form
        String Error = Orders.ThisOrder.Valid(txtCustomerID.Text, txtStaffID.Text, txtOrderDate.Text, txtOrderStatus.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            Orders.ThisOrder.Find(OrderID);
            //get the data entered by the user
            Orders.ThisOrder.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            Orders.ThisOrder.StaffID = Convert.ToInt32(txtStaffID.Text);
            Orders.ThisOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
            Orders.ThisOrder.OrderStatus = txtOrderStatus.Text;
            //update the order
            Orders.Update();
            //redirect to the main page
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered: <br /><br /><br /><br /> " + Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the home page
        Response.Redirect("OrderList.aspx");
    }
}