using System;
using System.Collections.Generic;

namespace Abstraktion
{
    class MainClass
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            var dog = new Dog();
            dog.Color = "Brown";

            var shark = new Shark();
            shark.Color = "Grey";

            var cat = new Cat();
            cat.Color = "orange, white";

            animals.Add(dog);
            animals.Add(shark);
            animals.Add(cat);

            foreach (var animal in animals)
            {
                Console.WriteLine("The " + animals + " is " + animal.Color);
                animal.Breathe();
                animal.Eat();
                animal.Rest();

                if (animal is Shark tempShark)
                {
                    tempShark.Swim();
                }

                if (animal is Cat tempCat)
                {
                    tempCat.comfy();
                }
            }
        }
    }
}