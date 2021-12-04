using Design_Patterns_Assignment.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Design_Patterns_Assignment.Observer
{
    internal class Email :  IEmail    
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
        public void NotifyObservers()
        {
            foreach (var observer in Observers)
            {
                                
                observer.Update();
            }
        }         
        
        internal static string Check()    //class Email_upp
        {
            var evenMinute = DateTime.Now.Minute % 2;
            if (evenMinute == 0)
            {

                return $"{DateTime.Now} this is the NEW email   ";
            }
            return null;
           
        }    
    }
}

 