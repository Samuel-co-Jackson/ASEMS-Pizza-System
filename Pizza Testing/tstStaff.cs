using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaClasses;

namespace Pizza_Testing
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(aStaff);
        }

        [TestMethod]
        public void staffIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 15;
            //assign the data to the property
            aStaff.staffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.staffId, TestData);
        }

        [TestMethod]
        public void staffRoleIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 2;
            //assign the data to the property
            aStaff.staffRoleId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.staffRoleId, TestData);
        }

        [TestMethod]
        public void firstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "John";
            //assign the data to the property
            aStaff.firstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.firstName, TestData);
        }

        [TestMethod]
        public void lastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Hathorne";
            //assign the data to the property
            aStaff.lastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.lastName, TestData);
        }

        [TestMethod]
        public void dateOfBirthPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = Convert.ToDateTime("17/09/1992");
            //assign the data to the property
            aStaff.dateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.dateOfBirth, TestData);
        }

        [TestMethod]
        public void dateOfHirePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now;
            //assign the data to the property
            aStaff.dateOfHire = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.dateOfHire, TestData);
        }

        [TestMethod]
        public void postcodePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "LE2 8BA";
            //assign the data to the property
            aStaff.postCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.postCode, TestData);
        }

        [TestMethod]
        public void cityOfResidencePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Leicester";
            //assign the data to the property
            aStaff.cityOfResidence = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.cityOfResidence, TestData);
        }

        [TestMethod]
        public void streetNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "New York Avenue";
            //assign the data to the property
            aStaff.streetName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.streetName, TestData);
        }

        [TestMethod]
        public void houseNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "15b";
            //assign the data to the property
            aStaff.houseNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.houseNumber, TestData);
        }

        [TestMethod]
        public void contactEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Speedy@example.com";
            //assign the data to the property
            aStaff.contactEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.contactEmail, TestData);
        }

        [TestMethod]
        public void contactPhoneNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "+4495673404219";
            //assign the data to the property
            aStaff.contactPhoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.contactPhoneNo, TestData);
        }

        [TestMethod]
        public void onHolidayPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = false;
            //assign the data to the property
            aStaff.onHoliday = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.onHoliday, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Int32 StaffId = 2;
            Found = AStaff.Find(StaffId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffNotFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 2;
            Found = AStaff.Find(StaffId);
            if(AStaff.staffId != StaffId)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
