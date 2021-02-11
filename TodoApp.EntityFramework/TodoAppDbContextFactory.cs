using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.EntityFramework
{
    public class TodoAppDbContextFactory
    {
        
        public TodoAppDbContext CreateDbContext()
        {
            return new TodoAppDbContext();
        }

    }
}
