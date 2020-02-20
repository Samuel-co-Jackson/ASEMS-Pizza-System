using System;

namespace PizzaClasses
{
    public class clsStaff
    {

        private Int32 mStaffId;
        private String mStaffName;
        private String mStaffAddress;
        private DateTime mStaffHiredOn;
        private int mStaffRoleId;

        public string staffAddress { get; set; }
        public DateTime staffHiredOn { get; set; }
        public int staffId 
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
        public string staffName { get; set; }
        public int staffRoleId { get; set; }

        public bool Find(int staffId)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@staffId", staffId);
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            if (DB.Count == 1)
            {
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["staffId"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["staffName"]);
                mStaffAddress = Convert.ToString(DB.DataTable.Rows[0]["staffAddress"]);
                mStaffHiredOn = Convert.ToDateTime(DB.DataTable.Rows[0]["staffHiredOn"]);
                mStaffRoleId = Convert.ToInt32(DB.DataTable.Rows[0]["staffRoleId"]);
                return true;
            }
            else return false;

        }
    }
}