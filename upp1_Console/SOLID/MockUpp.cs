using SOLID.Interfaces;
using SOLID.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID 
{
   public class MockUpp
    {

        public static List<IAnimal>  MockAnimals()
        {
            // Create a list of animals to use for testing
            var animals = new List<IAnimal>
            { 
                      new Animal {PetsId=1, PetsName="Good Boy", TypeOfAnimal="Dog", PetsOwner = new User(){ FirstName = "Johan" },CheckIn = false},
                      new Animal {PetsId=2, PetsName="Tindra", TypeOfAnimal="Dog", PetsOwner=new User(){ FirstName = "Nataliya" },CheckIn = true },
                      new Animal {PetsId=3, PetsName="MMMayuu", TypeOfAnimal="Cat", PetsOwner=new User() { FirstName = "Stefan" },CheckIn = false},

            };
            return animals;
        }

        public static List<IUser>  MockUsers()
        {
            var users = new List<IUser>
            {
                new User {UserId=1, FirstName="Stefan", LastName="Karlsson", Email="StefanKarlson@gmail.com",},
                new User {UserId=2, FirstName="Johan", LastName="Larsson", Email="JLarsson@gmail.com"},
                new User {UserId=3, FirstName="Niklas", LastName="Svensson",  Email="NSvensson@gmail.com"},
                new User {UserId=4, FirstName="Nataliya", LastName="Lisjö",  Email="natlisjo@gmail.com"},
            };
            return users;
        }
        public static List<IDayService> MockDayServices()
        {
            // Create a list of animals to use for testing
            var dayServices = new List<IDayService>
            {
                      new DayService {dsID=1, PetsId=1,PricePerDag=100,  DateGetOut=Convert.ToDateTime("2/2/2020") , DateGetIn=Convert.ToDateTime("4/2/2020") },
                      new DayService {dsID=2, PetsId=2,PricePerDag=80,   DateGetOut=Convert.ToDateTime("2/2/2020"),DateGetIn=Convert.ToDateTime("13/2/2020")},
                      new DayService {dsID=3, PetsId=3,PricePerDag=110,  DateGetOut=Convert.ToDateTime("3/2/2020"),DateGetIn=Convert.ToDateTime("6/2/2020")},



            };
            return dayServices;
        }
    }
}
