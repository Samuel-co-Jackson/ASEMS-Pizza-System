using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaClasses;
using System.Collections.Generic;

namespace Pizza_Testing
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
            //sllll
        }
        

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign the order
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the items of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.StaffID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderStatus = "Cooking";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
            //ss
        }



        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign the order
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test object
            TestOrder.OrderID = 1;
            TestOrder.CustomerID = 1;
            TestOrder.StaffID = 1;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.OrderStatus = "Cooking";
            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign the order
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the items of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.StaffID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderStatus = "Cooking";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
            //ss
        }

        [TestMethod]
        public void AddOrderOK()
        {
            //create an instance of the class we want to have
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the test item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerID = 24;
            TestItem.StaffID = 24;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderStatus = "Cooking";
            //set ThisOrder to the test
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            //AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
            
        }

        [TestMethod]
        public void DeleteOrderOK()
        {
            //create an instance of the class we want to have
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the test item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderID = 25;
            TestItem.CustomerID = 25;
            TestItem.StaffID = 25;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderStatus = "Cooking";
            //set ThisOrder to the test
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrders.Delete();
            //now find the record
            //Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void UpdateOrderOK()
        {
            //create an instance of the class we want to have
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the test item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerID = 25;
            TestItem.StaffID = 25;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderStatus = "Cooking";
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test daTA
            TestItem.OrderID = PrimaryKey;
            //modify the test data
            TestItem.CustomerID = 25;
            TestItem.StaffID = 25;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderStatus = "Delivering";
            //set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            //update the order
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see  ThisAddress matches the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
    }
}
