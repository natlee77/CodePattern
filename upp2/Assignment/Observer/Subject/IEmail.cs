using System;
using System.Collections.Generic;
 
namespace Design_Patterns_Assignment.Observer.Subject
{
   public interface IEmail : ISubject
    {
        
        DateTime Time { get; set; }
        void UpdateTime();
    }
}