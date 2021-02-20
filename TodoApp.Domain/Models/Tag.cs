using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Domain.Models
{
    public class Tag : DomainObject
    {
        public string Name { get; set; }
    }
}
