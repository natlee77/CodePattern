 
using Design_Patterns_Assignment.Observer.ObserverFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Design_Patterns_Assignment.Observer.Subject
{
    internal class Email : IEmail
    {
        public List<IObserver> Observers { get; set; }
        public DateTime Time { get; set; }

        public Email()
        {
            Observers = new List<IObserver>();
           
        }       

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
            Console.WriteLine("Observer Registered");
        }
        public void UnRegisterObserver(IObserver observer)
        {
            Observers.Remove(observer);
            Console.WriteLine("Observer unregistered");
        }
               
        public void NotifyObservers( )
        {
            foreach (var observer in Observers)
            {
                observer.Update(Time);
            }
        }
       
        public void UpdateTime()
        {
            Time = DateTime.Now;
            NotifyObservers();
        }
    }
}

 