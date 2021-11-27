
using SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Service
{
    class MenuItem : IMenuItem
    {
        public int Selector { get; set; }
        public string Name { get; set; }
        public Action RunThis { get; set; }

        public MenuItem(int selector, string name, Action runThis)
        {
            Selector = selector;
            Name = name;
            RunThis = runThis;
        }
    }
}
