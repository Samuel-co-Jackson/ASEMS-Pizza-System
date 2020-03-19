using System;

namespace PizzaClasses
{
    public class clsStock
    {
        //private data member for the property
        private Int32 mStockID;
        //private data member for the property
        private string mName;
        //private data member for the property
        private string mDescription;
        //private data member for the property
        private int mStockQuantity;
        //private data member for the property
        private int mStockItemPrice;

        //public data member for the property
        public int StockID
        {
            get
            {
                //return private data member
                return mStockID;
            }
            set
            {
                //set the value of the private data member
                mStockID = value;
            }
        }
        //public data member for the property
        public string Name
        {
            get
            {
                //return private data member
                return mName;
            }
            set
            {
                //set the value of the private data member
                mName = value;
            }
        }
        //public data member for the property
        public string Description
        {
            get
            {
                //return private data member
                return mDescription;
            }
            set
            {
                //set the value of the private data member
                mDescription = value;
            }
        }
        //public data member for the property
        public int StockQuantity
        {
            get
            {
                //return private data member
                return mStockQuantity;
            }
            set
            {
                //set the value of the private data member
                mStockQuantity = value;
            }
        }
        //public data member for the property
        public int StockItemPrice
        {
            get
            {
                //return private data member
                return mStockItemPrice;
            }
            set
            {
                //set the value of the private data member
                mStockItemPrice = value;
            }
        }

        public bool Find(int StockID)
        {
            //create an instance oof the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the StockID to search for
            DB.AddParameter("@StockID", StockID);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByStockID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStockID = Convert.ToInt32(DB.DataTable.Rows[0]["StockID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mStockQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["StockQuantity"]);
                mStockItemPrice = Convert.ToInt32(DB.DataTable.Rows[0]["StockItemPrice"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string Name, string Description, string StockQuantity, string StockItemPrice)
        {
            String Error = "";
            
            //if the name is blank
            if (Name.Length == 0)
            {
                //record the error
                Error = Error + ". The item name may not be empty.";
            }
            //if the Name is less than 1 characters
            if (Name.Length < 1)
            {
                //record the error
                Error = Error + ". The item name is too short.";
            }
            //if the name is longer than 50 characters
            if (Name.Length > 50)
            {
                //record the error
                Error = Error + ". The item name is too long.";
            }

            //if the description is blank 
            if (Description.Length == 0)
            {
                //record the error
                Error = Error + ". The item description may not be empty.";
            }
            //if the description is less than 10 characters
            if (Description.Length < 10)
            {
                //record the error
                Error = Error + ". The item description is too short.";
            }
            //if the description is longer than 100 characters
            if (Description.Length > 100)
            {
                //record the error
                Error = Error + ". The item description is too long.";
            }

            //if the StockQuantity is blank
            if (StockQuantity.Length == 0)
            {
                //record the error
                Error = Error + ". An incorrect quantity value has been entered.";
            }
            //if the StockQuantity is blank
            if (StockQuantity.Length < 1)
            {
                //record the error
                Error = Error + ". No quantity value has been entered, please enter a quantity value.";
            }
            //if the StockQuantity is longer than 3 characters
            if (StockQuantity.Length > 3)
            {
                //record the error
                Error = Error + ". The item quantity exceeds limits.";
            }

            //if the StockItemPrice is blank
            if (StockItemPrice.Length == 0)
            {
                //record the error
                Error = Error + ". An incorrect price value has been entered.";
            }
            //if the StockItemPrice is blank
            if (StockItemPrice.Length < 1)
            {
                //record the error
                Error = Error + ". No price value has been entered, please enter a price value.";
            }
            //return any error message
            return Error;
        }
    }
}