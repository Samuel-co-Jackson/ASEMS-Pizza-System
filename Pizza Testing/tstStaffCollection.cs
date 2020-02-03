using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaClasses;

namespace Pizza_Testing
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection allStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(allStaff);
        }
    }
}
