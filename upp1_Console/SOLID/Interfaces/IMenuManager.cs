using System;

namespace SOLID.Interfaces
{
    public interface IMenuManager
    {
        void CreateMenu(string title, string footer);
        void CreateMenuItem(int selector, string name, Action runThis);
        void ShowMenu();
        public IMenu GetMenu();
    }
}