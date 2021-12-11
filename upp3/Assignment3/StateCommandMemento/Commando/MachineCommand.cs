using System;

namespace Assignment2.StateCommandMemento
{
    public class MachineCommand : ICommand
    {
        public IPrintMachine PrintMachine { get; set; }
        public string Word { get; set; }


        public MachineCommand(IPrintMachine printer, string word)
        {
            PrintMachine = printer;
            this.Word= word;
            
        }

        public void Do()
        {
            Console.WriteLine($"  ---------- Printer machine --------------");
            PrintMachine.Print(Word);
        }

      
    }
}