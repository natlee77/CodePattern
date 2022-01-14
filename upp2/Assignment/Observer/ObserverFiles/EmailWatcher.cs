using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Observer.ObserverFiles
{
    internal class EmailWatcher : IEmailWatcher
    {
        

        public void Update(DateTime time)
        {
            Console.WriteLine($" This is the email - Date: {time}");
        }

    }
}
