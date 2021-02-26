using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TodoApp.Domain.Enums;

namespace TodoApp.Domain.Models
{
    /// <summary>
    /// Task model
    /// </summary>
    public class Task : DomainObject
    {
        /// <summary>
        /// Task name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Task description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Task start time
        /// </summary>
        public DateTime? Start { get; set; }

        /// <summary>
        /// Task status
        /// </summary>
        public Status Status { get; set; } = Status.NEW;

        /// <summary>
        /// Tasks tags
        /// </summary>
        public IEnumerable<TaskTag> TaskTags { get; set; }

        /// <summary>
        /// Task status but in text format
        /// </summary>
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
