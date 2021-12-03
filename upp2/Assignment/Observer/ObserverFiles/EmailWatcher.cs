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
             
             Email.Check();
        }

    }
}
