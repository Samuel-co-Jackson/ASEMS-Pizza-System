using System.Collections.Generic;

namespace PizzaClasses
{
    public class clsMenuCollection
    {

        //private data member for the list
        List<clsMenu> mMenuList = new List<clsMenu>();

        //public property for the menu list
        public List<clsMenu> MenuList
        {
            get
            {
                //return the private data
                return mMenuList;
            }
            set
            {
                //set the private data
                mMenuList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mMenuList.Count;
            }
            set
            {
                //worry about this later
            }
        }
        public clsMenu ThisMenuItem { get; set; }
    }
}