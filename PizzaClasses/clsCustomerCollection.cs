using System.Collections.Generic;

namespace PizzaClasses
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

        //constructor for the class
        public clsCustomerCollection()
        {
            //creae the items of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 1;
            TestItem.Customerfirstname = "Sufiyaan";
            TestItem.Customerlastname = "Hussain";
            TestItem.Customerhouseno = "34B";
            TestItem.Customerstreetname = "Gateway House";
            TestItem.Customercity = "Leicester";
            TestItem.Customerpostcode = "LE1 5GH";
            TestItem.Customerphoneno = 07806652976;
            TestItem.Customeremail = "SufiyaanDMU@hotmail.co.uk";
            //add the item to the test list
            mCustomerList.Add(TestItem);
            //re initialise the object from some new data
            TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 1;
            TestItem.Customerfirstname = "Tony";
            TestItem.Customerlastname = "Martial";
            TestItem.Customerhouseno = "10";
            TestItem.Customerstreetname = "Old Trafford";
            TestItem.Customercity = "Manchester";
            TestItem.Customerpostcode = "MN1 3AJ";
            TestItem.Customerphoneno = 01234567892;
            TestItem.Customeremail = "TonyMartial@hotmail.com";
            //add the item to the test list
            mCustomerList.Add(TestItem);
        }


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

        //public List<clsCustomer> CustomerList { get; set; }
        public clsCustomer ThisCustomer { get; set; }

    }


    
}