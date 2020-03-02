using System;

namespace PizzaClasses
{
    public class clsRole
    {

        Int32 mRoleId;
        String mRoleName;

        public int roleId 
        { 
            get
            {
                return mRoleId;
            }
            set
            {
                mRoleId = value;
            }
        }
        public string roleName 
        { 
            get
            {
                return mRoleName;
            }
            set
            {
                mRoleName = value;
            }
        }
    }
}