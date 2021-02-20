using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Domain.Models
{
    public class TaskTag : DomainObject
    {
        public Task Task { get; set; }
        public Tag Tag { get; set; }

    }
}
