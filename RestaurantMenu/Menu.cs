using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    public class Menu
    {
        public string Name { get; set; }

        public List<MenuItem> MenuItems;

        public DateTime LastUpdated { get; set; }

        public static MenuItem LatestItem;

        public Menu()
        {
            MenuItems = new List<MenuItem>();
            LastUpdated = DateTime.Now;

        }

        public void AddItem(MenuItem menuItem)
        {

            if (MenuItems.Contains(menuItem))
            {
                Console.WriteLine("Item already on menu");
                return;
            }
            
            MenuItems.Add(menuItem);

            LatestItem = menuItem;

            
            menuItem.Added = DateTime.Now;
            LastUpdated = DateTime.Now;
        }

        public void RemoveItem(MenuItem menuItem)
        {
            MenuItems.Remove(menuItem);

        }

        public override string ToString()
        {

            string str = "Menu: \n";
            foreach (MenuItem item in MenuItems)
            {
                
                str += item.ToString();

                if (item.Equals(LatestItem))
                {
                 str +="Newest Item!";
                }
                str += "\n";

                
            }
            str += "Menu Last Updated: " + LastUpdated;
            
            return str;
        }

        public override bool Equals(object obj)
        {
            return obj is Menu menu &&
                   Name == menu.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }
    }
}
