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
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffCollectionListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            List<clsStaff> TestList = new List<clsStaff>();
            //a test object
            clsStaff TestStaff = new clsStaff();
            //assign all the properties
            TestStaff.staffId = 15;
            TestStaff.firstName = "John";
            TestStaff.lastName = "Hathorne";
            TestStaff.dateOfBirth = Convert.ToDateTime("25/09/1996");
            TestStaff.dateOfHire = Convert.ToDateTime("14/02/2020");
            TestStaff.staffRoleId = 3;
            TestStaff.postCode = "LE2 8BA";
            TestStaff.cityOfResidence = "Leicester";
            TestStaff.streetName = "Saffron Crossroads";
            TestStaff.houseNumber = "17a";
            TestStaff.onHoliday = false;
            TestStaff.contactEmail = "John.Hathorne@example.mail";
            TestStaff.contactPhoneNo = "+4492381038919";
            //add the test object to the list
            TestList.Add(TestStaff);
            //assign the list to the collection class
            AllStaff.myStaff = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.myStaff, TestList);
        }
        [TestMethod]

        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //a test object
            clsStaff TestStaff = new clsStaff();
            //assign all the properties
            TestStaff.staffId = 15;
            TestStaff.firstName = "John";
            TestStaff.lastName = "Hathorne";
            TestStaff.dateOfBirth = Convert.ToDateTime("25/09/1996");
            TestStaff.dateOfHire = Convert.ToDateTime("14/02/2020");
            TestStaff.staffRoleId = 3;
            TestStaff.postCode = "LE2 8BA";
            TestStaff.cityOfResidence = "Leicester";
            TestStaff.streetName = "Saffron Crossroads";
            TestStaff.houseNumber = "17a";
            TestStaff.onHoliday = false;
            TestStaff.contactEmail = "John.Hathorne@example.mail";
            TestStaff.contactPhoneNo = "+4492381038919";
            //assign the test object to the collection class
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            List<clsStaff> TestList = new List<clsStaff>();
            //a test object
            clsStaff TestStaff = new clsStaff();
            //assign all the properties
            TestStaff.staffId = 15;
            TestStaff.firstName = "John";
            TestStaff.lastName = "Hathorne";
            TestStaff.dateOfBirth = Convert.ToDateTime("25/09/1996");
            TestStaff.dateOfHire = Convert.ToDateTime("14/02/2020");
            TestStaff.staffRoleId = 3;
            TestStaff.postCode = "LE2 8BA";
            TestStaff.cityOfResidence = "Leicester";
            TestStaff.streetName = "Saffron Crossroads";
            TestStaff.houseNumber = "17a";
            TestStaff.onHoliday = false;
            TestStaff.contactEmail = "John.Hathorne@example.mail";
            TestStaff.contactPhoneNo = "+4492381038919";
            //add the test object to the list
            TestList.Add(TestStaff);
            //assign the list to the collection class
            AllStaff.staffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //a test object
            clsStaff TestStaff = new clsStaff();
            //store the primary key
            Int32 primaryKey = 0;
            //assign all the properties
            TestStaff.staffId = 15;
            TestStaff.firstName = "John";
            TestStaff.lastName = "Hathorne";
            TestStaff.dateOfBirth = Convert.ToDateTime("25/09/1996");
            TestStaff.dateOfHire = Convert.ToDateTime("14/02/2020");
            TestStaff.staffRoleId = 3;
            TestStaff.postCode = "LE2 8BA";
            TestStaff.cityOfResidence = "Leicester";
            TestStaff.streetName = "Saffron Crossroads";
            TestStaff.houseNumber = "17a";
            TestStaff.onHoliday = false;
            TestStaff.contactEmail = "John.Hathorne@example.mail";
            TestStaff.contactPhoneNo = "+4492381038919";
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestStaff;
            //add the record
            primaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestStaff.staffId = primaryKey;
            //find the record
            AllStaff.ThisStaff.Find(primaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
            //delete the recod not to fill the database with duplicate records
            AllStaff.Delete();
        }

        [TestMethod]

        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //a test object
            clsStaff TestStaff = new clsStaff();
            //store the primary key
            Int32 primaryKey = 0;
            //assign all the properties
            TestStaff.staffId = 15;
            TestStaff.firstName = "John";
            TestStaff.lastName = "Hathorne";
            TestStaff.dateOfBirth = Convert.ToDateTime("25/09/1996");
            TestStaff.dateOfHire = Convert.ToDateTime("14/02/2020");
            TestStaff.staffRoleId = 3;
            TestStaff.postCode = "LE2 8BA";
            TestStaff.cityOfResidence = "Leicester";
            TestStaff.streetName = "Saffron Crossroads";
            TestStaff.houseNumber = "17a";
            TestStaff.onHoliday = false;
            TestStaff.contactEmail = "John.Hathorne@example.mail";
            TestStaff.contactPhoneNo = "+4492381038919";
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestStaff;
            //add the record
            primaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestStaff.staffId = primaryKey;
            //find the record
            AllStaff.ThisStaff.Find(primaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record
            Boolean found = AllStaff.ThisStaff.Find(primaryKey);
            //the record must not be found
            Assert.IsFalse(false);
        }

        [TestMethod]

        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //a test object
            clsStaff TestStaff = new clsStaff();
            //store the primary key
            Int32 primaryKey = 0;
            //assign all the properties
            TestStaff.firstName = "John";
            TestStaff.lastName = "Hathorne";
            TestStaff.dateOfBirth = Convert.ToDateTime("25/09/1996");
            TestStaff.dateOfHire = Convert.ToDateTime("14/02/2020");
            TestStaff.staffRoleId = 3;
            TestStaff.postCode = "LE2 8BA";
            TestStaff.cityOfResidence = "Leicester";
            TestStaff.streetName = "Saffron Crossroads";
            TestStaff.houseNumber = "17a";
            TestStaff.onHoliday = false;
            TestStaff.contactEmail = "John.Hathorne@example.mail";
            TestStaff.contactPhoneNo = "+4492381038919";
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestStaff;
            //add the record
            primaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestStaff.staffId = primaryKey;
            //assign all the properties
            TestStaff.firstName = "John";
            TestStaff.lastName = "Hathorne";
            TestStaff.dateOfBirth = Convert.ToDateTime("25/09/1996");
            TestStaff.dateOfHire = Convert.ToDateTime("14/02/2020");
            TestStaff.staffRoleId = 3;
            TestStaff.postCode = "LE2 8BA";
            TestStaff.cityOfResidence = "Leicester";
            TestStaff.streetName = "Saffron Crossroads";
            TestStaff.houseNumber = "17a";
            TestStaff.onHoliday = false;
            TestStaff.contactEmail = "John.Hathorne@example.mail";
            TestStaff.contactPhoneNo = "+4492381038919";
            //assign the test object to the real object
            AllStaff.ThisStaff = TestStaff;
            //update data of the real object
            AllStaff.update();
            //find the record
            AllStaff.ThisStaff.Find(primaryKey);
            //check if the data matches
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
            //delete the record not to fill the database with duplicate records
            AllStaff.Delete();
        }

        [TestMethod]
        public void ReportByLastNameMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.ReportByLastName("");
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        public void ReportByLastNameNoneFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.ReportByLastName("ASPSPASPAPS");
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByLastNameTestDataFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            Boolean OK = true;
            FilteredStaff.ReportByLastName("Brickzzz");
            if(FilteredStaff.Count == 2)
            {
                if(FilteredStaff.staffList[0].staffId != 8)
                {
                    OK = false;
                }

                if(FilteredStaff.staffList[1].staffId != 10)
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
