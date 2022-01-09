using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Interfaces;
using SOLID.Service;

namespace SOLID.Menu
{
    internal class KennelMenu : IKennelMenu
    {
        private readonly IMenuManager _menuManager;        
      
        public KennelMenu(IMenuManager menuManager)
        {
            _menuManager = menuManager;
        }
        public void Init()
        {
            // Create initial menu
            _menuManager.CreateMenu("------ Our service , choose what you want to do:", "-----------Copyright Nata.Lisjö---------- \n");
            _menuManager.CreateMenuItem( 1, " Registrate New User",  ToDoUser.RegistrateUser);
            _menuManager.CreateMenuItem( 2, " Registrate Your Animal  ",  ToDoAnimal.RegistrateAnimal);          
            _menuManager.CreateMenuItem( 3, " Show all User",  ToDoUser.ShowUsers);
            _menuManager.CreateMenuItem( 4, " Show all animals",  ToDoAnimal.ShowAnimals);
            _menuManager.CreateMenuItem( 5, " Show Animals Owner by PetsName", ToDoAnimal.ShowAnimalsByName);
            _menuManager.CreateMenuItem( 6, " Registrate your Animal in DayCare ", ToDoDayService.RegistrateAnimalDayCare);
             _menuManager.CreateMenuItem( 7," Show all Animals in DayCare  ", ToDoAnimal.ShowAnimalsByCheckIn);      
            _menuManager.CreateMenuItem(8, " Cut and Trim", ToDoExtraService.Create);
            _menuManager.CreateMenuItem(9, " Wash Animal", ToDoExtraService.Create);
            _menuManager.CreateMenuItem(0, " Cut nails", ToDoExtraService.Create);
            _menuManager.ShowMenu();
        }

         
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
