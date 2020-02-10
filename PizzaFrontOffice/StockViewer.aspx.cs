using PizzaClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of the clsStock
        clsStock AStock = new clsStock();
        //get data from the session object
        AStock = (clsStock)Session["AStock"];
        //display the stock name for this entry
        Response.Write(AStock.Name);
    }
}