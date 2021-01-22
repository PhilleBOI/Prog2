using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktion
{
    class Cat : Animal
    {

        public Cat()
        {
            NumberOfLimbs = 4;
        }

        public override void Breathe()
        {
            Console.WriteLine("Cat is inhaling and exhaling through nose");
        }

        public override void Eat()
        {
            Console.WriteLine("Cat is eating catfood");
        }

        public override void Rest()
        {
            Console.WriteLine("Cat is very sleapy");
        }

        public void comfy()
        {
            Console.WriteLine("Cat is spinning! \n");
        }

    }
}
