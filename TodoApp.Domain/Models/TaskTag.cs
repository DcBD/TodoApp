using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApp.Domain.Models
{
    public class TaskTag
    {

        public int Id { get; set; }
        public Task Task { get; set; }

        public Tag Tag { get; set; }

    }
}
