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
        public void staffPostcodePropertyOK()
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
        public void staffHireDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            aStaff.dateOfHire = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.dateOfHire, TestData);
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
        public void staffFirstNamePropertyOK()
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
