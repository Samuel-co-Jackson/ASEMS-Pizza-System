using PizzaClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderDelete : System.Web.UI.Page
{
    //var to store the primary key to be deleted
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object
        OrderID = Convert.ToInt32(Session["OrderID"]);
    }

    void DeleteOrder()
    {
        //function to delete the selcted record

        //create a new instance of the order
        clsOrderCollection Orders = new clsOrderCollection();
        //find the record to delete
        Orders.ThisOrder.Find(OrderID);
        //delete the record
        Orders.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the order
        DeleteOrder();
        //redirect back to the main page
        Response.Redirect("OrderList.aspx");
    }
}