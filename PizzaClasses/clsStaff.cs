using System;
using System.Linq;

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
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["staffDateOfBirth"]);
                mDateOfHire = Convert.ToDateTime(DB.DataTable.Rows[0]["staffDateOfHire"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["staffPostCode"]);
                mCityOfResidence = Convert.ToString(DB.DataTable.Rows[0]["staffCityOfResidence"]);
                mStreetName = Convert.ToString(DB.DataTable.Rows[0]["staffStreetName"]);
                mHouseNumber = Convert.ToString(DB.DataTable.Rows[0]["staffHouseNumber"]);
                mContactEmail = Convert.ToString(DB.DataTable.Rows[0]["staffContactEmail"]);
                mContactPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["staffContactPhoneNo"]);
                mOnHoliday = Convert.ToBoolean(DB.DataTable.Rows[0]["staffOnHoliday"]);
                //row was found so return true as "found" is positive, a member was found
                return true;
            }
            else return false; //no row found means no staff member with this id exists

        }

        public string Valid(string firstName, string lastName, DateTime dateOfBirth, DateTime dateOfHire, int staffRoleId, string postCode, string cityOfResidence, string streetName, string houseNumber, string contactEmail, string contactPhoneNo)
        {

            String Error = "";

            //Validation for first Name
            if(firstName.Length == 0)
            {
                Error += "First name is a required field!" + Environment.NewLine;
            }
            else if(firstName.Length > 30)
            {
                Error += "First name must be 30 characters or shorter!" + Environment.NewLine;
            }
            else if(firstName.Any(char.IsDigit))
            {
                Error += "First name must not contain any numbers!" + Environment.NewLine;
            }

            //Validation for last name
            if (lastName.Length == 0)
            {
                Error += "Last name is a required field!" + Environment.NewLine;
            }
            else if (lastName.Length > 50)
            {
                Error += "Last name must be 50 characters or shorter!" + Environment.NewLine;
            }
            else if (lastName.Any(char.IsDigit))
            {
                Error += "Last name must not contain any numbers!" + Environment.NewLine;
            }

            //Validation for date of birth
            try
            {
                DateTime DateTemp = dateOfBirth;
                if (DateTemp < Convert.ToDateTime("01/01/1920"))
                {
                    Error += "Entered date of birth suggest the staff is over 100 years old!" + Environment.NewLine;
                }
                else if (DateTemp >= Convert.ToDateTime("01/01/2004"))
                {
                    Error += "Entered date of birth suggest the staff is younger than 16 years old!" + Environment.NewLine;
                }
            }
            catch
            {
                Error += "Date of birth is a required field!" + Environment.NewLine;
            }

            //Validation for date of hire
            try
            {
                DateTime DateTemp = dateOfHire;
                if (DateTemp < Convert.ToDateTime("01/01/2019"))
                {
                    Error += "The business started in 2019 so the date of hire cannot be before that date!" + Environment.NewLine;
                }
                else if (DateTemp >= Convert.ToDateTime("01/01/2022"))
                {
                    Error += "Entered date of hire suggest the staff will start in over a year's time!" + Environment.NewLine;
                }
            }
            catch
            {
                Error += "Date of hire is a required field!" + Environment.NewLine;
            }

            //Validation for staff role id
            if (staffRoleId == 0)
            {
                Error += "Staff role is a required field!" + Environment.NewLine;
            }
            else if (staffRoleId < 0 || staffRoleId > 5)
            {
                Error += "You must select a staff role from the dropdown list!" + Environment.NewLine;
            }

            //Validation for post code
            if (postCode.Length == 0)
            {
                Error += "Postcode is a required field!" + Environment.NewLine;
            }
            else if (postCode.Length > 10)
            {
                Error += "Postcode must be 10 characters or shorter!" + Environment.NewLine;
            }
            else if (postCode.Length < 5) //Shortest UK postcode without spacebar is 5 chars (Ex. S11AA - Sheffield)
            {
                Error += "Postcode must be 5 characters or longer!" + Environment.NewLine;
            }

            //Validation for city of residence
            if (cityOfResidence.Length == 0)
            {
                Error += "City of residence is a required field!" + Environment.NewLine;
            }
            else if (cityOfResidence.Length > 60)
            {
                Error += "City of residence must be 60 characters or shorter!" + Environment.NewLine;
            }
            else if (cityOfResidence.Length < 2) //Some cities worldwide are 2 signs long, could happen in England
            {
                Error += "City of residence must be 2 characters or longer!" + Environment.NewLine;
            }
            else if (cityOfResidence.Any(char.IsDigit))
            {
                Error += "City of residence must not contain any numbers!" + Environment.NewLine;
            }

            //Validation for street name
            if (streetName.Length == 0)
            {
                Error += "Street name is a required field!" + Environment.NewLine;
            }
            else if (streetName.Length > 40)
            {
                Error += "Street name must be 40 characters or shorter!" + Environment.NewLine;
            }
            else if (streetName.Length < 4) //Shortest street in England is called "Hide" and is in London
            {
                Error += "Street name must be 4 characters or longer!" + Environment.NewLine;
            }

            //Validation for house number
            if (houseNumber.Length == 0)
            {
                Error += "House number is a required field!" + Environment.NewLine;
            }
            else if (houseNumber.Length > 10)
            {
                Error += "House number must be 10 characters or shorter!" + Environment.NewLine;
            }

            //Validation for contact email
            if (contactEmail.Length == 0)
            {
                Error += "Contact E-Mail address is a required field!" + Environment.NewLine;
            }
            else if (contactEmail.Length > 30)
            {
                Error += "Contact E-Mail address must be 30 characters or shorter!" + Environment.NewLine;
            }
            else if (contactEmail.Length < 6) //shorted existing email is in format a@g.cn
            {
                Error += "Contact E-Mail address must be 6 characters or longer!" + Environment.NewLine;
            }
            else if (!contactEmail.Any(c => c == '@')) //Check if @ is present in string
            {
                Error += "You must enter a valid E-Mail address!" + Environment.NewLine;
            }

            //Validation for contact phone number
            if (contactPhoneNo.Length == 0)
            {
                Error += "Contact phone number is a required field!" + Environment.NewLine;
            }
            else if (contactPhoneNo.Length > 20)
            {
                Error += "Contact phone number must be 20 characters or shorter!" + Environment.NewLine;
            }
            else if (contactPhoneNo.Length < 8) //Phone number must be 8 characters or longer, no special numbers allowed
            {
                Error += "Contact phone number must be 8 characters or longer!" + Environment.NewLine;
            }
            else if (contactPhoneNo.Any(x => char.IsLetter(x))) //Check if there are any letters in the string
            {
                Error += "You must enter a valid telephone number!" + Environment.NewLine;
            }

            return Error;
        }
    }
}