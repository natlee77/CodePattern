using Design_Patterns_Assignment.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public  class SimulatedDatabaseB : IDataRepository
    {
        string db = "Databas B";
        public  string Load( string db)
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
            // Do specific command to get all the data from database type B
             
            var animal = Load("  From Table Animal Where Owner == Nataliya");
            return animal;
        }

        public string GetCustomer()
        {
            var customer = Load("From Table Customer Where Name == Nataliya");
            return customer;
        }

        public string GetData()
        {
            var data = Load("Dataset B");
            return data;
        }

        

        
    }
}
