using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Todo.Domain.Entities;

namespace Todo.Data.Services
{
    public interface ITaskDao
    {
        Task Persist(Task task);
        IQueryable<Task> GetAll();
    }
}
