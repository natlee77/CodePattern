using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Menu
{
    public interface IMenuManager
    {
        void CreateMenu(string title, string footer);
        void CreateMenuItem(int selector, string name, Action runThis);
        void ShowMenu();
      
        public IMenu GetMenu();
    }
}