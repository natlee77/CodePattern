using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Menu
{
    public interface IMenu
    {
        string Title { get; set; }        
        public List<IMenuItem> MenuItems { get; set; }
        string Footer { get; set; }
    }
}