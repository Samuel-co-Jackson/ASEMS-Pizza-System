using System;

namespace PizzaClasses
{
    public class clsCustomer
    {
        //Unique Customer Identifier
        Int32 mCustomerID;
        //Common Customer Attributes
        String mCustomerfirstname;
        String mCustomerlastname;
        String mCustomerhouseno;
        String mCustomerstreetname;
        String mCustomercity;
        String mCustomerpostcode;
        String mCustomeremail;
        Int64 mCustomerphoneno;

        //Public properties
        public int CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }
        public string Customerfirstname
        {
            get
            {
                return mCustomerfirstname;
            }
            set
            {
                mCustomerfirstname = value;
            }
        }
        public string Customerlastname
        {
            get
            {
                return mCustomerlastname;
            }
            set
            {
                mCustomerlastname = value;
            }
        }
        public string Customerhouseno
        {
            get
            {
                return mCustomerhouseno;
            }
            set
            {
                mCustomerhouseno = value;
            }
        }
        public string Customerstreetname
        {
            get
            {
                return mCustomerstreetname;
            }
            set
            {
                mCustomerstreetname = value;
            }
        }
        public string Customercity
        {
            get
            {
                return mCustomercity;
            }
            set
            {
                mCustomercity = value;
            }
        }
        public string Customerpostcode
        {
            get
            {
                return mCustomerpostcode;
            }
            set
            {
                mCustomerpostcode = value;
            }
        }
        public string Customeremail
        {
            get
            {
                return mCustomeremail;
            }
            set
            {
                mCustomeremail = value;
            }
        }
        public long Customerphoneno
        {
            get
            {
                return mCustomerphoneno;
            }
            set
            {
                mCustomerphoneno = value;
            }
        }

        public Boolean Find(int CustomerID)
        {
            return false;
        }

        public string Valid(string Customerfirstname, string Customerlastname, string Customerhouseno, string Customerstreetname, string Customercity, string Customerpostcode, string Customeremail, string customerPhoneNo)
        {
            string Error = "";
            return Error;
        }
    }
}