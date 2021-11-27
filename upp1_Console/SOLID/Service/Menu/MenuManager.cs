using SOLID.Interfaces;
using SOLID.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Service
{
    class MenuManager : IMenuManager
    {
        private readonly IMenu Menu;
        private readonly Func<int, string, Action, IMenuItem> MenuItemFactory;

        public MenuManager(IMenu menu, Func<int, string, Action, IMenuItem> menuItemFactory)
        {
            Menu = menu;
            MenuItemFactory = menuItemFactory;
        }

        public void CreateMenu(string title, string footer)
        {
            Menu.Title = title;
            Menu.MenuItems = new List<IMenuItem>();
            Menu.Footer = footer;
        }

        public void CreateMenuItem(int selector, string name, Action runThis)
        {            
            Menu.MenuItems.Add(MenuItemFactory(selector, name, runThis));
        }

        public void ShowMenu()
        {
            Console.WriteLine(Menu.Title);

            foreach (var menuItem in Menu.MenuItems)
            {
                Console.WriteLine(menuItem.Selector + ": " + menuItem.Name);
            }

            Console.WriteLine(Menu.Footer);
        }

        public IMenu GetMenu()
        {
            return Menu;
        }
    }
}
