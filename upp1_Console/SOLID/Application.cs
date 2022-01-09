
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Menu;
 

namespace SOLID
{
    internal class Application : IApplication
    {
        public readonly IKennelMenu _kennelMenu;

        public Application(IKennelMenu kennelMenu)
        {
            this._kennelMenu = kennelMenu;
        }

        public void Run()
        {            
            // Create Menu and Show It
            _kennelMenu.Init();

            // Ask user for input and run the choice
            _kennelMenu.UserChoice();

            _kennelMenu.Continue();
        }
    }
}