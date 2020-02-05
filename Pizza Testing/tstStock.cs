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
            string TestData = "Cucumber";
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
    }//srghwrwrgt
}
