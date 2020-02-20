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
        public void staffAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Saffron Crossroads 16, Leicester LE2 8BA";
            //assign the data to the property
            aStaff.staffAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.staffAddress, TestData);
        }

        [TestMethod]
        public void staffHiredOnPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            aStaff.staffHiredOn = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.staffHiredOn, TestData);
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
        public void staffNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "John Hathorne";
            //assign the data to the property
            aStaff.staffName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStaff.staffName, TestData);
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
            //sdadsad
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Int32 StaffId = 1;
            Found = AStaff.Find(StaffId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffNotFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 1;
            Found = AStaff.Find(StaffId);
            if(AStaff.staffId != StaffId)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
