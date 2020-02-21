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
            testStaff.staffId = 15;
            testStaff.firstName = "John";
            testStaff.lastName = "Hathorne";
            testStaff.dateOfBirth = Convert.ToDateTime("25/09/1996");
            testStaff.dateOfHire = Convert.ToDateTime("14/02/2020");
            testStaff.staffRoleId = 3;
            testStaff.postCode = "LE2 8BA";
            testStaff.cityOfResidence = "Leicester";
            testStaff.streetName = "Saffron Crossroads";
            testStaff.houseNumber = "17a";
            testStaff.onHoliday = false;
            testStaff.contactEmail = "John.Hathorne@example.mail";
            testStaff.contactPhoneNo = "+4492381038919";
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
            testStaff.staffId = 15;
            testStaff.firstName = "John";
            testStaff.lastName = "Hathorne";
            testStaff.dateOfBirth = Convert.ToDateTime("25/09/1996");
            testStaff.dateOfHire = Convert.ToDateTime("14/02/2020");
            testStaff.staffRoleId = 3;
            testStaff.postCode = "LE2 8BA";
            testStaff.cityOfResidence = "Leicester";
            testStaff.streetName = "Saffron Crossroads";
            testStaff.houseNumber = "17a";
            testStaff.onHoliday = false;
            testStaff.contactEmail = "John.Hathorne@example.mail";
            testStaff.contactPhoneNo = "+4492381038919";
            //assign the test object to the collection class
            allStaff.ThisStaff = testStaff;
            //test to see that the two values are the same
            Assert.AreEqual(allStaff.ThisStaff, testStaff);
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
            testStaff.staffId = 15;
            testStaff.firstName = "John";
            testStaff.lastName = "Hathorne";
            testStaff.dateOfBirth = Convert.ToDateTime("25/09/1996");
            testStaff.dateOfHire = Convert.ToDateTime("14/02/2020");
            testStaff.staffRoleId = 3;
            testStaff.postCode = "LE2 8BA";
            testStaff.cityOfResidence = "Leicester";
            testStaff.streetName = "Saffron Crossroads";
            testStaff.houseNumber = "17a";
            testStaff.onHoliday = false;
            testStaff.contactEmail = "John.Hathorne@example.mail";
            testStaff.contactPhoneNo = "+4492381038919";
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
            testStaff.staffId = 15;
            testStaff.firstName = "John";
            testStaff.lastName = "Hathorne";
            testStaff.dateOfBirth = Convert.ToDateTime("25/09/1996");
            testStaff.dateOfHire = Convert.ToDateTime("14/02/2020");
            testStaff.staffRoleId = 3;
            testStaff.postCode = "LE2 8BA";
            testStaff.cityOfResidence = "Leicester";
            testStaff.streetName = "Saffron Crossroads";
            testStaff.houseNumber = "17a";
            testStaff.onHoliday = false;
            testStaff.contactEmail = "John.Hathorne@example.mail";
            testStaff.contactPhoneNo = "+4492381038919";
            //set ThisStaff to the test data
            allStaff.ThisStaff = testStaff;
            //add the record
            primaryKey = allStaff.Add();
            //set the primary key of the test data
            testStaff.staffId = primaryKey;
            //find the record
            allStaff.ThisStaff.Find(primaryKey);
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
            testStaff.staffId = 15;
            testStaff.firstName = "John";
            testStaff.lastName = "Hathorne";
            testStaff.dateOfBirth = Convert.ToDateTime("25/09/1996");
            testStaff.dateOfHire = Convert.ToDateTime("14/02/2020");
            testStaff.staffRoleId = 3;
            testStaff.postCode = "LE2 8BA";
            testStaff.cityOfResidence = "Leicester";
            testStaff.streetName = "Saffron Crossroads";
            testStaff.houseNumber = "17a";
            testStaff.onHoliday = false;
            testStaff.contactEmail = "John.Hathorne@example.mail";
            testStaff.contactPhoneNo = "+4492381038919";
            //set ThisStaff to the test data
            allStaff.ThisStaff = testStaff;
            //add the record
            primaryKey = allStaff.Add();
            //set the primary key of the test data
            testStaff.staffId = primaryKey;
            //find the record
            allStaff.ThisStaff.Find(primaryKey);
            //delete the record
            allStaff.Delete();
            //now find the record
            Boolean found = allStaff.ThisStaff.Find(primaryKey);
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
            testStaff.firstName = "John";
            testStaff.lastName = "Hathorne";
            testStaff.dateOfBirth = Convert.ToDateTime("25/09/1996");
            testStaff.dateOfHire = Convert.ToDateTime("14/02/2020");
            testStaff.staffRoleId = 3;
            testStaff.postCode = "LE2 8BA";
            testStaff.cityOfResidence = "Leicester";
            testStaff.streetName = "Saffron Crossroads";
            testStaff.houseNumber = "17a";
            testStaff.onHoliday = false;
            testStaff.contactEmail = "John.Hathorne@example.mail";
            testStaff.contactPhoneNo = "+4492381038919";
            //set ThisStaff to the test data
            allStaff.ThisStaff = testStaff;
            //add the record
            primaryKey = allStaff.Add();
            //set the primary key of the test data
            testStaff.staffId = primaryKey;
            //assign all the properties
            testStaff.firstName = "John";
            testStaff.lastName = "Hathorne";
            testStaff.dateOfBirth = Convert.ToDateTime("25/09/1996");
            testStaff.dateOfHire = Convert.ToDateTime("14/02/2020");
            testStaff.staffRoleId = 3;
            testStaff.postCode = "LE2 8BA";
            testStaff.cityOfResidence = "Leicester";
            testStaff.streetName = "Saffron Crossroads";
            testStaff.houseNumber = "17a";
            testStaff.onHoliday = false;
            testStaff.contactEmail = "John.Hathorne@example.mail";
            testStaff.contactPhoneNo = "+4492381038919";
            //assign the test object to the real object
            allStaff.ThisStaff = testStaff;
            //update data of the real object
            allStaff.update();
            //find the record
            allStaff.ThisStaff.Find(primaryKey);
            //check if the data matches
            Assert.AreEqual(allStaff.ThisStaff, testStaff);
        }

        [TestMethod]
        public void ReportByLastNameMethodOK()
        {
            clsStaffCollection allStaff = new clsStaffCollection();
            clsStaffCollection filteredStaff = new clsStaffCollection();
            filteredStaff.ReportByLastName("");
            Assert.AreEqual(allStaff.Count, filteredStaff.Count);
        }

        public void ReportByLastNameNoneFound()
        {
            clsStaffCollection filteredStaff = new clsStaffCollection();
            filteredStaff.ReportByLastName("ASPSPASPAPS");
            Assert.AreEqual(0, filteredStaff.Count);
        }

        [TestMethod]
        public void ReportByLastNameTestDataFound()
        {
            clsStaffCollection filteredStaff = new clsStaffCollection();
            Boolean OK = true;
            filteredStaff.ReportByLastName("Brickzzz");
            if(filteredStaff.Count == 2)
            {
                if(filteredStaff.staffList[0].staffId != 8)
                {
                    OK = false;
                }

                if(filteredStaff.staffList[1].staffId != 10)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}
