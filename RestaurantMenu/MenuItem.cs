using System;

namespace RestaurantMenu
{
    public class MenuItem
    {
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string IsNew { get; set; }
        

        public MenuItem(double price, string description, string category)
        {
            Price = price;
            Description = description;
            Category = category;
            
        }
    }
}
