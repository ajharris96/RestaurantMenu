using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    public class Menu
    {
        public List<MenuItem> MenuItems;

        public DateTime LastUpdated { get; set; } 

        public Menu()
        {
            MenuItems = new List<MenuItem>();
            LastUpdated = DateTime.Now;

        }

        public void AddItem(MenuItem menuItem)
        {
            MenuItems.Add(menuItem);
            menuItem.IsNew = "New Item!";
            LastUpdated = DateTime.Now;

        }

        public override string ToString()
        {
            string str = "Menu: \n";
            foreach (MenuItem item in MenuItems)
            {
                str += item.Description + ": " + item.Price + " " + item.IsNew + "\n";
            }
            str += "\n Menu Last Updated: " + LastUpdated;
            
            return str;
        }





    }
}
