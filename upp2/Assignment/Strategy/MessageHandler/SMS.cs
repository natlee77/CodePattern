using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Strategy 
{
     public  class SMS : ISMS
    {
       
        public void Send(string message)
        {
            Console.WriteLine("connecting to tel ");
            Console.WriteLine($"sending \"{message}\" as a sms");
        }

    }
}
