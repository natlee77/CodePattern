using System;
using System.Collections.Generic;

namespace Assignment2.StateCommandMemento

{   
    public class MachineMemento
    {
        private PrintMachine printMachine;
        private List<MachineCommand> commandList;

        public MachineMemento(PrintMachine printMachine, List<MachineCommand> commandList)
        {
            this.printMachine = printMachine;
            this.commandList = commandList;
        }

        public void Restore() 
        {
            
            Console.WriteLine("Reseting list and turning off...");
            printMachine.CommandList.Clear();
            printMachine.machineState = new MachineOffState();
             
        }
    }
}