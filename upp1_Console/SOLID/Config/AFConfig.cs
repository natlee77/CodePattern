using Autofac;
using SOLID.Interfaces;
using SOLID.Service;
using System.Linq;
using System.Reflection;

namespace SOLID.Config
{
    internal class AFConfig
    {
        internal static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // Register main application
            builder.RegisterType<Application>().As<IApplication>();

            // Register the rest of the service
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(n => n.Namespace.Contains("Menu"))
                .As(n => n.GetInterfaces()
                .FirstOrDefault(x => x.Name == "I" + n.Name))
                .AsImplementedInterfaces();
            builder.RegisterType<KennelMenu>().As<IKennelMenu>();
            builder.RegisterType<MenuManager>().As<IMenuManager>();
            builder.RegisterType<Menu>().As<IMenu >();
            builder.RegisterType<MenuItem>().As<IMenuItem>();
            builder.RegisterType<User>().As<IUser>();
            builder.RegisterType<Animal>().As<IAnimal>();
            // return builder
            return builder.Build();
        }
    }
}