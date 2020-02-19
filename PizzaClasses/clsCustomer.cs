using System;

namespace PizzaClasses
{
    public class clsCustomer
    {
        public int CustomerID { get; set; }
        public string Customerfirstname { get; set; }
        public string Customerlastname { get; set; }
        public string Customerhouseno { get; set; }
        public string Customerstreetname { get; set; }
        public string Customercity { get; set; }
        public string Customerpostcode { get; set; }
        public string Customeremail { get; set; }
        public long Customerphoneno { get; set; }

        public void Find(int CustomerID)
        {
           //
        }
    }
}