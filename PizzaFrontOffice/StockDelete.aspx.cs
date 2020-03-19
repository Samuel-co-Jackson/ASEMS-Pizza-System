using PizzaClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockDelete : System.Web.UI.Page
{
    //variable to store the primary key to be deleted
    Int32 StockID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the item to be deleted from the session object
        StockID = Convert.ToInt32(Session["StockID"]);
    }

    //function to delete the selected item
    void DeleteStock()
    {
        //create a new instance of the order
        clsStockCollection StockBook = new clsStockCollection();
        //find the record to delete
        StockBook.ThisStock.Find(StockID);
        //delete the record
        StockBook.Delete();
    }

    protected void ButtonYes_Click(object sender, EventArgs e)
    {
        //delete the item
        DeleteStock();
        //redirect back to the stock list
        Response.Redirect("StockList.aspx");
    }

    protected void ButtonNo_Click(object sender, EventArgs e)
    {
        //redirect back to the stock list
        Response.Redirect("StockList.aspx");
    }
}