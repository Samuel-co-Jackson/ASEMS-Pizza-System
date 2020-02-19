﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaClasses;
using System.Collections.Generic;

namespace Pizza_Testing
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
       {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);    
       }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the clsCustomerCollection class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerID = 5;
            TestItem.Customerfirstname = "Paul";
            TestItem.Customerlastname = "Pogba";
            TestItem.Customerhouseno = "6";
            TestItem.Customerstreetname = "Old Trafford";
            TestItem.Customercity = "Manchester";
            TestItem.Customerpostcode = "MU1 2FC";
            TestItem.Customerphoneno = 17465389021;
            TestItem.Customeremail = "PPogba6@hotmail.co.uk";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the clsCustomerCollection class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.CustomerID = 1;
            TestCustomer.Customerfirstname = "Sufiyaan";
            TestCustomer.Customerlastname = "Hussain";
            TestCustomer.Customerhouseno = "34B";
            TestCustomer.Customerstreetname = "Gateway House";
            TestCustomer.Customercity = "Leicester";
            TestCustomer.Customerpostcode = "LE1 5GH";
            TestCustomer.Customerphoneno = 07806652976;
            TestCustomer.Customeremail = "SufiyaanDMU@hotmail.co.uk";
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the clsCustomerCollection class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
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
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the clsCustomerCollection class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerID = 11;
            TestItem.Customerfirstname = "Paul";
            TestItem.Customerlastname = "Pogba";
            TestItem.Customerhouseno = "6";
            TestItem.Customerstreetname = "Old Trafford";
            TestItem.Customercity = "Manchester";
            TestItem.Customerpostcode = "MU1 2FC";
            TestItem.Customerphoneno = 17465389021;
            TestItem.Customeremail = "PPogba6@hotmail.co.uk";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //Set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
    }
}
