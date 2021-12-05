using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    class Reset : IMachineState
    {
        public void PowerSwitch()
        {
            Console.WriteLine(" Reseting all commando");


            Console.WriteLine("Turning Machine Off");
        }
    }
}
