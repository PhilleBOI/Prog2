using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Arrays
    {
        static void Main(string[] args){

            string[] names = new string[5];

            Console.WriteLine("Skriv fem namn: ");

            for(int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("whoops, nu skrivs dom baklänges.");

            for (var i = names.Length -1; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }

        }

    }
}
