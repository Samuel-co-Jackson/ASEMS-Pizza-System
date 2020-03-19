using PizzaClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderList : System.Web.UI.Page
{
 

    //variable to store the primary key with page level scope
    Int32 OrderID;

    //event handler for the page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number for the page load event
        OrderID = Convert.ToInt32(Session["OrderID"]);
        //if this is the first time the page is displayed
        if(IsPostBack == false)
        {
            //update the list box
            DisplayOrderStatus();

        }
    }

    void DisplayOrderStatus()
    {
        //create an instance of the Customer collection
        clsOrderCollection Orders = new clsOrderCollection();
        //set the data source to the list of customers in the collection
        lstOrder.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrder.DataValueField = "OrderID";
        //set the data field to display
        lstOrder.DataTextField = "OrderStatus";
        //bind the data to the list
        lstOrder.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //-1 indicates a new record
        Session["OrderID"] = -1;
        //redirect to the staff entry page
        Response.Redirect("AnOrder.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 OrderID;
        //if a record has been selected from list
        if(lstOrder.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            OrderID = Convert.ToInt32(lstOrder.SelectedValue);
            //store the data in the session object
            Session["OrderID"] = OrderID;
            //redirect to the delete page
            Response.Redirect("OrderDelete.aspx");
        }
        else //if nno record has been selected
        {
            //display an error 
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 OrderID;
        //if a record has been selected from the list
        if(lstOrder.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            OrderID = Convert.ToInt32(lstOrder.SelectedValue);
            //store the data in the session object
            Session["OrderID"] = OrderID;
            //redirect to edit page 
            Response.Redirect("AnOrder.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    Int32 DisplayOrders(string OrderStatusFilter)
    {
        Int32 OrderID;
        string OrderStatus;
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportOrderStatus(OrderStatusFilter);
        Int32 RecordCount;
        Int32 Index = 0;
        RecordCount = Orders.Count;
        lstOrder.Items.Clear();
        while(Index < RecordCount)
        {
            OrderID = Orders.OrderList[Index].OrderID;
            OrderStatus = Orders.OrderList[Index].OrderStatus;
            ListItem NewEntry = new ListItem(OrderStatus + " ", OrderID.ToString());
            lstOrder.Items.Add(NewEntry);
            Index++;
        }
        return RecordCount;
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        DisplayOrders(txtOrder.Text);
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        DisplayOrders("");
    }
}