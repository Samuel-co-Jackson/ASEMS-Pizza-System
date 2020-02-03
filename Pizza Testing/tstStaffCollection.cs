using System;
using System.Collections.Generic;
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

        [TestMethod]
        public void staffCollectionListPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection allStaff = new clsStaffCollection();
            //create some test data to assign to the property
            List<clsStaff> TestData = new List<clsStaff>();
            //assign the data to the property
            allStaff.myStaff = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(allStaff.myStaff, TestData);
        }
    }
}
