using MyTasks.Core.Models;
using MyTasks.Core.Models.Domains;
using System;
using System.Collections.Generic;
using System.Linq;


namespace MyTasks.Core.ViewModels
{
    public class TasksViewModel
    {
        public IEnumerable<Task> Tasks { get; set; }

        public IEnumerable<Category> Categories { get; set; }

        public FilterTask FilterTasks { get; set; }
        public object Heading { get; set; }
    }
}
