namespace Todo.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Todo.Domain.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<Todo.Data.EntityFramework.TaskDao>
    {
        public Configuration()
        {
            //Keep this in sync for now by changing the default value
            AutomaticMigrationsEnabled = true;
        }

        /// <summary>
        /// Setup DB with default values every time we change the models
        /// Please select the entity framework as start up project when start migration
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(Todo.Data.EntityFramework.TaskDao context)
        {
            //1. Add some test data and check if exists based on description
            context.Tasks.AddOrUpdate(t => t.Description,
                new Task() { Description = "Add IoC", IsDone = true },
                new Task() { Description = "Add EF", IsDone = true },
                new Task() { Description = "Add unit", IsDone = false });

            //2. Select Entityframework as default project

            //3. Use update-database command in the package manager
        }
    }
}
