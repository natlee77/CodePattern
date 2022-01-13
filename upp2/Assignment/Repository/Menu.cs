using Design_Patterns_Assignment;
using Design_Patterns_Assignment.Repository;
using System;

namespace Design_Patterns_Assignment
{
    internal class Repository_class
    {
        /*uppgift: Refactor this code so that it uses the Repository Pattern

        var data = SimulatedDatabase.Load("Dataset A");
        var customer = SimulatedDatabase.Load("From Table Customer Where Name==Steve"); // this is a search
        var animal = SimulatedDatabase.Load("From Table Animal Where Owner==Steve"); // this is a search
        Console.WriteLine("Repository");  
        
            SimulatedDatabase.Save(data);
            SimulatedDatabase.Save(customer);
            SimulatedDatabase.Save(animal);
            Console.WriteLine();*/
        internal static void Run()
        {
            IDataRepository databas=new   SimulatedDatabaseA();
            // SimulatedDatabaseB();
            string db = "database A";
            // "database B";
            string data = databas.Load( db);
            string customer = "";
            string animal = "From Table Animal Where Owner==Steve";

            // Draw Menu
            Console.WriteLine("Repository  ");
            Console.WriteLine("  DataBase");
            Console.WriteLine("---------------------");
            Console.WriteLine(" Select ");
            Console.WriteLine("---------------------");
            Console.WriteLine("A: Get Data");
            Console.WriteLine("B: Get Customer");
            Console.WriteLine("C: Get Animal");
            Console.WriteLine("D: Save Data");
            Console.WriteLine("E: Save Customer");
            Console.WriteLine("F: Save Animal");
            Console.WriteLine("X: Exit Program");


            //Main Game Loop
            while (true)
            {
                // Get User Input
                char userInput = Console.ReadKey(true).KeyChar;

                

                switch (userInput)
                {
                    case 'a' or 'A':
                        data = databas.GetData();
                        Console.WriteLine($" Load {data}");
                        break;

                    case 'b' or 'B':
                        customer = databas.GetCustomer();
                        Console.WriteLine($" Load {customer}");
                        break;

                    case 'c' or 'C':
                        animal = databas.GetAnimal();
                        Console.WriteLine($" Load {animal}");
                        break;

                    case 'd' or 'D':
                        if (data != "")
                        {
                            databas.Save(data);
                            Console.WriteLine($" Saved {data}");
                        }
                        else
                        {   Console.WriteLine(" Nothing to save");  }
                        break;

                    case 'e' or 'E':
                        if (customer != "")
                        {
                            databas.Save(customer);
                            Console.WriteLine($" Saved {customer}");
                        }
                        else
                        {   Console.WriteLine("Nothing to save");  }
                        break;

                    case 'f' or 'F': 
                        if (animal != "")
                        {
                            databas.Save(animal);
                            Console.WriteLine($" Saved {animal}");
                        }
                        else
                        { Console.WriteLine("Nothing to save"); }
                        break;

                    case 'x' or 'X':
                        Console.Write("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Write("That is not a valid choice");
                        break;
                }
            }
        }
    }
}
     
 