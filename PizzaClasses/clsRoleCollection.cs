using System;
using System.Collections.Generic;

namespace PizzaClasses
{
    public class clsRoleCollection
    {
        //private class attributes
        List<clsRole> mAllRoles = new List<clsRole>();

        //public property for role list
        public List<clsRole> allRoles
        {
            get
            {
                return mAllRoles;
            }
            set
            {
                mAllRoles = value;
            }
        }

        //constructor
        public clsRoleCollection()
        {
            //connect to the db
            clsDataConnection DB = new clsDataConnection();
            //get all roles
            DB.Execute("sproc_tblRole_SelectAll");
            //get the quantity of roles
            Int32 RecordCount = DB.Count;
            //set an index for the loop
            Int32 Index = 0;
            //loop as long as there are records to list
            while( Index < RecordCount )
            {
                //create a role
                clsRole ARole = new clsRole();
                //get the role name
                ARole.roleName = DB.DataTable.Rows[Index]["roleName"].ToString();
                //get the primary key
                ARole.roleId = Convert.ToInt32(DB.DataTable.Rows[Index]["roleId"]);
                //add the role to the role list
                mAllRoles.Add(ARole);
                //go to next role
                Index++;
            }
        }

    }
}