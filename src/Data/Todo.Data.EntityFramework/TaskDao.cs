using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Todo.Data.Services;
using Todo.Domain.Entities;

namespace Todo.Data.EntityFramework
{
    public class TaskDao : DbContext, ITaskDao
    {
        public TaskDao() : base("DefaultConnection") { }

        //Defines the tables for EF
        public DbSet<Task> Tasks { get; set; }

        //Interface implementations
        public Task Persist(Task task)
        {
         
            throw new NotImplementedException();
        }
     
        public IQueryable<Task> GetAll()
        {
            return Tasks;
        }
    }
}
