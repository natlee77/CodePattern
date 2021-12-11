using System;
using System.Collections.Generic;

namespace Assignment2.StateCommandMemento
{
    public class PrintMachine : IPrintMachine, IMachineState
    {

        //public IPrint Printer { get; set; }
        public string Word { get; set; }
        public IMachineState machineState { get; set; }
        public List<MachineCommand> CommandList { get; set; }
        public PrintMachine()
        {
            machineState = new MachineOffState();
            CommandList = new List<MachineCommand>();
        }
        public void Print(string word)
        {
            
                Console.WriteLine("\n Printing...");
                Console.WriteLine($" {word}");
           
        }

      
        public void PowerSwitch()
        {
            machineState.PowerSwitch();
            if (machineState is MachineOffState)
            {
                machineState = new MachineOnState();
            }
            else
            {
                machineState = new MachineOffState();
            }
        }



        public MachineMemento CreateMemento()  //spara
        {
            return new MachineMemento(this, CommandList);
        }
    }
}