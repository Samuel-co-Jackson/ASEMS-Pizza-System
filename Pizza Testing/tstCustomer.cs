using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaClasses;

namespace Pizza_Testing
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some test data to pass the method
        string Customerfirstname = "Sufiyaan";
        string Customerlastname = "Hussain";
        string Customerhouseno = "22";
        string Customerstreetname = "North Street";
        string Customercity = "Peterborough";
        string Customerpostcode = "PE1 6AJ";
        string Customeremail = "SH7@hotmail.com";
        string Customerphoneno = Convert.ToInt64(01234567890).ToString();

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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstnameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerfirstname = "";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstnameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerfirstname = "Bo";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerfirstname = "Boo";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerfirstname = "Boooooooooooooooooooooooooooooooooooooooooooooo";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstnameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerfirstname = "Booooooooooooooooooooooooooooooooooooooooooooooo";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerfirstname = "Boooooooooooooooooooooooooooooooooooooooooooooooo";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerFirstnameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerfirstname = "Booooooooooooooooooooooo";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstnameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerfirstname = "";
            Customerfirstname = Customerfirstname.PadRight(100, 'a');
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastnameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerlastname = "";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastnameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerlastname = "Bo";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerlastname = "Boo";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastnameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerlastname = "Booooooooooooooooooooooo";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerlastname = "Boooooooooooooooooooooooooooooooooooooooooooooo";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastnameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerlastname = "Booooooooooooooooooooooooooooooooooooooooooooooo";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerlastname = "Boooooooooooooooooooooooooooooooooooooooooooooooo";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastnameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerlastname = "";
            Customerlastname = Customerlastname.PadRight(100, 'a');
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerHouseNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Customerhouseno = "";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerHouseNoMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Customerhouseno = "7";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerHouseNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Customerhouseno = "7A";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerHouseNoMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Customerhouseno = "123A";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerHouseNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Customerhouseno = "1234567A";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerHouseNoMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Customerhouseno = "12345678A";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerHouseNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Customerhouseno = "123456789A";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerHouseNoExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Customerhouseno = "";
            Customerhouseno = Customerhouseno.PadRight(50, 'A');
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerStreetnameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerstreetname = "";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerStreetnameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerstreetname = "SU";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerStreetnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerstreetname = "Suh";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerStreetnameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerstreetname = "SouthSouthSouthSouthSouth";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerStreetnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerstreetname = "SouthSouthSouthSouthSouthSouthSouthSouthSouthSout";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerStreetnameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerstreetname = "SouthSouthSouthSouthSouthSouthSouthSouthSouthSouth";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerStreetnametMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerstreetname = "SouthSouthSouthSouthSouthSouthSouthSouthSouthSouthh";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerStreetnameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerstreetname = "";
            Customerstreetname = Customerstreetname.PadRight(100, 'a');
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerCityMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customercity = "";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerCityMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customercity = "Zo";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerCityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customercity = "Zoh";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerCityMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customercity = "Zoooooooooooooooooooooooooooooooooooooo";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerCityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customercity = "Zoooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerCityMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customercity = "Zooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerCityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customercity = "Zoooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerCityExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customercity = "";
            Customercity = Customercity.PadRight(200, 'a');
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Customerpostcode = "";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerpostcode = "aaaaa";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerpostcode = "aaaaaa";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerpostcode = "aaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerpostcode = "aaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerpostcode = "aaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerpostcode = "aaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerpostcode = "";
            Customerpostcode = Customerpostcode.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Customeremail = "";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customeremail = "aaa";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customeremail = "aaaa";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customeremail = "";
            Customeremail = Customeremail.PadRight(160, 'a');
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customeremail = "";
            Customeremail = Customeremail.PadRight(319, 'a');
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customeremail = "";
            Customeremail = Customeremail.PadRight(320, 'a');
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customeremail = "";
            Customeremail = Customeremail.PadRight(321, 'a');
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customeremail = "";
            Customerpostcode = Customerpostcode.PadRight(640, 'a');
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Customerphoneno = "";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNoMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerphoneno = "12345678901";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerphoneno = "123456789012";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNoMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerphoneno = "12345678901";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerphoneno = "1234567890";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    
        [TestMethod]
        public void CustomerPhoneNoMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerphoneno = "12345678901";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerphoneno = "123456789012";
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNoExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Customerphoneno = "";
            Customerphoneno = Customerphoneno.PadRight(50, '1');
            //invoke the method
            Error = ACustomer.Valid(Customerfirstname, Customerlastname, Customerhouseno, Customerstreetname, Customercity, Customerpostcode, Customeremail, Customerphoneno);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
