using Design_Patterns_Assignment.Observer ;
using System.Collections.Generic;

namespace Design_Patterns_Assignment.Observer 
{
    internal interface ISubject
    {
        List<IObserver> Observers { get; set; }
        void RegisterObserver(IObserver observer);
        void UnRegisterObserver(IObserver observer);
        void NotifyObservers();
    }
}