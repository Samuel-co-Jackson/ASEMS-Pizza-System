using System;
using System.Collections.Generic;

namespace PizzaClasses
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

        //public property for ThisCustomer
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }


        //public clsCustomer ThisCustomer { get; set; }

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
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //excute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        //Add method
        public int Add()
        {
            //adds a new record to the database based on the values of thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            //DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@Firstname", mThisCustomer.Customerfirstname);
            DB.AddParameter("@Lastname", mThisCustomer.Customerlastname);
            DB.AddParameter("@HouseNo", mThisCustomer.Customerhouseno);
            DB.AddParameter("@Streetname", mThisCustomer.Customerstreetname);
            DB.AddParameter("@City", mThisCustomer.Customercity);
            DB.AddParameter("@Postcode", mThisCustomer.Customerpostcode);
            DB.AddParameter("@Email", mThisCustomer.Customeremail);
            DB.AddParameter("@PhoneNo", mThisCustomer.Customerphoneno);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void Update()
        {
            //update an existing record to the database based on the values of thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@Firstname", mThisCustomer.Customerfirstname);
            DB.AddParameter("@Lastname", mThisCustomer.Customerlastname);
            DB.AddParameter("@HouseNo", mThisCustomer.Customerhouseno);
            DB.AddParameter("@Streetname", mThisCustomer.Customerstreetname);
            DB.AddParameter("@City", mThisCustomer.Customercity);
            DB.AddParameter("@Postcode", mThisCustomer.Customerpostcode);
            DB.AddParameter("@Email", mThisCustomer.Customeremail);
            DB.AddParameter("@PhoneNo", mThisCustomer.Customerphoneno);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void ReportByPostcode(string Postcode)
        {
            //filters the record based on a full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the postcode parameter to the database
            DB.AddParameter("@Postcode", Postcode);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomers_FilterByPostcode");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var to store the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //get the count of the records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields from the current record
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.Customerfirstname = Convert.ToString(DB.DataTable.Rows[Index]["Firstname"]);
                ACustomer.Customerlastname = Convert.ToString(DB.DataTable.Rows[Index]["Lastname"]);
                ACustomer.Customerhouseno = Convert.ToString(DB.DataTable.Rows[Index]["HouseNo"]);
                ACustomer.Customerstreetname = Convert.ToString(DB.DataTable.Rows[Index]["Streetname"]);
                ACustomer.Customercity = Convert.ToString(DB.DataTable.Rows[Index]["City"]);
                ACustomer.Customerpostcode = Convert.ToString(DB.DataTable.Rows[Index]["Postcode"]);
                ACustomer.Customeremail = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ACustomer.Customerphoneno = Convert.ToInt64(DB.DataTable.Rows[Index]["PhoneNo"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point to the next record
                Index++;
            }
        }

        //public List<clsCustomer> CustomerList { get; set; }

    }
}
