﻿using System;

namespace PizzaClasses
{
    public class clsOrder
    {
        public DateTime OrderDate { get; set; }
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int StaffID { get; set; }
        public string OrderStatus { get; set; }

        public void Find(int PrimaryKey)
        {
            
        }

        public string Valid(string OrderID, string CustomerID, string StaffID, string OrderDate, string OrderStatus)
        {
            return "";
        }
    }
}