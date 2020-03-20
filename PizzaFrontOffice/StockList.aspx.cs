using PizzaClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockList : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 StockID;

    //the following function takes care of the pages load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page has been load
        if (IsPostBack == false)
        {
            //update the listbox
            DisplayStock();
        }
    }
    void DisplayStock()
    {
        //create istance of the stock collection
        clsStockCollection Stocks = new clsStockCollection();
        //set the data source to the list of items in the collection
        ListBoxStock.DataSource = Stocks.StockList;
        ////set the name of the primary key
        ListBoxStock.DataValueField = "StockID";
        //set the data field to display
        ListBoxStock.DataTextField = "Name";
        //bind the data to the list
        ListBoxStock.DataBind();
    }

    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StockID"] = -1;
        //redirect to the data entry page
        Response.Redirect("AStock.aspx");
    }

    protected void ButtonDisplayStock_Click(object sender, EventArgs e)
    {
        DisplayStock();
    }

    protected void ButtonDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 StockID;
        //if a record has been selected from the list
        if (ListBoxStock.SelectedIndex != -1)
        {
            //retrieve the primary key value of the record to delete
            StockID = Convert.ToInt32(ListBoxStock.SelectedValue);
            //store the data in the session object
            Session["StockID"] = StockID;
            //redirect to the delete page
            Response.Redirect("StockDelete.aspx");
        }
        else
        //if no record is selected
        {
            //display an error
            LabelError.Text = "Please select an item to delete from the list";
        }
    }

    protected void ButtonEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 StockID;
        //if a record has been selected from the list
        if (ListBoxStock.SelectedIndex != -1)
        {
            //retrieve the primary key value of the record to edited
            StockID = Convert.ToInt32(ListBoxStock.SelectedValue);
            //store the data in the session object
            Session["StockID"] = StockID;
            //redirect to the delete page
            Response.Redirect("AStock.aspx");
        }
        else
        //if no record is selected
        {
            //display an error
            LabelError.Text = "Please select an item to edit from the list";
        }
    }

    protected void ListBoxStock_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void ButtonApply_Click(object sender, EventArgs e)
    {
        //DisplayStockQuantity(TextBoxSearch.Text);
    }

    //String DisplayStockQuantity(string NameFilter)
    //{
    //    Int32 StockID;
    //    string Name;
    //    clsStockCollection StockBook = new clsStockCollection();
    //    StockBook.ReportByName(NameFilter);
    //    Int32 RecordCount;
    //    Int32 Index = 0;
    //    RecordCount = StockBook.Count;
    //    ListBoxStock.Items.Clear();
    //    while (Index < RecordCount)
    //    {
    //        StockID = StockBook.StockList[Index].StockID;
    //        Name = StockBook.StockList[Index].Name;
    //        ListItem NewEntry = new ListItem(Name + "", StockID.ToString());
    //        ListBoxStock.Items.Add(NewEntry);
    //    }
    //    return RecordCount;
    //}
}