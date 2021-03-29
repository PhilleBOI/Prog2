using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public class Observer : IObserver
    {
        public String ObserverName { get; set; }

        public Observer(String name)
        {
            ObserverName = name;
        }

        public void Update()
        {
            Console.WriteLine("Hey " + ObserverName + ": A new video has been uploaded!");
            Console.WriteLine();
        }

        public void UpdateDel()
        {
            Console.WriteLine("Hey " + ObserverName + ": A video has been Deleted!");
            Console.WriteLine();
        }
    }
}
