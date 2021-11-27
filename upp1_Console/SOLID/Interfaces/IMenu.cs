using SOLID.Interfaces;
using System.Collections.Generic;

namespace SOLID.Interfaces
{
    public interface IMenu
    {
        string Title { get; set; }        
        public List<IMenuItem> MenuItems { get; set; }
        string Footer { get; set; }
    }
}