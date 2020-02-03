using System;
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
    }
}
