using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2.StateCommandMemento
{
    public class PrintManager
    {
        // Initializers
        public PrintMachine Printer { get; set; }
        
        public PrintManager(PrintMachine machine)
        {
            Printer = machine;            
        }

        public void Do( string input)
        {
            Console.WriteLine("Do :");
            var word = new MachineCommand(Printer, input);
            
            if (Printer.machineState is MachineOffState)
            {
                Printer.CommandList.Add(word);
                Console.WriteLine("\n Machine Printer State is off .. saving word , if you want to print it , put printer on");
            }
            else
            { 
                word.Do();
                Console.WriteLine("\n @  Printing made by Nataliya Lisjö  @");
            }
        }

        public void Undo()
        {
            Console.WriteLine("Undo");             
        }

    }
}