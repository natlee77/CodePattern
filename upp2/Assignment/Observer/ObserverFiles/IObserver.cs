using Design_Patterns_Assignment.Observer ;
using System;

namespace Design_Patterns_Assignment.Observer.ObserverFiles
{
    public  interface IObserver
    {
        //void Update (string message);
        void Update(DateTime Time);
    }
}