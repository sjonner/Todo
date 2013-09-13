using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Todo.Data.Services;
using Todo.Domain.Entities;

namespace Todo.Data.EntityFramework
{
    public class TaskDao : ITaskDao
    {

        public Task Persist(Task task)
        {
            return new Task() { Id = 1 };
        }
    }
}
