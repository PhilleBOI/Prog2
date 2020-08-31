using System;
using System.Data;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Niklas! \n");
            

            Console.WriteLine("Skriv ditt namn. \n");
            var name = Console.ReadLine();

            Console.WriteLine(" \nSkriv din ålder. \n");
            var age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine( "\nDitt namn är: " + name);
            Console.WriteLine("Din older är: " + age);

            int i = 20;

            if (age < i){
                Console.WriteLine("Du får inte köpa sprit än på systemet haha!");
            }
            else {
                Console.WriteLine("Nu får du bli alkolist, grattis hehe!");
            }
        }
    }
}
