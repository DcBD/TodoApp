
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using TodoApp.Domain.Models;

namespace TodoApp.EntityFramework
{
    public class TodoAppDbContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        public DbSet<TaskTag> TaskTags { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public TodoAppDbContext() : base("TodoAppDbContext")
        {

        }
        

        internal System.Threading.Tasks.Task SaveChangesAsync<T>(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
