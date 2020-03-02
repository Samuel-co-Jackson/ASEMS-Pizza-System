using System;

namespace PizzaClasses
{
    public class clsMenu
    {
        public clsMenu()
        {
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int MenuItemID { get; set; }
        public int RecipeID { get; set; }
        public double Price { get; set; }

        public void Find(int primaryKey)
        {
            throw new NotImplementedException();
        }
    }
}