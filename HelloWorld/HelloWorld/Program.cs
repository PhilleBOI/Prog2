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

            string beard = "";
            while(age >= 18){
                Console.WriteLine(" \nHar du skäg? \n");
                beard = Console.ReadLine();
                if (beard == "ja")
                    break;
                else if(beard == "nej")
                    break;
            }

            var namn = 0;

            if (name == "Philip")
                namn = 1;
            else if (name == "Ludvig")
                namn = 2;
            else if (name == "Filippa")
                namn = 3;
            else if (name == "Adam")
                namn = 4;
            else if (name == "Linus")
                namn = 5;

            switch (namn)
            {
                case 1:
                    Console.WriteLine("\nVäldigt fint namn måste jag säga");
                    break;
                case 2:
                    Console.WriteLine("\nAha han... Wanna be orten pojk...");
                    break;
                case 3:
                    Console.WriteLine("\nDet är ju duuuuuu, Hej fina du <3.");
                    break;
                case 4:
                    Console.WriteLine("\nDet är ju fan mannen myten legenden!!");
                    break;
                case 5:
                    Console.WriteLine("\nLike your cut g!");
                    break;
                default:
                    Console.WriteLine("\nDu är jättefin idag <3.");
                    break;

            }

            Console.WriteLine( "Ditt namn är: " + name);
            Console.WriteLine("Du är ");
            for (int j = 0; j <= age; j++)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("Din older är: " + age);
            Console.WriteLine("Skäg: " + beard);

            int i = 20;

            if (age < i){
                Console.WriteLine("Btw, du får inte köpa sprit på systemet haha!");
            }
            else {
                Console.WriteLine("Nu får du bli alkolist, grattis hehe!");
            }
        }
    }
}
