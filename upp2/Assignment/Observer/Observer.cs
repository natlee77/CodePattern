using Design_Patterns_Assignment.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
internal class Observer_class 
    {
        /*uppgift:
          Refactor this code so that it uses the Observer Pattern */


        internal static void Run()
        {
            EmailWatcher emailWatcher = new EmailWatcher();
            Email Email = new Email();
            var email = "";

            Console.WriteLine("---------------------");
            Console.WriteLine(" Observer   :");
            Console.WriteLine(" Checking Email");
            Console.WriteLine("---------------------");         
            while (string.IsNullOrEmpty(email))
            {
                email = Email.Check();
            }
            
            Console.WriteLine(email);
            Console.WriteLine( );

             
               
             
        }
       
    }
}


 
