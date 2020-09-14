using System;
using System.Collections.Generic;
using System.Text;

namespace Prog2
{
    class Metoder
    {

        static void Main(string[] args)
        {

            string[] _name = { "Ludvig", "Petter", "Filippa", "Max" };
            int[] _tal = { 1, 2, 3, 4 };

            Console.WriteLine(Add(_tal));
            List(_name);
            Sort(_tal);
        }

        static int Add(int[] tal)
        {
            var sum = 0;

            for (int i = 0; i < tal.Length; i++)
            {
                sum = sum + tal[i];
            }

            return sum;
        }

        static void List(string[] name)
        {

            for(int i = 3; i >= 0; i--)
            {
                Console.WriteLine(name[i]);
            }


        }

        static void Sort(int[] tal)
        {
            var max = 100;
            var min = 10;

            foreach(var t in tal)
            {
                if(t > max)
                {
                    max = t;
                }
                else if(t < min)
                {
                    min = t;
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(min);
        }

    }
}
