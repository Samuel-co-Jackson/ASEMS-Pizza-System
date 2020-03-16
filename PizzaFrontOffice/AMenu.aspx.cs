using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PizzaClasses;

public partial class AMenu : System.Web.UI.Page
{
    //var to store the primary key value for other uses
    Int32 MenuID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the MenuItem to be processed
        MenuID = Convert.ToInt32(Session["MenuID"]);
        if (IsPostBack == false)
        {
            //populate the list of items
            DisplayMenu();
            //if this is not a new menu item
            if (MenuID != -1)
            {
                //display the current data for the record
                DisplayMenu();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (MenuID == -1)
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

    void Add()
    {
        //create an instance of the menu book
        clsMenuCollection MenuBook = new clsMenuCollection();
        //validate the data on the web form
        String Error = MenuBook.ThisItem.Valid(txtName.Text, txtDescription.Text, Convert.ToInt32(txtRecipe.Text), Convert.ToDouble(txtPrice.Text));
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entrered by the user
            MenuBook.ThisItem.Name = txtName.Text;
            MenuBook.ThisItem.Description = txtDescription.Text;
            MenuBook.ThisItem.RecipeID = Convert.ToInt32(txtRecipe.Text);
            MenuBook.ThisItem.Price = Convert.ToDouble(txtPrice.Text);
            //add the record
            MenuBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("MenuList.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    void Update()
    {
        //create an instance of the menu book
        clsMenuCollection MenuBook = new clsMenuCollection();
        //validate the data on the web form
        String Error = MenuBook.ThisItem.Valid(txtName.Text, txtDescription.Text, Convert.ToInt32(txtRecipe.Text), Convert.ToDouble(txtPrice.Text));
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            MenuBook.ThisItem.Find(MenuID);
            //get the data entered by the user
            MenuBook.ThisItem.Name = txtName.Text;
            MenuBook.ThisItem.Description = txtDescription.Text;
            MenuBook.ThisItem.RecipeID = Convert.ToInt32(txtRecipe.Text);
            MenuBook.ThisItem.Price = Convert.ToDouble(txtPrice.Text);
            //update the record 
            MenuBook.Update();
            //all done so redirect back to the main page
            Response.Redirect("MenuList.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    void DisplayMenu()
    {
        //create an instance of the menu book
        clsMenuCollection MenuBook = new clsMenuCollection();
        //find the record to update
        MenuBook.ThisItem.Find(MenuID);
        //display the data for this record
        txtName.Text = MenuBook.ThisItem.Name;
        txtDescription.Text = MenuBook.ThisItem.Description;
        txtRecipe.Text = MenuBook.ThisItem.RecipeID.ToString();
        txtPrice.Text = MenuBook.ThisItem.Price.ToString();
    }
}
