using System;

namespace PizzaClasses
{
    public class clsOrder
    {
        public DateTime OrderDate { get; set; }
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public string OrderStatus { get; set; }
    }
}