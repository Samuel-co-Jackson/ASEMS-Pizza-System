using System;
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
            TestItem.Customerfirstname = "Anthony";
            TestItem.Customerlastname = "Martial";
            TestItem.Customerhouseno = "9";
            TestItem.Customerstreetname = "Red Square";
            TestItem.Customercity = "Manchester";
            TestItem.Customerpostcode = "MU4 9BH";
            TestItem.Customerphoneno = 12456546432;
            TestItem.Customeremail = "TonyMartial50@hotmail.co.uk";
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

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the clsCustomerCollection class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerID = 10;
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
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.IsFalse(Found);
        }


        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the clsCustomerCollection class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Customerfirstname = "Anthony";
            TestItem.Customerlastname = "Martial";
            TestItem.Customerhouseno = "9";
            TestItem.Customerstreetname = "Red Square";
            TestItem.Customercity = "Manchester";
            TestItem.Customerpostcode = "MU4 9BH";
            TestItem.Customerphoneno = 12456546432;
            TestItem.Customeremail = "TonyMartial50@hotmail.co.uk";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //Set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //modify the test data
            TestItem.Customerfirstname = "Eliteone";
            TestItem.Customerlastname = "Bang";
            TestItem.Customerhouseno = "68";
            TestItem.Customerstreetname = "Sixth Floor";
            TestItem.Customercity = "Leicester";
            TestItem.Customerpostcode = "LE4 0YT";
            TestItem.Customerphoneno = 13578654361;
            TestItem.Customeremail = "GWX32@hotmail.co.uk";
            //set the record based on the test data
            AllCustomers.ThisCustomer = TestItem;
            //Update the record
            AllCustomers.Update();
            //now find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void ReportByPostcodeMethodOK()
        {
            //create an instance of the clsCustomerCollection class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // create an instance of the filtered data
            clsCustomerCollection FilteredPostcodes = new clsCustomerCollection();
            //apply a blank string (should return all records)
            FilteredPostcodes.ReportByPostcode("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredPostcodes.Count);
        }

        [TestMethod]
        public void ReportByPostcodeNoneFound()
        {
            //create an instance of the clsCustomerCollection class
            clsCustomerCollection FilteredPostcodes = new clsCustomerCollection();
            //apply a postcode that doesnt exist
            FilteredPostcodes.ReportByPostcode("xxx xxx");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredPostcodes.Count);
        }

        [TestMethod]
        public void ReportByPostcodeTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredPostcodes = new clsCustomerCollection();
            //var to store the outcome
            Boolean OK = true;
            //apply a postcode that does exist
            FilteredPostcodes.ReportByPostcode("LE1 6MN");
            //check that the correct number of records are found
            if (FilteredPostcodes.Count == 2)
            {
                //check that the first record is ID 1
                if (FilteredPostcodes.CustomerList[0].CustomerID != 1)
                {
                    OK = false;
                }
                //check that the first record is ID 2
                if (FilteredPostcodes.CustomerList[1].CustomerID != 2)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }

    }
}
