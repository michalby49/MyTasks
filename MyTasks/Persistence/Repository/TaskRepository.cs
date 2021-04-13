using MyTasks.Core.Models.Domains;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyTasks.Persistence.Repository
{
    public class TaskRepository
    {

        public IEnumerable<Task> Get(string userId, bool isExecuted = false, int categoryId = 0, string Title = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetCategories()
        {
            throw new NotImplementedException();
        }

        public Task Get(int id, string userId)
        {
            throw new NotImplementedException();
        }
    }

}

