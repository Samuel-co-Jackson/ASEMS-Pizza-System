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
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            PopulateArray(DB);
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
        //adds a new record to the database
        public int Add()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@staffRoleId", mThisStaff.staffRoleId);
            DB.AddParameter("@staffFirstName", mThisStaff.firstName);
            DB.AddParameter("@staffLastName", mThisStaff.lastName);
            DB.AddParameter("@staffDateOfBirth", mThisStaff.dateOfBirth);
            DB.AddParameter("@staffDateOfHire", mThisStaff.dateOfHire);
            DB.AddParameter("@staffPostCode", mThisStaff.postCode);
            DB.AddParameter("@staffCityOfResidence", mThisStaff.cityOfResidence);
            DB.AddParameter("@staffStreetName", mThisStaff.streetName);
            DB.AddParameter("@staffHouseNumber", mThisStaff.houseNumber);
            DB.AddParameter("@staffContactEmail", mThisStaff.contactEmail);
            DB.AddParameter("@staffContactPhoneNo", mThisStaff.contactPhoneNo);
            DB.AddParameter("@staffOnHoliday", mThisStaff.onHoliday);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Delete()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //add the only parameter which is the id of staff member to delete
            DB.AddParameter("@staffId", mThisStaff.staffId);
            //proceed to delete the staff member
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void update()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@staffId", mThisStaff.staffId);
            DB.AddParameter("@staffRoleId", mThisStaff.staffRoleId);
            DB.AddParameter("@staffFirstName", mThisStaff.firstName);
            DB.AddParameter("@staffLastName", mThisStaff.lastName);
            DB.AddParameter("@staffDateOfBirth", mThisStaff.dateOfBirth);
            DB.AddParameter("@staffDateOfHire", mThisStaff.dateOfHire);
            DB.AddParameter("@staffPostCode", mThisStaff.postCode);
            DB.AddParameter("@staffCityOfResidence", mThisStaff.cityOfResidence);
            DB.AddParameter("@staffStreetName", mThisStaff.streetName);
            DB.AddParameter("@staffHouseNumber", mThisStaff.houseNumber);
            DB.AddParameter("@staffContactEmail", mThisStaff.contactEmail);
            DB.AddParameter("@staffContactPhoneNo", mThisStaff.contactPhoneNo);
            DB.AddParameter("@staffOnHoliday", mThisStaff.onHoliday);
            //update the record
            DB.Execute("sproc_tblStaff_Update");
        }

        public void ReportByLastName(String lastName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@lastName", lastName);
            DB.Execute("sproc_tblStaff_FilterByLastName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mStaffList = new List<clsStaff>();
            while (Index < RecordCount)
            {
                //staff object to save data to
                clsStaff AStaff = new clsStaff();
                //primary key
                AStaff.staffId = Convert.ToInt32(DB.DataTable.Rows[Index]["staffId"]);
                //foreign key
                AStaff.staffRoleId = Convert.ToInt32(DB.DataTable.Rows[Index]["staffRoleId"]);
                //common attributes
                AStaff.firstName = Convert.ToString(DB.DataTable.Rows[Index]["staffFirstName"]);
                AStaff.lastName = Convert.ToString(DB.DataTable.Rows[Index]["staffLastName"]);
                AStaff.dateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["staffDateOfBirth"]);
                AStaff.dateOfHire = Convert.ToDateTime(DB.DataTable.Rows[Index]["staffDateOfHire"]);
                AStaff.postCode = Convert.ToString(DB.DataTable.Rows[Index]["staffPostCode"]);
                AStaff.cityOfResidence = Convert.ToString(DB.DataTable.Rows[Index]["staffCityOfResidence"]);
                AStaff.streetName = Convert.ToString(DB.DataTable.Rows[Index]["staffStreetName"]);
                AStaff.houseNumber = Convert.ToString(DB.DataTable.Rows[Index]["staffHouseNumber"]);
                AStaff.contactEmail = Convert.ToString(DB.DataTable.Rows[Index]["staffContactEmail"]);
                AStaff.contactPhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["staffContactPhoneNo"]);
                AStaff.onHoliday = Convert.ToBoolean(DB.DataTable.Rows[Index]["staffOnHoliday"]);
                mStaffList.Add(AStaff);
                Index++;
            }
        }
    }
}