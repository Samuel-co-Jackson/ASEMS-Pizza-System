using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaClasses;

namespace Pizza_Testing
{
    [TestClass]
    public class tstRole
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance
            clsRole testInstance = new clsRole();
            //ensure this instance was created
            Assert.IsNotNull(testInstance);
        }

        [TestMethod]
        public void RoleIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsRole testInstance = new clsRole();
            //create some test data to assign to the property
            Int32 TestData = 2;
            //assign the data to the property
            testInstance.roleId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(testInstance.roleId, TestData);
        }

        [TestMethod]
        public void RoleNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsRole testInstance = new clsRole();
            //create some test data to assign to the property
            String TestData = "ASEMS Manager";
            //assign the data to the property
            testInstance.roleName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(testInstance.roleName, TestData);
        }
    }
}
