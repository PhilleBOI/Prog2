using System;
using System.Dynamic;

namespace Labb1_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var kund = new Kund();

            var product = new Product();

            product.ProduktName = Console.ReadLine();
            kund._produkts.Add(product);


            Console.WriteLine("Välj vara att lägga i kundvagn eller lägg till en vara i lagret");

        }

        public void Lager()
        {
            String[] Varor;
        }

        public void Add()
        {
            Console.WriteLine("Lägg till en produkt: ");
            Product vara = new Product();
            vara.ProduktName = Console.ReadLine();
        }

    }
}
