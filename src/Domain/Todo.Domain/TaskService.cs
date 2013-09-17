using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Todo.Data.Services;
using Todo.Domain.Entities;
using Todo.Domain.Services;

namespace Todo.Domain
{
    public class TaskService : ITaskService
    {
        protected ITaskDao taskDao;


        public TaskService(ITaskDao taskDao)
        {
            this.taskDao = taskDao;
        }

        public Task Persist(Task task)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Task> GetAll()
        {
            return taskDao.GetAll();
        }
    }
}
