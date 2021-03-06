﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PizzaClasses;

public partial class MenuList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayMenu();
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["Name"] = -1;
        //redirect to the data entry page
        Response.Redirect("AMenu.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 MenuID;
        //if a record has been selected from the list
        if (lstMenu.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            MenuID = Convert.ToInt32(lstMenu.SelectedValue);
            //store the data in the session object
            Session["MenuID"] = MenuID;
            //redirect to the delete page
            Response.Redirect("MenuDelete.aspx");
        }
        else //if nothing has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value to edit
        Int32 MenuID;
        //if a record has been selected from the list
        if (lstMenu.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            MenuID = Convert.ToInt32(lstMenu.SelectedValue);
            //store the data in the session object
            Session["MenuID"] = MenuID;
            //redirect to the edit page
            Response.Redirect("AMenu.aspx");
        }
        else //if nothing has been selected
        {
            //display an error
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {

    }

    void DisplayMenu()
    {
        //create an instance of the Menu collection
        clsMenuCollection Menu = new clsMenuCollection();
        //set the data source to the list of Menu items in the collection
        lstMenu.DataSource = Menu.MenuList;
        //set the name of the primary key
        lstMenu.DataValueField = "MenuItemID";
        //set the data field to display
        lstMenu.DataTextField = "Name";
        //bind the data to the list
        lstMenu.DataBind();
    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        DisplayMenu();
    }
}
