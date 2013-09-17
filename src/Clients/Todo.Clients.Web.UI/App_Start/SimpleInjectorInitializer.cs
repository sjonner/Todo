using Todo.Domain;
using Todo.Domain.Services;

[assembly: WebActivator.PostApplicationStartMethod(typeof(Todo.Clients.Web.UI.App_Start.SimpleInjectorInitializer), "Initialize")]

namespace Todo.Clients.Web.UI.App_Start
{
    using System.Reflection;
    using System.Web.Mvc;

    using SimpleInjector;
    using SimpleInjector.Integration.Web.Mvc;
    
    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            //// Did you know the container can diagnose your configuration? Go to: http://bit.ly/YE8OJj.
            var container = new Container();

            //Make call to Domain.IoC initializer
            Todo.Domain.IoC.SimpleInjectorInitializer.Initialize(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            
            container.RegisterMvcAttributeFilterProvider();
       
            container.Verify();
            
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }

    }
}