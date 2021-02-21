using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TodoApp.Domain.Enums;

namespace TodoApp.Domain.Models
{
    public class Task : DomainObject
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime? Start { get; set; }

        public Status Status { get; set; } = Status.NEW;

        public IEnumerable<TaskTag> TaskTags { get; set; }

        [NotMapped]
        public string StatusText { get {
                switch (this.Status)
                {
                    case Status.NEW: return "New";
                    case Status.IN_PROGRESS: return "In progress";
                    case Status.FINISHED: return "Finished";
                    default: return this.Status.ToString();
                }
            }
        }


    }
}
