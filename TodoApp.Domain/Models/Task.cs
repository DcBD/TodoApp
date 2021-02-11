using System;
using System.Collections.Generic;
using System.Text;
using TodoApp.Domain.Enums;

namespace TodoApp.Domain.Models
{
    public class Task : DomainObject
    {
        public Priority Priority { get; set; }

        public DateTime Start { get; set; }

        public string Name { get; set; }

        public IEnumerable<TaskTag> Tags { get; set; }

        public string Description { get; set; }

        public bool IsFinished { get; set; }
    }
}
