using SOLID.Config;
using System;
using Autofac;

namespace SOLID
{
    class Program
    {

        static void Main( )
        {
            Console.WriteLine(" Welcome to our Animal second home \n We taking Care of Animals \n");
            var container = AFConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
        }
    }

}           
   
   