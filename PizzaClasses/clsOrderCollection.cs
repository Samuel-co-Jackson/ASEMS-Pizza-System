using System;
using System.Collections.Generic;

namespace PizzaClasses
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        public clsOrder ThisOrder { get; set; }

        //public property for the order list
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //worry about it later
            }
        }

        //constructor for the class
        public clsOrderCollection()
        {
            //create the items of the test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.EmployeeID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderStatus = "Cooking";
            //add item to the test list
            mOrderList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsOrder();
            //set its properties 
            TestItem.OrderID = 2;
            TestItem.CustomerID = 2;
            TestItem.EmployeeID = 2;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderStatus = "Delivering";
            //add item to the test list
            mOrderList.Add(TestItem);
        }

    }
}