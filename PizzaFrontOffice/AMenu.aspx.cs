using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PizzaClasses;

public partial class AMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsMenu
        clsMenu AMenu = new clsMenu();
        //capture the Menu ID
        AMenu.MenuItemID = Convert.ToInt32(txtMenuID.Text);
        //capture the Name
        AMenu.Name = txtName.Text;
        //capture the Description
        AMenu.Description = txtDescription.Text;
        //capture the Recipe ID
        AMenu.RecipeID = Convert.ToInt32(txtRecipe.Text);
        //capture the Price
        AMenu.Price = Convert.ToDouble(txtPrice.Text);
        //store the address in the session object
        Session["AMenu"] = AMenu;
        //redirect to the viewer page
        Response.Redirect("MenuViewer.aspx");
    }
}