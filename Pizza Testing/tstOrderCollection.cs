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
            //sssssll
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
            TestItem.EmployeeID = 1;
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
            TestOrder.EmployeeID = 1;
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
            TestItem.EmployeeID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderStatus = "Cooking";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
    }
}
