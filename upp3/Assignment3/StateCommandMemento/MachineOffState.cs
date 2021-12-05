using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    class MachineOffState : IMachineState
    {   // Om man ger den ett kommando när den är av så ska den spara det kommandot
        //och sen köra alla sparade kommandon när den sätts på. !Använd Command Pattern!
        public void PowerSwitch()
        {
            Console.WriteLine("Turning Machine On");
        }
    }
}
