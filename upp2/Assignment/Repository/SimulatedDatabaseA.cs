using Design_Patterns_Assignment.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public  class SimulatedDatabaseA : IDataRepository
    {
        string db = "Databas A";
        public  string Load(string db)
        {
            Console.WriteLine($"Loading data \"{db}\"");
            return db;
        }

        public  void Save(string data)
        {
            Console.WriteLine($"Saving data \"{data}\"");
        }

        public string GetAnimal()
        {
            //     the data from database type A
            
            var animal = Load("  From Table Animal Where Owner == Steve");
            return animal;
        }

        public string GetCustomer()
        {
            var customer = Load("From Table Customer Where Name == Steve");
            return customer;
        }

        public string GetData()
        {
            var data = Load("Dataset A");
            return data;
        }

        

        
    }
}
