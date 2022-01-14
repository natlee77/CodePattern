 
using Design_Patterns_Assignment.Strategy;
using Design_Patterns_Assignment.Observer;
using Design_Patterns_Assignment.Decorator;

using System; 
using Autofac;
using Design_Patterns_Assignment.Repository;

namespace Design_Patterns_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            var container = AFConfigure.Configure();
            using var scope = container.BeginLifetimeScope();

            /* Decorator */
            //DecoratorMenu.Run();


            /* Observer */
            var observerapplication = scope.Resolve<IObserverMenu>();
            observerapplication.Run();


            /* Repository */
            //var repositoryapplication = scope.Resolve<IRepositoryMenu>();
            //repositoryapplication.Run();


            /* Strategy */
            //StrategyApp.Run();




        }
    }
}
