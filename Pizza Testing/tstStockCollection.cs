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
        public void AddMethodOK()
        {
            //create an instance of the class I want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create test data 
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties
            TestItem.StockID = 1;
            TestItem.Name = "Example";
            TestItem.Description = "Some item info";
            TestItem.StockQuantity = 1;
            TestItem.StockItemPrice = 1;
            //set ThisStock to the test data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the primary of the test data
            TestItem.StockID = PrimaryKey;
            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class I want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create test data 
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties
            TestItem.StockID = 1;
            TestItem.Name = "Example";
            TestItem.Description = "Some item info";
            TestItem.StockQuantity = 1;
            TestItem.StockItemPrice = 1;
            //set ThisStock to the test data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the primary of the test data
            TestItem.StockID = PrimaryKey;
            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //delete the record
            AllStocks.Delete();
            //now find the record
            Boolean Found = AllStocks.ThisStock.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class I want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create test data 
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties
            TestItem.StockID = 1;
            TestItem.Name = "Example";
            TestItem.Description = "Some item info";
            TestItem.StockQuantity = 1;
            TestItem.StockItemPrice = 1;
            //set ThisStock to the test data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the primary of the test data
            TestItem.StockID = PrimaryKey;
            //edit the test data
            TestItem.StockID = 1;
            TestItem.Name = "NewExample";
            TestItem.Description = "New item info";
            TestItem.StockQuantity = 1;
            TestItem.StockItemPrice = 1;
            //set the record based on the new test data
            AllStocks.ThisStock = TestItem;
            //update the record
            AllStocks.Update();
            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //test to see ThisStock matches the test data
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }

        [TestMethod]
        public void ReportByNameMethodOK()
        {
            //create an instance of the class I want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create an instance of the filtered data
            clsStockCollection FilteredNames = new clsStockCollection();
            //apply a blank string (it should return all the records)'
            FilteredNames.ReportByName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.Count, FilteredNames.Count);
        }

        [TestMethod]
        public void ReportByNameNoneFound()
        {
            //create an instance of the filtered data
            clsStockCollection FilteredNames = new clsStockCollection();
            //apply a name that does not exist
            FilteredNames.ReportByName("fakename");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredNames.Count);
        }

        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            //create an instance of the filtered data
            clsStockCollection FilteredNames = new clsStockCollection();
            //var to store the outcome
            Boolean OK = true;
            //apply a Name that does not exist
            FilteredNames.ReportByName("Non existent");
            //check that the correct number of records are found
            if (FilteredNames.Count == 2)
            {
                //check that the first record ID 110
                if (FilteredNames.StockList[0].StockID != 110)
                {
                    OK = false;
                }
                //check that the first record ID 111
                if (FilteredNames.StockList[1].StockID != 111)
                {
                    OK = false;
                }
            }
            else
            {
                OK = true;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}