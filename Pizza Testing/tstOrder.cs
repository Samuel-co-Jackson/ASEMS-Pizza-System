using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaClasses;

namespace Pizza_Testing
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        //create some test data to pass to the method
        string CustomerID = "1";
        string StaffID = "1";
        string OrderDate = DateTime.Now.Date.ToString();
        string OrderStatus = "Finished";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }

        [TestMethod]
        public void EmployeeIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.StaffID, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void OrderStatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Cooking";
            //assign the data to the property
            AnOrder.OrderStatus = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderStatus, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderID = 1;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (Assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 1;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the order id
            if(AnOrder.OrderID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (Assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 1;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the order id
            if (AnOrder.CustomerID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffIDIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (Assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 1;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the order id
            if (AnOrder.StaffID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (Assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 1;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if(AnOrder.OrderDate !=Convert.ToDateTime("12/03/2020"))
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderStatusFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (Assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 1;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if(AnOrder.OrderStatus != "Delivering")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Customer Testing///////////////////////////////////
        [TestMethod]
        public void CustomerIDLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass the method
            string CustomerID = "";//this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass the method
            string CustomerID = "1";//this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass the method
            string CustomerID = "11";//this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass the method
            string CustomerID = "99";//this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass the method
            string CustomerID = "100";//this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass the method
            string CustomerID = "50";//this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass the method
            string CustomerID = "1000";//this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass the method
            string CustomerID = "";//this should fail
            CustomerID = CustomerID.PadRight(500, '1');
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //Customer Testing///////////////////////////////////

        //Staff Testing/////////////////////////////////////
        [TestMethod]
        public void StaffIDMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass the method
            string StaffID = "";//this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass the method
            string StaffID = "1";//this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass the method
            string StaffID = "11";//this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass the method
            string StaffID = "99";//this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass the method
            string StaffID = "100";//this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass the method
            string StaffID = "50";//this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass the method
            string StaffID = "1000";//this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass the method
            string StaffID = "";//this should fail
            StaffID = StaffID.PadRight(500, '1');
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //Staff Testing/////////////////////////////////////

        //Order Date Testing////////////////////////////////
        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date whatever the date is less 100 years
            TestDate = TestDate.AddYears(-1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to tomorrow
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to tomorrow
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //set the Order date to a non date value
            string OrderDate = "This is not a date!";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //Order Date Testing////////////////////////////////

        //Order Status Testing//////////////////////////////
        [TestMethod]
        public void OrderStatusLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //this should fail
            string OrderStatus = "";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //this should fail
            string OrderStatus = "Cooks";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //this should fail
            string OrderStatus = "Cookss";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //this should fail
            string OrderStatus = "Deliverin";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderStatusMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //this should fail
            string OrderStatus = "Delivering";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderStatusMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //this should fail
            string OrderStatus = "Deliveringss";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrderStatusMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //this should fail
            string OrderStatus = "Deliv";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, StaffID, OrderDate, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
