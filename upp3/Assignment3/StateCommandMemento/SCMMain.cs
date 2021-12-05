using System;

namespace Assignment2.StateCommandMemento
{
    internal class SCMMain
    {
        /*
         * Skapa en maskin som kan vara av eller på. !Använd State Pattern!
         * Om man ger den ett kommando när den är av så ska den spara det kommandot och 
           sen köra alla sparade kommandon när den sätts på. !Använd Command Pattern!
         * Kommandot ska vara att skriva ut en sträng text som användaren anger.
         * Det ska också finnas en reset funktion som tar bort alla sparade kommandon och stänger av maskinen. !Använd Memento Pattern!
         */
        public void Run()
        {
            Machine machine = new Machine();

            Console.WriteLine("Turn Machine Off");
            Console.WriteLine("Turn Machine On");
            Console.WriteLine("Reset mashine  Machine and turn Off");
            while (true)
            {
                var userinput = Console.ReadKey().Key;
                switch (userinput)
                {
                    case ConsoleKey.Enter:
                        machine.PowerSwitch();
                        break;

                    case ConsoleKey.Spacebar:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("I dont know what you mean");
                        break;
                }
            }

        }
    }
}