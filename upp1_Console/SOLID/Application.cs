

using SOLID.Interfaces;

namespace SOLID
{
    public class Application : IApplication
    {
        private readonly IKennelMenu _kennelMenu;

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