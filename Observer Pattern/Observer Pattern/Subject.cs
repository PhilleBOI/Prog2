using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public class Subject : ISubject
    {
        private List<Observer> observers = new List<Observer>();
        private int _int;

        public int Video
        {
            get
            {
                return _int;
            }
            set
            {
                if(value > _int)
                {
                    Notify();
                }

                else if(value < _int)
                {
                    NotifyVideoDel();
                }
                _int = value;
            }
        }

        public void Subscribe(Observer observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }

        public void NotifyVideoDel()
        {
            foreach (var observer in observers)
            {
                observer.UpdateDel();
            }
        }
    }
}