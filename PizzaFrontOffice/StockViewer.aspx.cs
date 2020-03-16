using PizzaClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockViewer : System.Web.UI.Page
{
    //the following function takes care of the pages load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of the clsStock
        clsStock AStock = new clsStock();
        //get data from the session object
        AStock = (clsStock)Session["AStock"];
        //display the stock name for this entry
        Response.Write(AStock.Name);
        //display the stock description for this entry
        Response.Write(AStock.Description);
        //display the stock quantity for this entry
        Response.Write(AStock.StockQuantity);
        //display the stock item price for this entry
        Response.Write(AStock.StockItemPrice);
    }

    protected void ButtonOK_Click(object sender, EventArgs e)
    {
        //
    }
}