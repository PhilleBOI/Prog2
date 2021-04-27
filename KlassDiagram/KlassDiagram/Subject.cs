using System;
using System.Collections.Generic;
using System.Text;

namespace KlassDiagram
{
    public class Subject : ISubject
    {
        private List<Observer> observers = new List<Observer>();
        private int _int;

        public int Video;

        public void Subscribe(Observer);

        public void Unsubscribe(Observer);

        public void Notify();

        public void NotifyVideoDel();
    }
}
