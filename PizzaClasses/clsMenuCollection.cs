using System;
using System.Collections.Generic;

namespace PizzaClasses
{
    public class clsMenuCollection
    {

        //private data member for the list
        List<clsMenu> mMenuList = new List<clsMenu>();
        //private data member thisMenu
        clsMenu mThisMenu = new clsMenu();

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

        //constructor for this class
        public clsMenuCollection()
        {
            //var for the index
            int Index = 0;
            //var to store the record count
            int RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblMenu_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while(Index < RecordCount)
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
    }
}