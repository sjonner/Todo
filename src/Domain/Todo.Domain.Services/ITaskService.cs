using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Todo.Domain.Entities;

namespace Todo.Domain.Services
{
    public interface ITaskService
    {
        Task Persist(Task task);
        IQueryable<Task> GetAll();
    }
}
