using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Repository
{
     interface IDataRepository
    {
            string GetData();
            string GetCustomer();
            string GetAnimal();

            void Save(string data);
            string Load(string db);


    }
}
