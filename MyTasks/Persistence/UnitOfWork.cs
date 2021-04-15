using MyTasks.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTasks.Persistence
{
    public class UnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Task = new TaskRepository(context);
        }

        public TaskRepository Task { get; set; }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}
