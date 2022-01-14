 
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
        }
        public void UnRegisterObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }
        //public void NotifyObservers(string message)
        //{
        //    foreach (var observer in Observers)
        //    {                                
        //        observer.Update(message);
        //    }
        //}         
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

 