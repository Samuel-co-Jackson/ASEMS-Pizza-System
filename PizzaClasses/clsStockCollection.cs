using System.Collections.Generic;

namespace PizzaClasses
{
    public class clsStockCollection
    {
        //private member for the list
        List<clsStock> mStockList = new List<clsStock>();

        //public property for the address list
        public List<clsStock> StockList
        {
            get
            {
                //return the private data
                return mStockList;
            }
            set
            {
                //set the private data
                mStockList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the private data
                return mStockList.Count;
            }
            set
            {
                //This will be added in a later lab
            }
        }

        public clsStock ThisStock { get; set; }

        //constructor for the class
        public clsStockCollection()
        {
            //create two items of test data
            clsStock TestItem = new clsStock();
            //set the properties
            TestItem.Name = "Cheese";
            TestItem.Description = "Dairy prodcut derived from milk";
            TestItem.StockQuantity = 1;
            TestItem.StockItemPrice = 1;
            //add the item to the test list
            mStockList.Add(TestItem);
            //re-initialise the object for new data
            //set the properties
            TestItem.Name = "Cucumber";
            TestItem.Description = "Edible cylindrical fruit and consists of 95% water";
            TestItem.StockQuantity = 2;
            TestItem.StockItemPrice = 2;
            //add the item to the test list
            mStockList.Add(TestItem);
        }
    }
}