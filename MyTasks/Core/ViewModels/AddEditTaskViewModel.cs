using MyTasks.Core.Models.Domains;
using System;
using System.Collections.Generic;
using System.Linq;


namespace MyTasks.Core.ViewModels
{
    public class AddEditTaskViewModel
    {

        public string Heading { get; set; }

        public Task Task { get; set; }

        public IEnumerable<Category> Categories { get; set; }
    }
}
