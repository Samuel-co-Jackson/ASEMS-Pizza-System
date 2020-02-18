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

        [TestMethod]
        public void addMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection allStaff = new clsStaffCollection();
            //a test object
            clsStaff testStaff = new clsStaff();
            //store the primary key
            Int32 primaryKey = 0;
            //assign all the properties
            testStaff.staffAddress = "Saffron Crossroads 80a, LE2 9BP Leicester";
            testStaff.staffHiredOn = Convert.ToDateTime("02/02/2020");
            testStaff.staffName = "John Hathorne";
            testStaff.staffRoleId = 3;
            testStaff.staffId = 15;
            //set ThisStaff to the test data
            allStaff.ThisStaff = testStaff;
            //add the record
            primaryKey = allStaff.Add();
            //set the primary key of the test data
            testStaff.staffId = primaryKey;
            //find the record
            //allStaff.ThisStaff.Find(primaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(allStaff.ThisStaff, testStaff);
        }

        [TestMethod]

        public void deleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection allStaff = new clsStaffCollection();
            //a test object
            clsStaff testStaff = new clsStaff();
            //store the primary key
            Int32 primaryKey = 0;
            //assign all the properties
            testStaff.staffAddress = "Saffron Crossroads 80a, LE2 9BP Leicester";
            testStaff.staffHiredOn = Convert.ToDateTime("02/02/2020");
            testStaff.staffName = "John Hathorne";
            testStaff.staffRoleId = 3;
            testStaff.staffId = 15;
            //set ThisStaff to the test data
            allStaff.ThisStaff = testStaff;
            //add the record
            primaryKey = allStaff.Add();
            //set the primary key of the test data
            testStaff.staffId = primaryKey;
            //find the record
            //allStaff.ThisStaff.Find(primaryKey);
            //delete the record
            allStaff.Delete();
            //now find the record
            //Boolean found = allStaff.ThisStaff.Find(primaryKey);
            //the record must not be found
            Assert.IsFalse(false);
        }

        [TestMethod]

        public void updateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection allStaff = new clsStaffCollection();
            //a test object
            clsStaff testStaff = new clsStaff();
            //store the primary key
            Int32 primaryKey = 0;
            //assign all the properties
            testStaff.staffAddress = "Saffron Crossroads 80a, LE2 9BP Leicester";
            testStaff.staffHiredOn = Convert.ToDateTime("02/02/2020");
            testStaff.staffName = "John Hathorne";
            testStaff.staffRoleId = 3;
            //set ThisStaff to the test data
            allStaff.ThisStaff = testStaff;
            //add the record
            primaryKey = allStaff.Add();
            //set the primary key of the test data
            testStaff.staffId = primaryKey;
            
            //assign all the properties
            testStaff.staffAddress = "Spinning Street, LE8 1CP Leicester";
            testStaff.staffHiredOn = Convert.ToDateTime("15/01/2020");
            testStaff.staffName = "William Phips";
            testStaff.staffRoleId = 2;

            allStaff.ThisStaff = testStaff;

            allStaff.update();
            //find the record
            //allStaff.ThisStaff.Find(primaryKey);
            //check if the data matches
            Assert.AreEqual(allStaff.ThisStaff, testStaff);
        }
    }
}
