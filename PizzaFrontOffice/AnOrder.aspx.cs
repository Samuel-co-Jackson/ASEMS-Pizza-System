using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PizzaClasses;

public partial class AnOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the order no
        AnOrder.OrderID = Convert.ToInt32(txtOrderID.Text);
        //capture the customer no
        AnOrder.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //capture the staff no
        AnOrder.EmployeeID = Convert.ToInt32(txtEmployeeID.Text);
        //capture the order date
        AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
        //capture the order status
        AnOrder.OrderStatus = txtOrderStatus.Text;
        //store the address in the session object
        Session["AnOrder"] = AnOrder;
        //redirect to the viewer page
        Response.Redirect("OrderViewer.aspx");
    }
}