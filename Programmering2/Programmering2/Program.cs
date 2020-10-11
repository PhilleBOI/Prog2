namespace Programmering2
{
    class Program
    {

        static void Main (string[] args)
        {

            Animal pet = new Animal();

            Person philip = new Person("Philip", 18, pet);
            Person veronika = new Person("Veronika", 41, pet);
            Person casper = new Person("Casper", 16, pet);

            pet._name = "Millan";
            pet._species = "Hund";

            philip._pet = pet;

            Person.SayName(philip);

            philip.Eat();
            philip.Sleep();
            philip.ActivatePet();

            Person.SayName(veronika);

            veronika.Eat();
            veronika.Sleep();
            veronika.ActivatePet();

            Person.SayName(casper);

            casper.Eat();
            casper.Sleep();
            casper.ActivatePet();



        }

    }
}
