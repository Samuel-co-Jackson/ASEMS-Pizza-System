using System;

namespace PizzaClasses
{
    public class clsOrder
    {
        public DateTime OrderDate { get; set; }
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int StaffID { get; set; }
        public string OrderStatus { get; set; }

        public Boolean Find(int PrimaryKey)
        {
            return false;
        }

        public string Valid(string CustomerID, string StaffID, string OrderDate, string OrderStatus)
        {
            return "";
        }
    }
}