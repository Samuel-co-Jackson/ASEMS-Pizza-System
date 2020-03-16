using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaClasses;

namespace Pizza_Testing
{
    [TestClass]
    public class tstMenu
    {

        //good test data
        string Name = "Cheese Pizza";
        string Description = "The classic we all love";
        Int32 RecipeID = 1;
        Double Price = 5.5;

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

        [TestMethod]
        public void ValidMethodOK()
        {
            //crerate an instance of the class we want to create
            clsMenu AMenu = new clsMenu();
            //string for error 
            String Error = "";
            //invoke method
            Error = AMenu.Valid(Name, Description, RecipeID, Price);
            //test results
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            //crerate an instance of the class we want to create
            clsMenu AMenu = new clsMenu();
            //string for error 
            String Error = "";
            //test data
            string Name = "";
            //invoke method
            Error = AMenu.Valid(Name, Description, RecipeID, Price);
            //test results
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            //crerate an instance of the class we want to create
            clsMenu AMenu = new clsMenu();
            //string for error 
            String Error = "";
            //test data
            string Name = "a";
            //invoke method
            Error = AMenu.Valid(Name, Description, RecipeID, Price);
            //test results
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            //crerate an instance of the class we want to create
            clsMenu AMenu = new clsMenu();
            //string for error 
            String Error = "";
            //test data
            string Name = "01234567890123456789";
            //invoke method
            Error = AMenu.Valid(Name, Description, RecipeID, Price);
            //test results
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            //crerate an instance of the class we want to create
            clsMenu AMenu = new clsMenu();
            //string for error 
            String Error = "";
            //test data
            string Name = "012345678901234567890";
            //invoke method
            Error = AMenu.Valid(Name, Description, RecipeID, Price);
            //test results
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMinLessOne()
        {
            //crerate an instance of the class we want to create
            clsMenu AMenu = new clsMenu();
            //string for error 
            String Error = "";
            //test data
            string Description = "";
            //invoke method
            Error = AMenu.Valid(Name, Description, RecipeID, Price);
            //test results
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMin()
        {
            //crerate an instance of the class we want to create
            clsMenu AMenu = new clsMenu();
            //string for error 
            String Error = "";
            //test data
            string Description = "a";
            //invoke method
            Error = AMenu.Valid(Name, Description, RecipeID, Price);
            //test results
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMax()
        {
            //crerate an instance of the class we want to create
            clsMenu AMenu = new clsMenu();
            //string for error 
            String Error = "";
            //test data
            string Description = "0123456789012345678901234567890123456789";
            //invoke method
            Error = AMenu.Valid(Name, Description, RecipeID, Price);
            //test results
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            //crerate an instance of the class we want to create
            clsMenu AMenu = new clsMenu();
            //string for error 
            String Error = "";
            //test data
            string Description = "01234567890123456789012345678901234567890";
            //invoke method
            Error = AMenu.Valid(Name, Description, RecipeID, Price);
            //test results
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RecipeIDMinLessOne()
        {
            //crerate an instance of the class we want to create
            clsMenu AMenu = new clsMenu();
            //string for error 
            String Error = "";
            //test data
            Int32 RecipeID = -1;
            //invoke method
            Error = AMenu.Valid(Name, Description, RecipeID, Price);
            //test results
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RecipeIDMin()
        {
            //crerate an instance of the class we want to create
            clsMenu AMenu = new clsMenu();
            //string for error 
            String Error = "";
            //test data
            Int32 RecipeID = 0;
            //invoke method
            Error = AMenu.Valid(Name, Description, RecipeID, Price);
            //test results
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            //crerate an instance of the class we want to create
            clsMenu AMenu = new clsMenu();
            //string for error 
            String Error = "";
            //test data
            Double Price = -1;
            //invoke method
            Error = AMenu.Valid(Name, Description, RecipeID, Price);
            //test results
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceIDMin()
        {
            //crerate an instance of the class we want to create
            clsMenu AMenu = new clsMenu();
            //string for error 
            String Error = "";
            //test data
            Double Price = 0;
            //invoke method
            Error = AMenu.Valid(Name, Description, RecipeID, Price);
            //test results
            Assert.AreEqual(Error, "");
        }
    }
}
