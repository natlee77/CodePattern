using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Observer 
{
    internal class EmailWatcher : IEmailWatcher
    {
        Email  Email = new Email();
        
        public void Update( )
        {
            var email = "";
            while (string.IsNullOrEmpty(email))
            {
                email = Email.Check();
            }
            //Email.Check();
            Console.WriteLine(email);
        }

    }
}
