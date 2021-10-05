using System;

namespace RestaurantMenu
{
    public class MenuItem
    {
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        
        

        public MenuItem(double price, string description, string category)
        {
            Price = price;
            Description = description;
            Category = category;
            
        }

       

        public override string ToString()
        {
            string str = Description + ": $" + Price + " | " + Category;
            return str;
        }

        public override bool Equals(object obj)
        {
            return obj is MenuItem item &&
                   Price == item.Price &&
                   Description == item.Description &&
                   Category == item.Category;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Price, Description, Category);
        }
    }
}
