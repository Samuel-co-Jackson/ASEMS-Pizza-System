using PizzaClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AStock : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AStock = new clsStock();
        //capture the Stock Name
        AStock.Name = TextBoxName.Text;
        //Store the name in the session object
        Session["AStock"] = AStock;
        //redirect to the viewer page
        Response.Redirect("StockViewer.aspx");
    }
}