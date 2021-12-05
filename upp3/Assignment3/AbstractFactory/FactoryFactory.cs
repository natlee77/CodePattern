 
using System;

namespace Assignment2.AbstractFactory
{
    internal class FactoryFactory
    {
        public FactoryFactory()
        {
        }

        internal IFactory GetFactory()
        {
            Console.WriteLine("What type of animal do you want create, dog or cat?\n");
            var typeOfFactory = Console.ReadLine();


            if (typeOfFactory.ToLower()=="dog" )
            {
                Console.WriteLine($"\n We creating   {typeOfFactory}, nice  :) ");
                return new DogFactory();
            }
             else if (typeOfFactory.ToLower() == "cat")
            {
                Console.WriteLine($"\n We creating  {typeOfFactory},  nice  :)");
                return new CatFactory();
            }
            else
                 
            {
                Console.WriteLine($"\n I dont understand you,:( try igen");
                return null;
            }

        }
    }
}