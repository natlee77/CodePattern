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
            string GetCustomer(string user);
            string GetAnimal(string owner);

            void Save(string data);
            string Load(string db);


    }
}
