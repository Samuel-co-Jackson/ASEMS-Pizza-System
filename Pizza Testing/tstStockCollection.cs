using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaClasses;
using System.Collections.Generic;

namespace Pizza_Testing
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class I want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //test to see if it exists
            Assert.IsNotNull(AllStocks);
        }

        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the class I want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create test data to assign to property
            //for the collection class the data is a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create item test data 
            clsStock TestItem = new clsStock();
            //set the properties
            TestItem.Name = "Cucumber";
            TestItem.Description = "Some item info";
            TestItem.StockQuantity = 1;
            TestItem.StockItemPrice = 1;
            //add item to Test List
            TestList.Add(TestItem);
            //assign the data to the property
            AllStocks.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.StockList, TestList);
        }

        [TestMethod]
        public void StockPropertyOK()
        {
            //create an instance of the class I want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create test data to assign to property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllStocks.Count = SomeCount;
            //test to see if the two values match
            Assert.AreEqual(AllStocks.Count, SomeCount);
        }

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the class I want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create test data to assign to property
            clsStock TestStock = new clsStock();
            //set the properties
            TestStock.Name = "EXample";
            TestStock.Description = "Some item info";
            TestStock.StockQuantity = 1;
            TestStock.StockItemPrice = 1;
            //assign the data to the property
            AllStocks.ThisStock = TestStock;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class I want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create test data to assign to the property
            //for the collection class the data is a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create item test data 
            clsStock TestItem = new clsStock();
            //set the properties
            TestItem.Name = "Example";
            TestItem.Description = "Some item info";
            TestItem.StockQuantity = 1;
            TestItem.StockItemPrice = 1;
            //add item to Test List
            TestList.Add(TestItem);
            //assign the data to the property
            AllStocks.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class I want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.Count, 2);
        }
    }
}
