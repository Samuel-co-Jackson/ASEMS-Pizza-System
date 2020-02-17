using PizzaClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if(IsPostBack == false)
        {
            //update the list box
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        //create an instance of the order collection
        clsOrderCollection Orders = new clsOrderCollection();
        //set the data sorce to the list of the counties in the collection
        lstOrder.DataSource = Orders.OrderList;
        //set the name of the primary key 
        lstOrder.DataValueField = "OrderID";
        //set the data feild to display
        lstOrder.DataValueField = "OrderStatus";
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
}