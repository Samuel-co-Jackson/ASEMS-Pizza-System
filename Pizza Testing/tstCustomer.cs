using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaClasses;

namespace Pizza_Testing
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACustomer.CustomerID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void CustomerFirstnamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Marc";
            //assign the data to the property
            ACustomer.Customerfirstname = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(ACustomer.Customerfirstname, TestData);
        }

        [TestMethod]
        public void CustomerLastnamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Anthony";
            //assign the data to the property
            ACustomer.Customerlastname = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(ACustomer.Customerlastname, TestData);
        }

        [TestMethod]
        public void CustomerHouseNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "34B";
            //assign the data to the property
            ACustomer.Customerhouseno = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(ACustomer.Customerhouseno, TestData);
        }

        [TestMethod]
        public void CustomerStreetNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Gateway House";
            //assign the data to the property
            ACustomer.Customerstreetname = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(ACustomer.Customerstreetname, TestData);
        }

        [TestMethod]
        public void CustomerCityPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Leicester";
            //assign the data to the property
            ACustomer.Customercity = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(ACustomer.Customercity, TestData);
        }

        [TestMethod]
        public void CustomerPostcodePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "LE1 5AJ";
            //assign the data to the property
            ACustomer.Customerpostcode = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(ACustomer.Customerpostcode, TestData);
        }

        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "LE1 5AJ";
            //assign the data to the property
            ACustomer.Customeremail = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(ACustomer.Customeremail, TestData);
        }

        [TestMethod]
        public void CustomerPhoneNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int64 TestData = 1234567890123;
            //assign the data to the property
            ACustomer.Customerphoneno = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(ACustomer.Customerphoneno, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the valdation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 51;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the valdation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 51;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the CustomerID
            if (ACustomer.CustomerID != 51)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerFirstnameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the valdation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 51;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the CustomerID
            if (ACustomer.Customerfirstname != "New")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerLastnameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the valdation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 51;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the CustomerID
            if (ACustomer.Customerlastname != "Test")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerHouseNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the valdation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 51;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the CustomerID
            if (ACustomer.Customerhouseno != "1A")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerStreetnameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the valdation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 51;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the CustomerID
            if (ACustomer.Customerstreetname != "First Test") 
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerCityFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the valdation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 51;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the CustomerID
            if (ACustomer.Customercity != "Tester") 
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerPostcodeFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the valdation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 51;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the CustomerID
            if (ACustomer.Customerpostcode != "TE6 7ER")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCustomerEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the valdation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 51;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the CustomerID
            if (ACustomer.Customeremail != "Test1@hotmail.co.uk")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerPhoneNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the valdation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 51;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the CustomerID
            if (ACustomer.Customerphoneno != Convert.ToInt64("12456432245"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
