using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaClasses;

namespace Pizza_Testing
{
    [TestClass]
    public class tstStock
    {
        //test data
        //creating test data to pass to methods
        string Name = "TestData";
        string Description = "This is a test description";
        string StockQuantity = "36";
        string StockItemPrice = "63";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //test to see if it exists
            Assert.IsNotNull(AStock);
        }

        [TestMethod]
        public void StockIDOK()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //create test data to assign to property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.StockID = TestData;
            //test to see if the two values match
            Assert.AreEqual(AStock.StockID, TestData);
        }

        [TestMethod]
        public void NameOK()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //create test data to assign to property
            string TestData = "Cucumber";
            //assign the data to the property
            AStock.Name = TestData;
            //test to see if the two values match
            Assert.AreEqual(AStock.Name, TestData);
        }

        [TestMethod]
        public void DescriptionOK()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //create test data to assign to property
            string TestData = "Some item info";
            //assign the data to the property
            AStock.Description = TestData;
            //test to see if the two values match
            Assert.AreEqual(AStock.Description, TestData);
        }

        [TestMethod]
        public void StockQuantityOK()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //create test data to assign to property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.StockQuantity = TestData;
            //test to see if the two values match
            Assert.AreEqual(AStock.StockQuantity, TestData);
        }

        public void StockItemPriceOK()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //create test data to assign to property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.StockItemPrice = TestData;
            //test to see if the two values match
            Assert.AreEqual(AStock.StockItemPrice, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create test data with a method
            Int32 StockID = 1;
            //invoke the method
            Found = AStock.Find(StockID);
            //test to see tht the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockIDFound()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the searches results
            Boolean Found = false;
            //boolean variable to store the record data is OK
            Boolean OK = true;
            //create test data to use with the method
            Int32 StockID = 1;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the stock ID
            if (AStock.StockID != 1)
            {
                OK = false;
            }
            //test to see that the result is corrrect
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the searches results
            Boolean Found = false;
            //boolean variable to store the record data is OK
            Boolean OK = true;
            //create test data to use with the method
            Int32 StockID = 1;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the Name/property
            if (AStock.Name != "NewExample")
            {
                OK = false;
            }
            //test to see that the result is corrrect
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDescriptionFound()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the searches results
            Boolean Found = false;
            //boolean variable to store the record data is OK
            Boolean OK = true;
            //create test data to use with the method
            Int32 StockID = 1;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the property
            if (AStock.Description != "New item info")
            {
                OK = false;
            }
            //test to see that the result is corrrect
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockQuantityFound()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the searches results
            Boolean Found = false;
            //boolean variable to store the record data is OK
            Boolean OK = true;
            //create test data to use with the method
            Int32 StockID = 1;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the StockQuantity
            if (AStock.StockQuantity != 1)
            {
                OK = false;
            }
            //test to see that the result is corrrect
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStockItemPriceFound()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the searches results
            Boolean Found = false;
            //boolean variable to store the record data is OK
            Boolean OK = true;
            //create test data to use with the method
            Int32 StockID = 1;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the StockItemPrice
            if (AStock.StockItemPrice != 1)
            {
                OK = false;
            }
            //test to see that the result is corrrect
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AStock.Valid(Name, Description, StockQuantity, StockItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = ""; //this should return an error - blank/no characters
            //invoke the method
            Error = AStock.Valid(Name, Description, StockQuantity, StockItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "a"; //this should pass - 1 character
            //invoke the method
            Error = AStock.Valid(Name, Description, StockQuantity, StockItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aa"; //this should pass - 2 characters
            //invoke the method
            Error = AStock.Valid(Name, Description, StockQuantity, StockItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "0123456789012345678901234"; //this should pass - 25 characters
            //invoke the method
            Error = AStock.Valid(Name, Description, StockQuantity, StockItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "0123456789012345678901234567890123456789012345678"; //this should pass - 49 characters
            //invoke the method
            Error = AStock.Valid(Name, Description, StockQuantity, StockItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "01234567890123456789012345678901234567890123456789"; //this should pass - 50 characters
            //invoke the method
            Error = AStock.Valid(Name, Description, StockQuantity, StockItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "012345678901234567890123456789012345678901234567890"; //this should return an error - 51 characters
            //invoke the method
            Error = AStock.Valid(Name, Description, StockQuantity, StockItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789"; //this should return an error - 500 characters
            //invoke the method
            Error = AStock.Valid(Name, Description, StockQuantity, StockItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMinLessOne()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "012345678"; //this should return an error - 9 characters
            //invoke the method
            Error = AStock.Valid(Name, Description, StockQuantity, StockItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMin()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "0123456789"; //this should pass - 10 characters
            //invoke the method
            Error = AStock.Valid(Name, Description, StockQuantity, StockItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMinPlusOne()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "01234567890"; //this should pass - 11 characters
            //invoke the method
            Error = AStock.Valid(Name, Description, StockQuantity, StockItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMid()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "01234567890123456789012345678901234567890123456789"; //this should pass - 50 characters
            //invoke the method
            Error = AStock.Valid(Name, Description, StockQuantity, StockItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxLessOne()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678"; //this should pass - 99 characters
            //invoke the method
            Error = AStock.Valid(Name, Description, StockQuantity, StockItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMax()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789"; //this should pass - 100 characters
            //invoke the method
            Error = AStock.Valid(Name, Description, StockQuantity, StockItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890"; //this should return an error - 101 characters
            //invoke the method
            Error = AStock.Valid(Name, Description, StockQuantity, StockItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionExtremeMax()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789"; //this should return an error - 500 characters
            //invoke the method
            Error = AStock.Valid(Name, Description, StockQuantity, StockItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMinLessOne()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockQuantity = ""; //this should return an error - blank/no characters
            //invoke the method
            Error = AStock.Valid(Name, Description, StockQuantity, StockItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMin()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockQuantity = "1"; //this should pass - 1 character
            //invoke the method
            Error = AStock.Valid(Name, Description, StockQuantity, StockItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMinPlusOne()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockQuantity = "2"; //this should pass - 1 character
            //invoke the method
            Error = AStock.Valid(Name, Description, StockQuantity, StockItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMid()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockQuantity = "500"; //this should pass - 3 characters
            //invoke the method
            Error = AStock.Valid(Name, Description, StockQuantity, StockItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMaxLessOne()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockQuantity = "998"; //this should pass - 3 character
            //invoke the method
            Error = AStock.Valid(Name, Description, StockQuantity, StockItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMax()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockQuantity = "999"; //this should pass - 3 character
            //invoke the method
            Error = AStock.Valid(Name, Description, StockQuantity, StockItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMaxPlusOne()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockQuantity = "1000"; //this should return an error - 4 character
            //invoke the method
            Error = AStock.Valid(Name, Description, StockQuantity, StockItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityExtremeMax()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockQuantity = "10123"; //this should return an error - 5 characters
            //invoke the method
            Error = AStock.Valid(Name, Description, StockQuantity, StockItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockItemPriceMinLessOne()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockItemPrice = ""; //this should return an error - blank/no characters
            //invoke the method
            Error = AStock.Valid(Name, Description, StockQuantity, StockItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockItemPriceMin()
        {
            //create an instance of the class I want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockItemPrice = "1"; //this should pass - 1 character
            //invoke the method
            Error = AStock.Valid(Name, Description, StockQuantity, StockItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

    }
}
