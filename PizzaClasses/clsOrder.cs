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
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //if the Customer id is blank
            if(CustomerID.Length == 0)
            {
                //record the error
                Error = Error + "The customer id may not be blank";
            }
            //if the customer id is greater than 100
            if (CustomerID.Length > 3)
            {
                //record an error
                Error = Error + "The customer id must be less than 1000";
            }
            ///////////////////////////////////////////////////////////////
            if(StaffID.Length == 0)
            {
                //record the error
                Error = Error + "The staff id may not be blank";
            }
            //if the staff id is greater than 100
            if (StaffID.Length > 3)
            {
                //record an error
                Error = Error + "The staff id must be less than 1000";
            }
            //////////////////////////////////////////////////////////////
            try
            {
                DateTemp = Convert.ToDateTime(OrderDate);
                //date in the past
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past";
                }
                //check to see if it is greater than todays date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date";
            }
            /////////////////////////////////////////////////////////////
            //if its blank
            if (OrderStatus.Length == 0)
            {
                //record the error
                Error = Error + "The order status must not be blank";
            }
            //if its greater than 10 characters
            if (OrderStatus.Length > 11)
            {
                //record the error
                Error = Error + "The order status must have more than 10 characters";
            }
            //return any error messages
            return Error;
        }
    }
}