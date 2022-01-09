using Autofac;
using SOLID.Interfaces;
using SOLID.Service;
using SOLID.Menu;
using System;
using System.Linq;
using System.Reflection;

namespace SOLID 
{
    public static class AFConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // Register main application
            builder.RegisterType<Application>().As<IApplication>();

            //Register the rest of the service
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(n => n.Namespace.Contains("Menu"))
                .As(n => n.GetInterfaces()
                .FirstOrDefault(x => x.Name == "I" + n.Name))
                .AsImplementedInterfaces();



            //builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            //    .Where(i => i.Namespace.Contains("Interfaces"))
            //    .As(i => i.GetInterfaces()
            //    .FirstOrDefault(n => n.Name == "I" + i.Name))
            //       .AsImplementedInterfaces();





            builder.RegisterType<User>().As<IUser>();
            builder.RegisterType<Animal>().As<IAnimal>();
            builder.RegisterType<DayService>().As<IDayService>();
            builder.RegisterType<ExtraService>().As<IExtraService>();
            builder.RegisterType<Invoice>().As<ICalculator>();

            // return builder
            return builder.Build();
        }
    }
}