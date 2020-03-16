using PizzaClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AStock : System.Web.UI.Page
{

    //variable to store the primary key with page level scope
    Int32 StockID;

    //the following function takes care of the pages load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //event handler for the page load event
        StockID = Convert.ToInt32(Session["StockID"]);
        if (IsPostBack == false)
        {
            //populate the list of stock items
            DisplayStock();
            //if this isn't a new record
            if (StockID != -1)
            {
                //populate the list of stokc items
                DisplayStock();
            }
        }
    }

    void DisplayStock()
    {
        //create istance of the stock collection
        clsStockCollection Stocks = new clsStockCollection();
        //find the record to update
        Stocks.ThisStock.Find(StockID);
        //display the records data
        TextBoxName.Text = Stocks.ThisStock.Name;
        TextBoxDescription.Text = Stocks.ThisStock.Description;
        TextBoxQuantity.Text = Stocks.ThisStock.StockQuantity.ToString();
        TextBoxPrice.Text = Stocks.ThisStock.StockItemPrice.ToString();
    }

    //function for adding new records
    void Add()
    {
        //create the instance of the stock collection
        clsStockCollection StockBook = new clsStockCollection();
        //validate the data on the web front
        String Error = StockBook.ThisStock.Valid(TextBoxName.Text, TextBoxDescription.Text, TextBoxQuantity.Text, TextBoxPrice.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //retrieve the data entered by the user
            StockBook.ThisStock.Name = TextBoxName.Text;
            StockBook.ThisStock.Description = TextBoxDescription.Text;
            StockBook.ThisStock.StockQuantity = Convert.ToInt32(TextBoxQuantity.Text);
            StockBook.ThisStock.StockItemPrice = Convert.ToInt32(TextBoxPrice.Text);
            //add the record
            StockBook.Add();
            //Once completed, redirect back to the main page
            Response.Redirect("StockList.aspx");
        }
        else
        {
            //report an error
            LabelError.Text = "Problems occured with the entered data" + Error;
        }
    }

    void Update()
    {
        //create the instance of the stock collection
        clsStockCollection StockBook = new clsStockCollection();
        //validate the data on the web front
        String Error = StockBook.ThisStock.Valid(TextBoxName.Text, TextBoxDescription.Text, TextBoxQuantity.Text, TextBoxPrice.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update 
            StockBook.ThisStock.Find(StockID);
            //retrieve the data entered by the user
            StockBook.ThisStock.Name = TextBoxName.Text;
            StockBook.ThisStock.Description = TextBoxDescription.Text;
            StockBook.ThisStock.StockQuantity = Convert.ToInt32(TextBoxQuantity.Text);
            StockBook.ThisStock.StockItemPrice = Convert.ToInt32(TextBoxPrice.Text);
            //update the record
            StockBook.Update();
            //Once completed, redirect back to the main page
            Response.Redirect("StockList.aspx");
        }
        else
        {
            //report an error
            LabelError.Text = "Problems occured with the entered data" + Error;
        }
    }

    protected void ButtonOK_Click(object sender, EventArgs e)
    {
        if (StockID == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
        }
    }
}