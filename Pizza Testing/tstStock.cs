using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaClasses;

namespace Pizza_Testing
{
    [TestClass]
    public class tstStock
    {
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
            Int32 StockID = 110;
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
            Int32 StockID = 110;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the stock ID
            if (AStock.StockID != 110)
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
            Int32 StockID = 110;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the Name/property
            if (AStock.Name != "TestyTestyData")
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
            Int32 StockID = 110;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the property
            if (AStock.Description != "Jjjj")
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
            Int32 StockID = 110;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the StockQuantity
            if (AStock.StockQuantity != 22)
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
            Int32 StockID = 110;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the StockItemPrice
            if (AStock.StockItemPrice != 8)
            {
                OK = false;
            }
            //test to see that the result is corrrect
            Assert.IsTrue(OK);
        }
    }
}
