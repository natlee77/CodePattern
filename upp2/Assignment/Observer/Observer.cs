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
        internal static void Run()
        {
            EmailWatcher emailWatcher = new EmailWatcher();
            Email Email = new Email();


            Console.WriteLine("---------------------");
            Console.WriteLine(" Observer   :");
            Console.WriteLine("---------------------");
            Console.WriteLine(" Checking Email");
            Console.WriteLine("---------------------");

            emailWatcher.Update();
            Console.WriteLine();

        }        
    }
}
/*uppgift:
          Refactor this code so that it uses the Observer Pattern 

          internal static void Run()
        {
            // Refactor this code so that it uses the Observer Pattern
            Console.WriteLine("Observer");
            var email = "";
            while (string.IsNullOrEmpty(email))
            {
                email=Email.Check();
            }            
            Console.WriteLine(email);
            Console.WriteLine();
        }
        internal class Email
    {
        internal static string Check()
        {
            var evenMinute = DateTime.Now.Minute % 2;
            if (evenMinute==0)
            {
                return "this is the email";
            }
            return null;
        } */


