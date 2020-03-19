using System;
using System.Collections.Generic;

namespace PizzaClasses
{
    public class clsStockCollection
    {
        //private member for the list
        List<clsStock> mStockList = new List<clsStock>();
        //private data member thisStock
        clsStock mThisStock = new clsStock();

        //public property for the address list
        public clsStock ThisStock
        {
            get
            {
                //return the private data
                return mThisStock;
            }
            set
            {
                //set the private data
                mThisStock = value;
            }
        }

        public int Add()
        {
            //adds new records to the database based on the value of mThisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            //DB.AddParameter("@StockID", mThisStock.StockID);
            DB.AddParameter("@Name", mThisStock.Name);
            DB.AddParameter("@Description", mThisStock.Description);
            DB.AddParameter("@StockQuantity", mThisStock.StockQuantity);
            DB.AddParameter("@StockItemPrice", mThisStock.StockItemPrice);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Delete()
        {
            //deletes the record/s indicated to by te thisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StockID", mThisStock.StockID);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblStock_Delete");
        }

        public void Update()
        {
            //update an existing record based on the value of thisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StockID", mThisStock.StockID);
            DB.AddParameter("@Name", mThisStock.Name);
            DB.AddParameter("@Description", mThisStock.Description);
            DB.AddParameter("@StockQuantity", mThisStock.StockQuantity);
            DB.AddParameter("@StockItemPrice", mThisStock.StockItemPrice);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Update");
        }

        public void ReportByName(string Name)
        {
            //filters the records based on a full or partial name
            //connect to the DB
            clsDataConnection DB = new clsDataConnection();
            //send the Name parameter to the database
            DB.AddParameter("@Name", Name);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array
            mStockList = new List<clsStock>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank stock item
                clsStock AStock = new clsStock();
                //read in the fields from the current record
                AStock.StockID = Convert.ToInt32(DB.DataTable.Rows[Index]["StockID"]);
                AStock.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AStock.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                AStock.StockQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["StockQuantity"]);
                AStock.StockItemPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["StockItemPrice"]);
                //add the record to the private data member 
                mStockList.Add(AStock);
                //point at the next record
                Index++;
            }
        }

        //public property for the address list
        public List<clsStock> StockList
        {
            get
            {
                //return the private data
                return mStockList;
            }
            set
            {
                //set the private data
                mStockList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the private data
                return mStockList.Count;
            }
            set
            {
                //This will be added in a later lab
            }
        }

        //constructor for the class
        public clsStockCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //excute the stored procedure I created
            DB.Execute("sproc_tblStock_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}