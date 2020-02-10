using System;
using System.Collections.Generic;

namespace PizzaClasses
{
    public class clsStaffCollection
    {

        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();

        public clsStaffCollection()
        {
            //create the items of test data
            clsStaff testStaff = new clsStaff();
            //assign all the properties
            testStaff.staffAddress = "Saffron Crossroads 80a, LE2 9BP Leicester";
            testStaff.staffHiredOn = Convert.ToDateTime("02/02/2020");
            testStaff.staffName = "John Hathorne";
            testStaff.staffRoleId = 3;
            testStaff.staffId = 15;
            //add the item to the test list
            mStaffList.Add(testStaff);
            //re initialise the object for some new data
            testStaff = new clsStaff();
            //assign all the properties
            testStaff.staffAddress = "Wellby Road 19, LE8 4BG, Leicester";
            testStaff.staffHiredOn = Convert.ToDateTime("01/01/2020");
            testStaff.staffName = "David Martin";
            testStaff.staffRoleId = 2;
            testStaff.staffId = 6;
            //add the item to the test list
            mStaffList.Add(testStaff);
        }

        //public property for the staff list
        public List<clsStaff> staffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public List<clsStaff> myStaff { get; set; }
        public clsStaff ThisStaff { get; set; }
    }
}