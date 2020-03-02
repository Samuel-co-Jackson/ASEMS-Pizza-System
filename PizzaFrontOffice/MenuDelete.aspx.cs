using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PizzaClasses;

public partial class MenuDelete : System.Web.UI.Page
{
    //var to store the primary key value to be deleted
    Int32 MenuID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the menu item to be deleted from the session object
        MenuID = Convert.ToInt32(Session["MenuID"]);
    }

    void DeleteMenuItem()
    {
        //function to delete the selected record
        //create a new instance of the MenuBook
        clsMenuCollection MenuBook = new clsMenuCollection();
        //find the record to delete
        MenuBook.ThisItem.Find(MenuID);
        //delete the record
        MenuBook.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteMenuItem();
        //redirect back to the main page
        Response.Redirect("MenuList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("MenuList.aspx");
    }
}
