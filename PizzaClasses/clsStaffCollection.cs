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
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            RecordCount = DB.Count;
            while( Index < RecordCount )
            {
                clsStaff AStaff = new clsStaff();

                AStaff.staffId = Convert.ToInt32(DB.DataTable.Rows[Index]["staffId"]);
                AStaff.staffName = Convert.ToString(DB.DataTable.Rows[Index]["staffName"]);
                AStaff.staffAddress = Convert.ToString(DB.DataTable.Rows[Index]["staffAddress"]);
                AStaff.staffHiredOn = Convert.ToDateTime(DB.DataTable.Rows[Index]["staffHiredOn"]);
                AStaff.staffRoleId = Convert.ToInt32(DB.DataTable.Rows[Index]["staffRoleId"]);

                mStaffList.Add(AStaff);
                Index++;
            }
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
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffAddress", mThisStaff.staffAddress);
            DB.AddParameter("@StaffHiredOn", mThisStaff.staffHiredOn);
            DB.AddParameter("@StaffName", mThisStaff.staffName);
            DB.AddParameter("@StaffRoleId", mThisStaff.staffRoleId);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@staffId", mThisStaff.staffId);
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@staffId", mThisStaff.staffId);
            DB.AddParameter("@staffAddress", mThisStaff.staffAddress);
            DB.AddParameter("@staffHiredOn", mThisStaff.staffHiredOn);
            DB.AddParameter("@staffName", mThisStaff.staffName);
            DB.AddParameter("@staffRoleId", mThisStaff.staffRoleId);
            DB.Execute("sproc_tblStaff_Update");
        }
    }
}