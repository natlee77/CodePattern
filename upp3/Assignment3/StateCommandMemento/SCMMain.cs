using System;

namespace Assignment2.StateCommandMemento
{
    internal class SCMMain
    {
        /*
         * Skapa en maskin som kan vara av eller på. !Använd State Pattern!
         * 
         * Om man ger den ett kommando när den är av så ska den spara det kommandot och 
           sen köra alla sparade kommandon när den sätts på. !Använd Command Pattern!
         * Kommandot ska vara att skriva ut en sträng text som användaren anger.
         * Det ska också finnas en reset funktion som tar bort alla sparade kommandon och stänger av maskinen. 
         * !Använd Memento Pattern!
         */
        public void Run()
        {
            PrintMachine printer = new PrintMachine();

            PrintManager printer1 = new PrintManager(printer);
            MachineMemento MachineMomento = printer.CreateMemento();



            //draw menu

            Console.WriteLine("---------------------");
            Console.WriteLine(" State Command Memento    ");
            Console.WriteLine("---------------------");
            Console.WriteLine(" Enter: PowerSwitch");
            Console.WriteLine(" Tab:   Enter Word and press-> Enter " );
            Console.WriteLine(" A: Reset and turn off");
            Console.WriteLine(" X: Quit Program\n");


            while (true)
            {
                var userinput = Console.ReadKey().Key;
                switch (userinput)
                {
                    case ConsoleKey.Enter:
                        printer.PowerSwitch();
                        foreach (var word in printer.CommandList)
                        {
                            printer1.Do(word.Word);
                        }
                        break;

                    case ConsoleKey.Tab:
                        var input = Console.ReadLine() ;
                        printer1.Do(input);
                        Console.WriteLine($"  ");
                        break;

                    case ConsoleKey.A:
                        MachineMomento.Restore();
                        Console.WriteLine($"\n Reseted and turned off   ");
                        break;

                    case ConsoleKey.X:
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