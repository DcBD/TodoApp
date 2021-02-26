using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Domain.Models
{
    /// <summary>
    /// Task tag model
    /// </summary>
    public class TaskTag : DomainObject
    {
        /// <summary>
        /// Task
        /// </summary>
        public Task Task { get; set; }
        /// <summary>
        /// Tag
        /// </summary>
        public Tag Tag { get; set; }

    }
}
