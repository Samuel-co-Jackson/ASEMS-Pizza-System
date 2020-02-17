using System;
using System.Collections.Generic;

namespace PizzaClasses
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        public clsCustomer ThisCustomer { get; set; }

        //public property for the customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the prvate data
                mCustomerList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //constructor for the class
        public clsCustomerCollection()
        {
            //var to store the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //excute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of the records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields from the current record
                //AnCustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.Customerfirstname = Convert.ToString(DB.DataTable.Rows[Index]["Firstname"]);
                ACustomer.Customerlastname = Convert.ToString(DB.DataTable.Rows[Index]["Lastname"]);
                ACustomer.Customerhouseno = Convert.ToString(DB.DataTable.Rows[Index]["HouseNo"]);
                ACustomer.Customerstreetname = Convert.ToString(DB.DataTable.Rows[Index]["Streetname"]);
                ACustomer.Customercity = Convert.ToString(DB.DataTable.Rows[Index]["City"]);
                ACustomer.Customerpostcode = Convert.ToString(DB.DataTable.Rows[Index]["Postcode"]);
                ACustomer.Customeremail = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ACustomer.Customerphoneno = Convert.ToInt64(DB.DataTable.Rows[Index]["Phone No"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point to the next record
                Index++;
            }
        }

        //public List<clsCustomer> CustomerList { get; set; }

    }
}
