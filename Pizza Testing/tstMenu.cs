﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaClasses;

namespace Pizza_Testing
{
    [TestClass]
    public class tstMenu
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsMenu AMenu = new clsMenu();
            //test to see that it exists
            Assert.IsNotNull(AMenu);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsMenu AMenu = new clsMenu();
            //create some test data to assign to the property
            String TestData = "Cheese";
            //assign the data to the property
            AMenu.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMenu.Name, TestData);
        }

        [TestMethod]
        public void MenuItemIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsMenu AMenu = new clsMenu();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AMenu.MenuItemID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMenu.MenuItemID, TestData);
        }

        [TestMethod]
        public void DescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsMenu AMenu = new clsMenu();
            //create some test data to assign to the property
            String TestData = "SUPER CHEESY all natural cheese!";
            //assign the data to the property
            AMenu.Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMenu.Description, TestData);
        }

        [TestMethod]
        public void RecipeIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsMenu AMenu = new clsMenu();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AMenu.RecipeID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMenu.RecipeID, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsMenu AMenu = new clsMenu();
            //create some test data to assign to the property
            Double TestData = 2.5;
            //assign the data to the property
            AMenu.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMenu.Price, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //crerate an instance of the class we want to create
            clsMenu AMenu = new clsMenu();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 MenuID = 1;
            //invoke the method 
            Found = AMenu.Find(MenuID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
    }
}
