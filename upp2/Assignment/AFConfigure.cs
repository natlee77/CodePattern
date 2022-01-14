using Autofac;
using Design_Patterns_Assignment;
using Design_Patterns_Assignment.Observer;
using Design_Patterns_Assignment.Repository;
using Design_Patterns_Assignment.Strategy;
using System.Linq;
using System.Reflection;

namespace Design_Patterns_Assignment
{
    public static class AFConfigure
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            /* register application */
            builder.RegisterType<ObserverMenu>().As<IObserverMenu>();
            builder.RegisterType<RepositoryMenu>().As<IRepositoryMenu>();

            /* register observer */
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(i => i.Namespace.Contains("Design_Patterns_Assignment.Observer"))
                .As(i => i.GetInterfaces()
                .FirstOrDefault(n => n.Name == "I" + i.Name))
                .AsImplementedInterfaces();

            /* register repository */
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(i => i.Namespace.Contains("Design_Patterns_Assignment.Repository"))
                .As(i => i.GetInterfaces()
                .FirstOrDefault(n => n.Name == "I" + i.Name))
                .AsImplementedInterfaces();

            return builder.Build();
        }
    }
}
