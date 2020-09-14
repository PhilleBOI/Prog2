using System;
using System.Collections.Generic;
using System.Text;

namespace Metoder
{
    class Metoder
    {

        static void Main(string[] args)
        {

            string[] _name = { "Ludvig", "Petter", "Filippa", "Max" };
            int[] _tal = { 1, 2, 3, 4 };

            Console.WriteLine(Add(_tal));
            List(_name);
            Console.WriteLine(Sort(_tal));
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

        static (int max, int min) Sort(int[] tal)
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

            return (max, min);
        }

    }
}
