
using Design_Patterns_Assignment.Observer.Subject;
using Design_Patterns_Assignment.Observer.ObserverFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    internal class ObserverMenu : IObserverMenu
    {
        public IEmailWatcher _emailWatcher { get; set; }
        public IEmail Email { get; set; }
        public ObserverMenu(IEmail email, IEmailWatcher emailwatcher)
        {
            Email = email;
            _emailWatcher = emailwatcher;
        }
        public void Run()
        {
            Email.RegisterObserver(_emailWatcher);

            Console.WriteLine("---------------------");
            Console.WriteLine(" Observer   :");
            Console.WriteLine($"------------------------------\n");
            Console.WriteLine("A: update time");
            Console.WriteLine("S: subscribe/unsubscribe");
            Console.WriteLine("Q: exits the program");
            Console.WriteLine("---------------------");


            while (true)
            {
                var userinput = Console.ReadKey(true).KeyChar;

                switch (userinput)
                {
                    case 'a' or 'A':
                        ClearRow();
                        Email.UpdateTime();
                        break;

                    case 's' or 'S':
                        ClearRow();
                        if (Email.Observers.Contains(_emailWatcher))
                        {
                            Email.UnRegisterObserver(_emailWatcher);
                        }
                        else
                        {
                            Email.RegisterObserver(_emailWatcher);
                        }
                        break;

                    case 'q' or 'Q':
                        ClearRow();
                        Console.Write("exiting program");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("unrecognized command. please try again.");
                        Console.WriteLine("\n");
                        break;
                }
            }

           
        }
        private static void ClearRow()
        {
            /* set cursor below the menu */
            Console.SetCursorPosition(1, 9);

            /* clear row */
            Console.Write("\r" + new string(' ', Console.BufferWidth) + "\r");
        }
    }
}
/*uppgift:
          Refactor this code so that it uses the Observer Pattern 
    class Observer
    {
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


