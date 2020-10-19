using System;
using System.Collections.Generic;

namespace Polymorfi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> cart = new List<Product>();

            Milk milk = new Milk();
            milk.FatContent = 1;
            milk.ProductNumber = 123;
            milk.StockStatus = 10;

            Nocco nocco = new Nocco();
            nocco.Flavor = "Cola";
            nocco.ProductNumber = 234;
            nocco.StockStatus = 14;

            Coffee coffee = new Coffee();
            coffee.Rostyness = "Dark AF";
            coffee.ProductNumber = 345;
            coffee.StockStatus = 0;

            cart.Add(coffee);
            cart.Add(milk);
            cart.Add(nocco);

            foreach (var product in cart)
            {
                if (product.GetType() == typeof(Milk))
                {
                    Console.WriteLine(((Milk)product).GetType().Name); 
                }
                else if (product.GetType() == typeof(Coffee))
                {
                    Console.WriteLine(((Coffee)product));
                }
                else if (product.GetType() == typeof(Nocco))
                {
                    Console.WriteLine(((Nocco)product));
                }
            }
           
        }
    }
}
