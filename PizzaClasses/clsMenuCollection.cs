﻿using System;
using System.Collections.Generic;

namespace PizzaClasses
{
    public class clsMenuCollection
    {
        //private data member for the list
        List<clsMenu> mMenuList = new List<clsMenu>();
        //private data member thisMenu
        clsMenu mThisMenu = new clsMenu();

        //constructor for the class
        public clsMenuCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure
            DB.Execute("sproc_tblMenu_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        //public property for the menu list
        public List<clsMenu> MenuList
        {
            get
            {
                //return the private data
                return mMenuList;
            }
            set
            {
                //set the private data
                mMenuList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mMenuList.Count;
            }
            set
            {
                //worry about this later
            }
        }

        public clsMenu ThisMenuItem { get; set; }

        public clsMenu ThisItem
        {
            get
            {
                //return the private data 
                return mThisMenu;
            }
            set
            {
                //set the private data 
                mThisMenu = value;
            }
        }

        void PopulateArray(clsDataConnection DB)
        {
            //var for the index
            int Index = 0;
            //var to store the record count
            int RecordCount = 0;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mMenuList = new List<clsMenu>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Menu
                clsMenu AMenu = new clsMenu();
                //read in the fields from the current record
                AMenu.MenuItemID = Convert.ToInt32(DB.DataTable.Rows[Index]["MenuID"]);
                AMenu.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AMenu.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                AMenu.RecipeID = Convert.ToInt32(DB.DataTable.Rows[Index]["RecipeID"]);
                AMenu.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                //add the record to the private data member
                mMenuList.Add(AMenu);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            //add a new record to the database on the values of mThisMenu
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procudure
            DB.AddParameter("@Name", mThisMenu.Name);
            DB.AddParameter("@Description", mThisMenu.Description);
            DB.AddParameter("@RecipeID", mThisMenu.RecipeID);
            DB.AddParameter("@Price", mThisMenu.Price);
            //execute the query returnng the primary key value
            return DB.Execute("sproc_tblMenu_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisItem
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@MenuItemID", mThisMenu.MenuItemID);
            //execute stored procedure
            DB.Execute("sproc_tblMenu_Delete");
        }

        public void Update()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters
            DB.AddParameter("@MenuID", mThisMenu.MenuItemID);
            DB.AddParameter("@Name", mThisMenu.Name);
            DB.AddParameter("@Description", mThisMenu.Description);
            DB.AddParameter("@RecipeID", mThisMenu.RecipeID);
            DB.AddParameter("@Price", ThisMenuItem.Price);
            //execute stored procedure
            DB.Execute("sproc_tblMenu_Update");
        }

        public void ReportByPizzaName(string Name)
        {
            //filters the records based on a full/partial name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the PizzaName parameter to the database
            DB.AddParameter("@PizzaName", Name);
            //execute the stored procedure
            DB.Execute("sproc_tblMenu_FilterByPizzaName");
            //populate the array
            PopulateArray(DB);
        }
    }
}