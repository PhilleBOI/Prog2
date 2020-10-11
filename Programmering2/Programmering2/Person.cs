using System;

namespace Programmering2
{
    class Person
    {
        private string _name;

        public int _age;

        public Animal _pet;

        private int myVar;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public Person(string name, int age, Animal pet)
        {
            _name = name;
            _age = age;
            _pet = pet;
        }

        public void ActivatePet()
        {
            _pet.Poop();
        }

        public void Eat()
        {
            Console.WriteLine(_name + " is eating!");
        }

        public void Sleep()
        {
            Console.WriteLine(_name + " is sleeping!");
        }

        public static void SayName(Person person)
        {
            Console.WriteLine("\n" + person._name);
        }
    }
}
