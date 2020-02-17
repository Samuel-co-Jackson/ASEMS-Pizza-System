using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaClasses;
using System.Collections.Generic;

namespace Pizza_Testing
{
    [TestClass]
    public class tstMenuCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsMenuCollection AllMenu = new clsMenuCollection();
            //test to see that it exists
            Assert.IsNotNull(AllMenu);
        }

        [TestMethod]
        public void MenuListOK()
        {
            //create an instance of the class we want to create
            clsMenuCollection AllMenu = new clsMenuCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsMenu> TestList = new List<clsMenu>();
            //add an item to the list 
            //create the item of test data
            clsMenu TestItem = new clsMenu();
            //set its properties
            TestItem.MenuItemID = 1;
            TestItem.Name = "Classic Cheese";
            TestItem.Description = "SUPER CHEESY GOOD!";
            TestItem.RecipeID = 3;
            TestItem.Price = 9.9;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllMenu.MenuList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllMenu.MenuList, TestList);
        }

        

        [TestMethod]
        public void ThisMenuItemPropertyOK()
        {
            //create an instance of the class we want to create
            clsMenuCollection AllMenu = new clsMenuCollection();
            //create the item of test data
            clsMenu TestMenu = new clsMenu();
            //set its properties
            TestMenu.MenuItemID = 1;
            TestMenu.Name = "Classic Cheese";
            TestMenu.Description = "SUPER CHEESY GOOD!";
            TestMenu.RecipeID = 3;
            TestMenu.Price = 9.9;
            //assign the data to the property
            AllMenu.ThisMenuItem = TestMenu;
            //test they're the same
            Assert.AreEqual(AllMenu.ThisMenuItem, TestMenu);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsMenuCollection AllMenu = new clsMenuCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsMenu> TestList = new List<clsMenu>();
            //add an item to the list 
            //create the item of test data
            clsMenu TestItem = new clsMenu();
            //set its properties
            TestItem.MenuItemID = 1;
            TestItem.Name = "Classic Cheese";
            TestItem.Description = "SUPER CHEESY GOOD!";
            TestItem.RecipeID = 3;
            TestItem.Price = 9.9;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllMenu.MenuList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllMenu.Count, TestList.Count);
        }
    }
}
