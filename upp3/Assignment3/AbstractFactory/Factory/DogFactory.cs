using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    class DogFactory : IFactory
    {

        public IAnimal CreateAnimal(string type)
        {
            return new Dog(type);
        }
    }
}
