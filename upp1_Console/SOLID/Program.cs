
using System;
using Autofac;

namespace SOLID
{
    internal class Program
    {
                        //        Programmet ska kunna
                        //1. Registrera nya kunder
                        //2. Registrera nya djur
                        //3. Se vilka kunder som finns registrerade
                        //4. Se vilka djur som finns registrerade
                        //5. Se vilka djur som tillhör vilka kunder
                        //6. Anmäla att ett djur är inlämnat
                        //7. Anmäla att ett djur är hämtat
                        //8. Se vilka djur som för tillfället är inlämnade och vilka kunder dessa tillhör
                        //9. Koppla extratjänster till ett djur
                        //a.Tvätt
                        //b.Kloklippning
                        //10. När ett djur hämtas ska ett kvitto visas med kostnaden för dagen samt eventuella
                        //extratjänster.
                        //11. Övrig funktionalitet som ni tycker är relevant
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to our Animal second home \n We taking Care of Animals \n");
            var container = AFConfig.Configure();

            //using (var scope = container.BeginLifetimeScope())
            //{
            //    var app = scope.Resolve<IApplication>();
            //    app.Run();
            //}
            using var scope = container.BeginLifetimeScope();
            var app = scope.Resolve<IApplication>();
            app.Run();
        }
    }

}           
   
   