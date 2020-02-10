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
        public void staffCollectionListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection allStaff = new clsStaffCollection();
            //create some test data to assign to the property
            List<clsStaff> TestList = new List<clsStaff>();
            //a test object
            clsStaff testStaff = new clsStaff();
            //assign all the properties
            testStaff.staffAddress = "Saffron Crossroads 80a, LE2 9BP Leicester";
            testStaff.staffHiredOn = Convert.ToDateTime("02/02/2020");
            testStaff.staffName = "John Hathorne";
            testStaff.staffRoleId = 3;
            testStaff.staffId = 15;
            //add the test object to the list
            TestList.Add(testStaff);
            //assign the list to the collection class
            allStaff.myStaff = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(allStaff.myStaff, TestList);
        }

        [TestMethod]
        public void countPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection allStaff = new clsStaffCollection();
            //Count should be 0 when we initialize the property
            Int32 testData = 0;
            //test to see that the two values are the same
            Assert.AreEqual(allStaff.Count, testData);
        }

        [TestMethod]

        public void thisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection allStaff = new clsStaffCollection();
            //a test object
            clsStaff testStaff = new clsStaff();
            //assign all the properties
            testStaff.staffAddress = "Saffron Crossroads 80a, LE2 9BP Leicester";
            testStaff.staffHiredOn = Convert.ToDateTime("02/02/2020");
            testStaff.staffName = "John Hathorne";
            testStaff.staffRoleId = 3;
            testStaff.staffId = 15;
            //assign the test object to the collection class
            allStaff.ThisStaff = testStaff;
            //test to see that the two values are the same
            Assert.AreEqual(allStaff.ThisStaff, testStaff);
            //asdassad
        }

        [TestMethod]
        public void listAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection allStaff = new clsStaffCollection();
            //create some test data to assign to the property
            List<clsStaff> TestList = new List<clsStaff>();
            //a test object
            clsStaff testStaff = new clsStaff();
            //assign all the properties
            testStaff.staffAddress = "Saffron Crossroads 80a, LE2 9BP Leicester";
            testStaff.staffHiredOn = Convert.ToDateTime("02/02/2020");
            testStaff.staffName = "John Hathorne";
            testStaff.staffRoleId = 3;
            testStaff.staffId = 15;
            //add the test object to the list
            TestList.Add(testStaff);
            //assign the list to the collection class
            allStaff.staffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(allStaff.Count, TestList.Count);
        }


    }
}
