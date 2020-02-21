using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaClasses;

namespace Pizza_Testing
{
    [TestClass]
    public class tstRoleCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance
            clsRoleCollection allRoles = new clsRoleCollection();
            //check if the instance was created
            Assert.IsNotNull(allRoles);
        }

        [TestMethod]
        public void RoleCollectionListOK()
        {
            //create an instance
            clsRoleCollection TestInstance = new clsRoleCollection();
            //create some test data to assign to the property
            List<clsRole> TestList = new List<clsRole>();
            //a test object
            clsRole TestRole = new clsRole();
            //assign all the properties
            TestRole.roleId = 1;
            TestRole.roleName = "Receptionist";
            //add the test object to the list
            TestList.Add(TestRole);
            //assign the list to the collection class
            TestInstance.allRoles = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(TestInstance.allRoles, TestList);
        }
    }
}
