using SOLID.Interfaces;
using SOLID.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID 
{
   public class MockUpp
    {

        public static List<IUser> MockUserslist = new List<IUser>
        {
                new User {Telefon="11111", FirstName="Stefan", LastName="Karlsson", Email="StefanKarlson@gmail.com",},
                new User {Telefon="233333", FirstName="Johan", LastName="Larsson", Email="JLarsson@gmail.com"},
                new User {Telefon="3446456", FirstName="Niklas", LastName="Svensson",  Email="NSvensson@gmail.com"},
                new User {Telefon="43452345234", FirstName="Nataliya", LastName="Lisjö",  Email="natlisjo@gmail.com"},
        };

        public static List<IAnimal>  MockAnimals = new List<IAnimal>
        {
            // Create a list of animals to use for testing
            
            
                      new Animal {PetsId=1, PetsName="Good Boy", TypeOfAnimal="Dog", PetsOwner = new User(){ FirstName = "Johan" },CheckIn = false},
                      new Animal {PetsId=2, PetsName="Tindra", TypeOfAnimal="Dog", PetsOwner=new User(){ FirstName = "Nataliya" },CheckIn = true },
                      new Animal {PetsId=3, PetsName="MMMayuu", TypeOfAnimal="Cat", PetsOwner=new User() { FirstName = "Stefan" },CheckIn = false},

            };
             
        

       
        public static List<IDayService> MockDayServices  = new List<IDayService>
        {
            // Create a list of animals to use for testing
             
                      new DayService {dsID=1, PetsId=1,PricePerDag=100,  DateGetOut=Convert.ToDateTime("2/2/2020") , DateGetIn=Convert.ToDateTime("4/2/2020") },
                      new DayService {dsID=2, PetsId=2,PricePerDag=80,   DateGetOut=Convert.ToDateTime("2/2/2020"),DateGetIn=Convert.ToDateTime("13/2/2020")},
                      new DayService {dsID=3, PetsId=3,PricePerDag=110,  DateGetOut=Convert.ToDateTime("3/2/2020"),DateGetIn=Convert.ToDateTime("6/2/2020")},



            };
            
    }
}
