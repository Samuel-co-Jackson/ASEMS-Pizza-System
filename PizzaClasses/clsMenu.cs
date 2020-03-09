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

        public string Valid(string text1, string text2, string text3, string text4)
        {
            throw new NotImplementedException();
        }
    }
}