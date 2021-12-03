using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Strategy 
{
    internal class FacebookMessage : IFacebookMessage
    {
        public void Send (string message)
        {
            Console.WriteLine("connecting to Facebook Profile ");
            Console.WriteLine($"sending \"{message}\" as a FacebookMessage");
        }
    }
}
