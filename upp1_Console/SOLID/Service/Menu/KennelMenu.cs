using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Interfaces;

namespace SOLID.Service
{
    public class KennelMenu : IKennelMenu
    {
        private readonly IMenuManager _menuManager;

        public KennelMenu(IMenuManager menuManager)
        {
            _menuManager = menuManager;
        }
        public void Init()
        {
            // Create initial menu
            _menuManager.CreateMenu(" Our service , choose what you want to do:", "Copyright Nata.Lisjö \n");
            _menuManager.CreateMenuItem(1, "Registrate New User", ThingsToDo.RegistrateUser);
            _menuManager.CreateMenuItem(2, "Registrate Your Animal  ", ThingsToDo.RegistrateAnimal);
            _menuManager.CreateMenuItem(3, "Animal DayCare", ThingsToDo.RegistrateAnimalDayCare);
            _menuManager.CreateMenuItem(4, "Show all User", ThingsToDo.ShowUsers);
            _menuManager.CreateMenuItem(5, "Show all animals", ThingsToDo.ShowAnimals);
            _menuManager.CreateMenuItem(6, "Cut and Trim", ToDoExtraService.CreareTrimming);
            _menuManager.CreateMenuItem(7, "Wash Animal", ToDoExtraService.CreateWashing);
            _menuManager.CreateMenuItem(8, "Cut nails", ToDoExtraService.CutNails);
            _menuManager.ShowMenu();
        }

        // This should probably be in its own class since its not really associated with the menu sort of maybe
        public void UserChoice()
        {
            while (true)
            {
                var userInput = Console.ReadKey(true);

                foreach (var menuItem in _menuManager.GetMenu().MenuItems)
                {
                    if (menuItem.Selector.ToString() == userInput.KeyChar.ToString())
                    {
                        Console.Clear();
                        _menuManager.ShowMenu();
                        menuItem.RunThis();
                    }
                    else if (userInput.KeyChar == 'x')
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }
        public void Continue()
        {
            Console.WriteLine("Do you want continiue   Yes - 1, No - any \n");
            while (true)
            {             
                var userInput = Console.ReadKey(true);
                foreach (var menuItem in _menuManager.GetMenu().MenuItems)
                {
                    if (userInput.KeyChar == 1)
                    {
                        Console.Clear();
                        Init ();
                        _menuManager.ShowMenu();
                        menuItem.RunThis();
                    }
                    else if (userInput.KeyChar == 'x')
                    {
                        Environment.Exit(0);
                    }                     
                }
            }
        }
    }
}
