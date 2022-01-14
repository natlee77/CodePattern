 
using Design_Patterns_Assignment.Observer.ObserverFiles;
using System;
using System.Collections.Generic;

namespace Design_Patterns_Assignment.Observer.Subject
{
    public interface ISubject
    {
        List<IObserver> Observers { get; set; }
        void RegisterObserver(IObserver observer);
        void UnRegisterObserver(IObserver observer);
      
        void NotifyObservers();
    }
}