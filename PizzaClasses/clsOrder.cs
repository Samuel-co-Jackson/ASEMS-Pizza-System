using System;

namespace PizzaClasses
{
    public class clsOrder
    {
        //private data member for order id property
        private Int32 mOrderID;
        private Int32 mCustomerID;
        private Int32 mStaffID;
        private DateTime mOrderDate;
        private string mOrderStatus;

        //public property for order id
        public int OrderID
        {
            get
            {
                //return private data
                return mOrderID;
            }
            set
            {
                //set the value of the private data memebr
                mOrderID = value;
            }
        }

        public int CustomerID
        {
            get
            {
                //return private data
                return mCustomerID;
            }
            set
            {
                //set the value of the private data memebr
                mCustomerID = value;
            }
        }

        public int StaffID
        {
            get
            {
                //return private data
                return mStaffID;
            }
            set
            {
                //set the value of the private data memebr
                mStaffID = value;
            }
        }

        public DateTime OrderDate
        {
            get
            {
                //return private data
                return mOrderDate;
            }
            set
            {
                //set the value of the private data member
                mOrderDate = value;
            }
        }

        public string OrderStatus
        {
            get
            {
                //return private data
                return mOrderStatus;
            }
            set
            {
                //set the value of the private data member
                mOrderStatus = value;
            }
        }


        public bool Find(int OrderID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order id to search for 
            DB.AddParameter("@OrderID", OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            //if one record is found (there should be either one or zero)
            if(DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mOrderStatus = Convert.ToString(DB.DataTable.Rows[0]["OrderStatus"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string CustomerID, string StaffID, string OrderDate, string OrderStatus)
        {
            return "";
        }
    }
}