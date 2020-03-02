using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this the fisrt time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            //DisplayStocks();
        }
    }

    //void DisplayStocks()
    //{
    //    //create instance of the Stock collection
    //    Class_Library.clsStockCollection Stocks = new Class_Library.clsStockCollection();
    //    //set the data source to the list of items in the collection
    //    listBoxStock.DataSource = Stocks.StockList;
    //    //set the name of the primary key
    //    listBoxStock.DataValueField = "StockNo";
    //    //set the data field to display
    //    listBoxStock.DataText.Field = "Description";
    //    //bind the data to the list
    //    listBoxStock.DataBind();
    //}
}