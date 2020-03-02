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
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 15;
            //assign the data to the property
            AStaff.staffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.staffId, TestData);
        }

        [TestMethod]
        public void StaffRoleIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 2;
            //assign the data to the property
            AStaff.staffRoleId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.staffRoleId, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "John";
            //assign the data to the property
            AStaff.firstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.firstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Hathorne";
            //assign the data to the property
            AStaff.lastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.lastName, TestData);
        }

        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = Convert.ToDateTime("17/09/1992");
            //assign the data to the property
            AStaff.dateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.dateOfBirth, TestData);
        }

        [TestMethod]
        public void DateOfHirePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now;
            //assign the data to the property
            AStaff.dateOfHire = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.dateOfHire, TestData);
        }

        [TestMethod]
        public void PostcodePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "LE2 8BA";
            //assign the data to the property
            AStaff.postCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.postCode, TestData);
        }

        [TestMethod]
        public void CityOfResidencePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Leicester";
            //assign the data to the property
            AStaff.cityOfResidence = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.cityOfResidence, TestData);
        }

        [TestMethod]
        public void StreetNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "New York Avenue";
            //assign the data to the property
            AStaff.streetName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.streetName, TestData);
        }

        [TestMethod]
        public void HouseNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "15b";
            //assign the data to the property
            AStaff.houseNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.houseNumber, TestData);
        }

        [TestMethod]
        public void ContactEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Speedy@example.com";
            //assign the data to the property
            AStaff.contactEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.contactEmail, TestData);
        }

        [TestMethod]
        public void ContactPhoneNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "+4495673404219";
            //assign the data to the property
            AStaff.contactPhoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.contactPhoneNo, TestData);
        }

        [TestMethod]
        public void OnHolidayPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = false;
            //assign the data to the property
            AStaff.onHoliday = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.onHoliday, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Int32 StaffId = 8;
            Found = AStaff.Find(StaffId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffNotFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 8;
            Found = AStaff.Find(StaffId);
            if(AStaff.staffId != StaffId)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
