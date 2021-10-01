using System;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem iceCream = new MenuItem(4.50, "Ice Cream", "Dessert");
            MenuItem chicken = new MenuItem(8, "Chicken", "Entree");

            Menu andrew = new Menu();

            andrew.AddItem(iceCream);
            Console.WriteLine(andrew.ToString());
            andrew.AddItem(chicken);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(andrew.ToString());

        }
    }
}
