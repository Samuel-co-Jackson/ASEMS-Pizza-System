using System;

namespace PizzaClasses
{
    public class clsMenu
    {
        private Int32 mMenuItemID;
        private String mName;
        private String mDescription;
        private Int32 mRecipeID;
        private Double mPrice;

        public clsMenu()
        {
        }

        public int MenuItemID
        {
            get
            {
                //return the private data
                return mMenuItemID;
            }
            set
            {
                mMenuItemID = value;
            }
        }
        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }
        public string Description
        {
            get
            {
                return mDescription;
            }
            set
            {
                mDescription = value;
            }
        }
        public int RecipeID
        {
            get
            {
                return mRecipeID;
            }
            set
            {
                mRecipeID = value;
            }
        }
        public double Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }

        public bool Find(int MenuID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Pizza Name
            DB.AddParameter("@MenuItemID", MenuID);
            //execute the store procedure
            DB.Execute("sproc_tblMenu_FilterByMenuItemID");
            //if one record is found (there should be either one or zero!)
            if(DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mMenuItemID = Convert.ToInt32(DB.DataTable.Rows[0]["MenuID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mRecipeID = Convert.ToInt32(DB.DataTable.Rows[0]["RecipeID"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                //everything worked OK
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string name, string description, Int32 recipeID, Double price)
        {
            //string to hold error
            String Error = "";
            //if name is blank
            if(name.Length == 0)
            {
                Error = Error + "The Pizza name cannot be blank. ";
            }
            //if name over max (20)
            else if(name.Length > 20)
            {
                Error = Error + "The Pizza name can't be more than 20 characters. ";
            }
            //if description blank
            if(description.Length == 0)
            {
                Error = Error + "The Pizza description cannot be blank. ";
            }
            //if description over max (40)
            else if(description.Length > 40)
            {
                Error = Error + "The Pizza description can't be more than 40 characters. ";
            }
            //if recipeID is negative
            if(recipeID < 0)
            {
                Error = Error + "There aren't any negative recipe IDs. ";
            }
            //if price is negative (we're not giving out money but some stuff could become free on special events)
            if(price < 0)
            {
                Error = Error + "The price can't be negative, we're not giving out money! ";
            }

            return Error;
        }
    }
}