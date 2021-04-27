using System;
using System.Collections.Generic;
using System.Text;

namespace KlassDiagram
{
    class ISubject
    {
        void Subscribe(Observer observer);

        void Unsubscribe(Observer observer);

        void Notify();

        void NotifyVideoDel();
    }
}
