using PizzaClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create an instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //get the data from the session object
        AnOrder = (clsOrder)Session["AnOrder"];
        //display the order id for this entry
        Response.Write(AnOrder.OrderID);
        //display the customer id for this entry
        Response.Write(AnOrder.CustomerID);
        //display the employee id for this entry
        Response.Write(AnOrder.EmployeeID);
        //display the order date for this entry
        Response.Write(AnOrder.OrderDate);
        //display the order status for this entry
        Response.Write(AnOrder.OrderStatus);
    }
}