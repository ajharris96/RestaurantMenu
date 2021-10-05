using System;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem iceCream = new MenuItem(4.50, "Ice Cream", "Dessert");
            MenuItem chicken = new MenuItem(8, "Chicken", "Entree");
            MenuItem coffee = new MenuItem(5, "Coffee", "Beverage");
            MenuItem coffee2 = new MenuItem(5, "Coffee", "Beverage");

            Console.WriteLine(coffee.Equals(coffee2));

            Menu andrew = new Menu();

            andrew.AddItem(iceCream);
            Console.WriteLine(andrew.ToString());
            andrew.AddItem(chicken);
            andrew.AddItem(coffee);
            andrew.AddItem(coffee2);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(andrew.ToString());

            andrew.RemoveItem(iceCream);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(andrew.ToString());


            Menu monica = new Menu();

            monica.AddItem(iceCream);
            monica.AddItem(coffee2);
            monica.AddItem(chicken);
            monica.RemoveItem(chicken);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine(monica.ToString());

        }
    }
}
