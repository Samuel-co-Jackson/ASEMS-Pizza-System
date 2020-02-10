using System;
using System.Collections.Generic;

namespace PizzaClasses
{
    public class clsStaffCollection
    {

        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member thisStaff
        clsStaff mThisStaff = new clsStaff();

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
        //public property for this staff
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database
            ////connect to the database
            //clsDataConnection DB = new clsDataConnection();
            ////set the parameters for the stored procedure
            //DB.AddParameter("@StaffAddress", mThisStaff.staffAddress);
            //DB.AddParameter("@StaffHiredOn", mThisStaff.staffHiredOn);
            //DB.AddParameter("@StaffName", mThisStaff.staffName);
            //DB.AddParameter("@StaffRoleId", mThisStaff.staffRoleId);
            ////execute the query returning the primary key value
            //return DB.Execute("sproc_tblStaff_Insert");
            //set the primary key value of the new record
            mThisStaff.staffId = 123;
            //return the primary key of the new record
            return mThisStaff.staffId;
            
        }
    }
}