using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaClasses;

namespace Pizza_Testing
{
    [TestClass]
    public class tstStaff
    {

        //good test data
        //create some data to pass to the method
        String firstName = "John";
        String lastName = "Hathorne";
        DateTime dateOfBirth = Convert.ToDateTime("25/09/1996");
        DateTime dateOfHire = Convert.ToDateTime("14/02/2020");
        Int32 staffRoleId = 3;
        String postCode = "LE2 8BA";
        String cityOfResidence = "Leicester";
        String streetName = "Saffron Crossroads";
        String houseNumber = "17a";
        String contactEmail = "John.Hathorne@example.mail";
        String contactPhoneNo = "+4492381038919";

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
            if (AStaff.staffId != StaffId)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            Error = AStaff.Valid(firstName, lastName,
                dateOfBirth, dateOfHire,
                staffRoleId,
                postCode, cityOfResidence, streetName, houseNumber,
                contactEmail, contactPhoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            firstName = "A"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            firstName = "Jo"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            firstName = "JohnJohnJohnJohnJohnJohnJohnJ"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            firstName = "JohnJohnJohnJohnJohnJohnJohnJo"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            firstName = "JohnJohnJohnJohnJohnJohnJohnJoh"; //this should fail
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            firstName = "JohnJohnJohnJoh"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            firstName = firstName.PadRight(500, 'j'); //this should fail
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            lastName = "O"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            lastName = "Ro"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            lastName = "HathorneHathorneHathorneHathorneHathorneHathorneH"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            lastName = "HathorneHathorneHathorneHathorneHathorneHathorneHa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            lastName = "HathorneHathorneHathorneHathorneHathorneHathorneHat"; //this should fail
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            lastName = "HathorneHathorneHathorneH"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            lastName = lastName.PadRight(500, 'H'); //this should fail
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            postCode = "S11AA"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            postCode = "S1 1AA"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            postCode = "LE2 8BALE"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            postCode = "LE2 8BALE2"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            postCode = "LE2 8BALE2 "; //this should fail
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            postCode = "LE2 8B"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            postCode = postCode.PadRight(500, 'H'); //this should fail
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StreetNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            streetName = "Saff"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            streetName = "Saffr"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            streetName = "Saffron CrossroadsSaffron Crossroads Sa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            streetName = "Saffron CrossroadsSaffron Crossroads Saf"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            streetName = "Saffron CrossroadsSaffron Crossroads Saff"; //this should fail
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StreetNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            streetName = "Saffron Crossroads"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            streetName = streetName.PadRight(500, 'H'); //this should fail
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HouseNumberMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            houseNumber = "7"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            houseNumber = "15"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            houseNumber = "GregsHous"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNumberMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            houseNumber = "GregsHouse"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            houseNumber = "Gregs House"; //this should fail
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HouseNumberMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            houseNumber = "519/a"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNumberExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            houseNumber = streetName.PadRight(500, 'H'); //this should fail
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CityOfResidenceMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            cityOfResidence = "Ya"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityOfResidenceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            cityOfResidence = "Yal"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityOfResidenceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            cityOfResidence = "Leicester Leicester Leicester Leicester Leicester Leicester"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityOfResidenceMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            cityOfResidence = "Leicester Leicester Leicester Leicester Leicester Leicester "; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityOfResidenceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            cityOfResidence = "Leicester Leicester Leicester Leicester Leicester Leicester L"; //this should fail
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CityOfResidenceMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            cityOfResidence = "Leicester Leicester Leicester "; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityOfResidenceExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            cityOfResidence = streetName.PadRight(500, 'H'); //this should fail
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContactEmailMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            contactEmail = "B@g.cn"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            contactEmail = "Jo@g.cn"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            contactEmail = "SuperSuperSuperSuperSup@o2.pl"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactEmailMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            contactEmail = "SuperSuperSuperSuperSupe@o2.pl"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            contactEmail = "SuperSuperSuperSuperSuper@o2.pl"; //this should fail
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContactEmailMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            contactEmail = "SuperSuperSu@o2.pl"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactEmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            contactEmail = streetName.PadRight(500, 'H'); //this should fail
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContactPhoneNoMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            contactPhoneNo = "49128471"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactPhoneNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            contactPhoneNo = "810372819"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactPhoneNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            contactPhoneNo = "(+44) 0924712903705"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactPhoneNoMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            contactPhoneNo = "(+44) 09247129037056"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactPhoneNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            contactPhoneNo = "(+44) 092471290370562"; //this should fail
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContactPhoneNoMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            contactPhoneNo = "0924712903705"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactPhoneNoExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            contactPhoneNo = streetName.PadRight(500, '5'); //this should fail
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            dateOfBirth = DateTime.Now.Date.AddYears(-200); //this should fail
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            dateOfBirth = Convert.ToDateTime("31/12/1919");
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            dateOfBirth = Convert.ToDateTime("01/01/1920");
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            dateOfBirth = Convert.ToDateTime("02/01/1920");
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            dateOfBirth = DateTime.Now.Date.AddYears(200); //this should fail
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            ////create an instance of the class we want to create
            //clsStaff AStaff = new clsStaff();
            ////string variable to store any error message
            //String Error = "";
            //dateOfBirth = "12/12/2012"; //this should fail
            ////invoke the method
            //Error = AStaff.Valid(firstName, lastName,  Convert.ToDateTime("12/12/12"), dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            ////test to see that the result is correct
            Assert.AreNotEqual("Error", "");
        }

        [TestMethod]
        public void DateOfHireExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            dateOfHire = DateTime.Now.Date.AddYears(-200); //this should fail
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfHireMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            dateOfHire = Convert.ToDateTime("31/12/2018");
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfHireMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            dateOfHire = Convert.ToDateTime("01/01/2019");
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfHireMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            dateOfHire = Convert.ToDateTime("02/01/2019");
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfHireExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            dateOfHire = DateTime.Now.Date.AddYears(200); //this should fail
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfHireInvalidData()
        {
            ////create an instance of the class we want to create
            //clsStaff AStaff = new clsStaff();
            ////string variable to store any error message
            //String Error = "";
            //dateOfHire = "12/12/2012"; //this should fail
            ////invoke the method
            //Error = AStaff.Valid(firstName, lastName,  Convert.ToDateTime("12/12/12"), dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            ////test to see that the result is correct
            Assert.AreNotEqual("Error", "");
        }

        [TestMethod]
        public void StaffRoleIdMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            staffRoleId = 1; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleIdMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            staffRoleId = 2; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleIdMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            staffRoleId = 4; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleIdMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            staffRoleId = 5; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleIdMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            staffRoleId = 6; //this should fail
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleIdMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            staffRoleId = 3; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleIdExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            staffRoleId = 500; //this should fail
            //invoke the method
            Error = AStaff.Valid(firstName, lastName, dateOfBirth, dateOfHire, staffRoleId, postCode, cityOfResidence, streetName, houseNumber, contactEmail, contactPhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
