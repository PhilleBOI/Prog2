using System;

namespace Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            Observer observer1 = new Observer("Philip");
            subject.Subscribe(observer1);

            Observer observer2 = new Observer("Ludvig");
            subject.Subscribe(observer2);

            subject.Video++;

            Observer observer3 = new Observer("Niklas");
            subject.Subscribe(observer3);

            subject.Video++;

            subject.Video--;

            subject.Unsubscribe(observer2);

            subject.Video++;

            Console.ReadLine();
        }
    }
}
