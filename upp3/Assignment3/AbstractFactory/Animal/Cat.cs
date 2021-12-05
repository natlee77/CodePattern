using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    class Cat : ICat  
    {
        public string Name { get; set; }
        public Cat(string name)
        {
            Name = name;
        }
    }
}
