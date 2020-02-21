using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PizzaClasses;

public partial class MenuViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsMenu
        clsMenu AMenu = new clsMenu();
        //get the data from the session object
        AMenu = (clsMenu)Session["AMenu"];
        //display the house number for this entry
        Response.Write(AMenu.MenuItemID);
        //display the name for this entry
        Response.Write(AMenu.Name);
        //display the description for this entry
        Response.Write(AMenu.Description);
        //display the recipe for this entry
        Response.Write(AMenu.RecipeID);
        //display the price for this entry
        Response.Write(AMenu.Price);
    }
}