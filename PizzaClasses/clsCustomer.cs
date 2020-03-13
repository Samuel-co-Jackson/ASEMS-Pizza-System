using System;

namespace PizzaClasses
{
    public class clsCustomer
    {
        //Unique Customer Identifier
        //private data member for the CustomerID property
        private Int32 mCustomerID;
        //Common Customer Attributes
        String mCustomerfirstname;
        String mCustomerlastname;
        String mCustomerhouseno;
        String mCustomerstreetname;
        String mCustomercity;
        String mCustomerpostcode;
        String mCustomeremail;
        Int64 mCustomerphoneno;

        //Public property for CustomerID
        public int CustomerID
        {
            get
            {
                //return the private data
                return mCustomerID;
            }
            set
            {
                //set the private data
                mCustomerID = value;
            }
        }

        //Public property for Customerfirstname
        public string Customerfirstname
        {
            get
            {
                //return the private data
                return mCustomerfirstname;
            }
            set
            {
                //set the private data
                mCustomerfirstname = value;
            }
        }

        //Public property for Customerlastname
        public string Customerlastname
        {
            get
            {
                //return the private data
                return mCustomerlastname;
            }
            set
            {
                //set the private data
                mCustomerlastname = value;
            }
        }

        //Public property for Customerhouseno
        public string Customerhouseno
        {
            get
            {
                //return the private data
                return mCustomerhouseno;
            }
            set
            {
                //set the private data
                mCustomerhouseno = value;
            }
        }

        //Public property for Customerstreetname
        public string Customerstreetname
        {
            get
            {
                //return the private data
                return mCustomerstreetname;
            }
            set
            {
                //set the private data
                mCustomerstreetname = value;
            }
        }

        //Public property for Customercity
        public string Customercity
        {
            get
            {
                //return the private data
                return mCustomercity;
            }
            set
            {
                //set the private data
                mCustomercity = value;
            }
        }

        //Public property for Customerpostcode
        public string Customerpostcode
        {
            get
            {
                //return the private data
                return mCustomerpostcode;
            }
            set
            {
                //set the private data
                mCustomerpostcode = value;
            }
        }

        //Public property for Customeremail
        public string Customeremail
        {
            get
            {
                //return the private data
                return mCustomeremail;
            }
            set
            {
                //set the private data
                mCustomeremail = value;
            }
        }

        //Public property for Customerphoneno
        public long Customerphoneno
        {
            get
            {
                //return the private data
                return mCustomerphoneno;
            }
            set
            {
                //set the private data
                mCustomerphoneno = value;
            }
        }

        public bool Find(int CustomerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the CustomerID to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mCustomerfirstname = Convert.ToString(DB.DataTable.Rows[0]["Firstname"]);
                mCustomerlastname = Convert.ToString(DB.DataTable.Rows[0]["Lastname"]);
                mCustomerhouseno = Convert.ToString(DB.DataTable.Rows[0]["HouseNo"]);
                mCustomerstreetname = Convert.ToString(DB.DataTable.Rows[0]["Streetname"]);
                mCustomercity = Convert.ToString(DB.DataTable.Rows[0]["City"]);
                mCustomerpostcode = Convert.ToString(DB.DataTable.Rows[0]["Postcode"]);
                mCustomeremail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mCustomerphoneno = Convert.ToInt64(DB.DataTable.Rows[0]["PhoneNo"]);
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

        public string Valid(string Customerfirstname, string Customerlastname, string Customerhouseno, string Customerstreetname, string Customercity, string Customerpostcode, string Customeremail, string Customerphoneno)
        {
            //create a string variable to store the error message
            String Error = "";

            //*****************************************************//
            //if the Customerfirstname is blank
            if (Customerfirstname.Length == 0)
            {
                //record the error
                Error = Error + "The Firstname may not be blank : ";
            }
            //if the Customerfirstname is greater than 48 characters
            if (Customerfirstname.Length > 48)
            {
                //record the error
                Error = Error + "The Firstname may not be more than 48 characters : ";
            }

            //*****************************************************//
            //if the Customerlastname is blank
            if (Customerlastname.Length == 0)
            {
                //record the error
                Error = Error + "The Lastname may not be blank : ";
            }
            //if the Customerlastname is greater than 48 characters
            if (Customerlastname.Length > 48)
            {
                //record the error
                Error = Error + "The Lastname may not be more than 48 characters : ";
            }

            //*****************************************************//
            //if the Customerhouseno is blank
            if (Customerhouseno.Length == 0)
            {
                //record the error
                Error = Error + "The House No may not be blank : ";
            }
            //if the Customerhouseno is greater than 9 characters
            if (Customerhouseno.Length > 9)
            {
                //record the error
                Error = Error + "The House No may not be more than 9 characters : ";
            }

            //*****************************************************//
            //if the Customerstreetname is blank
            if (Customerstreetname.Length == 0)
            {
                //record the error
                Error = Error + "The Street Name may not be blank : ";
            }
            //if the Customerstreetname is greater than 50 characters
            if (Customerstreetname.Length > 50)
            {
                //record the error
                Error = Error + "The Street Name may not be more than 50 characters : ";
            }

            //*****************************************************//
            //if the Customercity is blank
            if (Customercity.Length == 0)
            {
                //record the error
                Error = Error + "The City may not be blank : ";
            }
            //if the Customercity is greater than 80 characters
            if (Customercity.Length > 80)
            {
                //record the error
                Error = Error + "The City may not be more than 80 characters : ";
            }

            //*****************************************************//
            //if the Customerpostcode is blank
            if (Customerpostcode.Length == 0)
            {
                //record the error
                Error = Error + "The Postcode may not be blank : ";
            }
            //if the Customerpostcode is greater than 10 characters

            if (Customerpostcode.Length > 10)
            {
                //record the error
                Error = Error + "The Postcode may not be more than 10 characters: ";
            }

            //*****************************************************//
            //if the Customeremail is blank
            if (Customeremail.Length == 0)
            {
                //record the error
                Error = Error + "The Email may not be blank : ";
            }
            //if the Customeremail is greater than 320 characters
            if (Customeremail.Length > 320)
            {
                //record the error
                Error = Error + "The Email may not be more than 320 characters : ";
            }

            //*****************************************************//
            //if the Customerphoneno is blank
            if (Customerphoneno.Length == 0)
            {
                //record the error 
                Error = Error + " The customer phone number may not be blank." + " ";
            }

            //if the Customerphoneno is less than 10 numbers or greater or equal to 12 characters
            if (Customerphoneno.Length != 11)
            {
                //record the error 
                Error = Error + "The customer phone number needs to be up to 11 digits.";
            }



            //try
            //{
            //    Int32 TempCustomerPhoneNo = Convert.ToInt32(Customerphoneno);
            //    //if Customer Phone Number is blank 
            //    if (TempCustomerPhoneNo == 0)
            //    {
            //        //record the error 
            //        Error = Error + " The customer phone number may not be blank." + " ";
            //    }


            //    if (TempCustomerPhoneNo < 0 | TempCustomerPhoneNo > 11)
            //    {
            //        //record the error 
            //        Error = Error + " The customer phone number needs to be up to 11 digits.";
            //    }
            //}

            //catch
            //{
            //    //record the error 
            //    Error = Error + " The data was not valid. ";
            //}

            //return any error messages
            return Error;
        }
    }
}