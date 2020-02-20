using System;

namespace PizzaClasses
{
    public class clsStaff
    {

        //Unique Staff Identifier
        Int32 mStaffId;
        //Foreign Keys
        Int32 mStaffRoleId;
        //Common Staff Attributes
        String mFirstName;
        String mLastName;
        DateTime mDateOfBirth;
        DateTime mDateOfHire;
        String mPostCode;
        String mCityOfResidence;
        String mStreetName;
        String mHouseNumber;
        String mContactEmail;
        String mContactPhoneNo;
        
        Boolean mOnHoliday;
        
        //Public properties
        public Int32 staffId 
        {
            get
            {
                return mStaffId;
            }
            set
            {
                mStaffId = value;
            }
               
        }
        public Int32 staffRoleId {
            get
            {
                return mStaffRoleId;
            }
            set
            {
                mStaffRoleId = value;
            }
        }
        public String firstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }
        public String lastName {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }
        public DateTime dateOfBirth {
            get
            {
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
            }
        }
        public DateTime dateOfHire {
            get
            {
                return mDateOfHire;
            }
            set
            {
                mDateOfHire = value;
            }
        }
        public String postCode
        {
            get
            {
                return mPostCode;
            }
            set
            {
                mPostCode = value;
            }
        }
        public String cityOfResidence {
            get
            {
                return mCityOfResidence;
            }
            set
            {
                mCityOfResidence = value;
            }
        }
        public String streetName
        {
            get
            {
                return mStreetName;
            }
            set
            {
                mStreetName = value;
            }
        }
        public String houseNumber {
            get
            {
                return mHouseNumber;
            }
            set
            {
                mHouseNumber = value;
            }
        }
        public String contactEmail {
            get
            {
                return mContactEmail;
            }
            set
            {
                mContactEmail = value;
            }
        }
        public String contactPhoneNo {
            get
            {
                return mContactPhoneNo;
            }
            set
            {
                mContactPhoneNo = value;
            }
        }
        public Boolean onHoliday {
            get
            {
                return mOnHoliday;
            }
            set
            {
                mOnHoliday = value;
            }
        }

        public Boolean Find(Int32 staffId)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            //the parameter is the function argument
            DB.AddParameter("@staffId", staffId);
            //execute the procedure to get data
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            //if there was a row returned, get data from it
            if (DB.Count == 1)
            {
                //primary key
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["staffId"]);
                //foreign key
                mStaffRoleId = Convert.ToInt32(DB.DataTable.Rows[0]["staffRoleId"]);
                //common attributes
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["staffFirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["staffLastName"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["staffDateOfBorth"]);
                mDateOfHire = Convert.ToDateTime(DB.DataTable.Rows[0]["staffDateOfHire"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["staffPostCode"]);
                mCityOfResidence = Convert.ToString(DB.DataTable.Rows[0]["staffCityOfResidence"]);
                mStreetName = Convert.ToString(DB.DataTable.Rows[0]["staffStreetName"]);
                mHouseNumber = Convert.ToString(DB.DataTable.Rows[0]["staffHouseNo"]);
                mContactEmail = Convert.ToString(DB.DataTable.Rows[0]["staffContactEmail"]);
                mContactPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["staffContactPhoneNo"]);
                //row was found so return true as "found" is positive, a member was found
                return true;
            }
            else return false; //no row found means no staff member with this id exists

        }
    }
}