using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    class Machine : IMachineState
    {
        public IMachineState MachineState { get; set; }
        public Machine()
        {
            MachineState = new MachineOffState();
        }
        public void PowerSwitch()
        {
            MachineState.PowerSwitch();
            if (MachineState is MachineOffState)
            {
                MachineState = new MachineOnState();
            }
            else
            {
                MachineState = new MachineOffState();
            }
        }
    }
}
