using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using SimpleInjector;
using SimpleInjector.Extensions;
using Todo.Data.EntityFramework;
using Todo.Data.Services;
using Todo.Domain.Services;

namespace Todo.Domain.IoC
{

    /// <summary>
    /// Register types from assemblies
    /// </summary>
    public static class SimpleInjectorInitializer
    {

        /// <summary>
        /// Initialize (called on application start)
        /// </summary>
        /// <param name="container"></param>
        public static void Initialize(Container container)
        {
            container.Register<ITaskDao, TaskDao>();
            container.Register<ITaskService, TaskService>();            
        }
    }

}
