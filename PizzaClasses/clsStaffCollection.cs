using System.Collections.Generic;

namespace PizzaClasses
{
    public class clsStaffCollection
    {

        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();

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