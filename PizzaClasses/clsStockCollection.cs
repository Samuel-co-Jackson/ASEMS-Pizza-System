using System;
using System.Collections.Generic;

namespace PizzaClasses
{
    public class clsStockCollection
    {
        //private member for the list
        List<clsStock> mStockList = new List<clsStock>();

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

        public clsStock ThisStock { get; set; }

        //constructor for the class
        public clsStockCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //excute the stored procedure I created
            DB.Execute("sproc_tblStock_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank stock item
                clsStock AStock = new clsStock();
                //read in the fields from the current record
                AStock.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AStock.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                AStock.StockQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Stock Quantity"]);
                AStock.StockItemPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["Stock Item Price"]);
                //add the record to the private data member 
                mStockList.Add(AStock);
                //point at the next record
                Index++;
            }
        }
    }
}