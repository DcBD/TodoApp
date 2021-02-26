using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Domain.Models
{
    /// <summary>
    /// Tag model
    /// </summary>
    public class Tag : DomainObject
    {
        /// <summary>
        /// Tag name
        /// </summary>
        public string Name { get; set; }
    }
}
