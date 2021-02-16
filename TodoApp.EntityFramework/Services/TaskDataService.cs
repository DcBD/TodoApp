using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Services;
using TaskModel = TodoApp.Domain.Models.Task ;

namespace TodoApp.EntityFramework.Services
{
    public class TaskDataService : IDataService<TaskModel>
    {
        private readonly TodoAppDbContextFactory _contextFactory;

        public TaskDataService(TodoAppDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<TaskModel> Create(TaskModel entity)
        {
            using (TodoAppDbContext context = _contextFactory.CreateDbContext())
            {
          
                var createdEntity = context.Tasks.Add(entity);
                await context.SaveChangesAsync();

                return createdEntity;
            }
        }

        public async Task<bool> Delete(int id)
        {
            using (TodoAppDbContext context = _contextFactory.CreateDbContext())
            {
                TaskModel entity = context.Set<TaskModel>().FirstOrDefault((e) => e.Id == id);
                context.Set<TaskModel>().Remove(entity);
                await context.SaveChangesAsync();

                return true;
            }
        }

        public async Task<TaskModel> Get(int id)
        {
            using (TodoAppDbContext context = _contextFactory.CreateDbContext())
            {
                TaskModel entity = context.Set<TaskModel>().FirstOrDefault((e) => e.Id == id);

                return entity;
            }
        }

        public async Task<IEnumerable<TaskModel>> GetAll()
        {
            using (TodoAppDbContext context = _contextFactory.CreateDbContext())
            {
                IEnumerable<TaskModel> entities = await context.Set<TaskModel>().ToListAsync();

                return entities;
            }
        }

        public async Task<TaskModel> Update(int id, TaskModel entity)
        {
            using (TodoAppDbContext context = _contextFactory.CreateDbContext())
            {
                entity.Id = id;

                context.Set<TaskModel>().Add(entity);

                await context.SaveChangesAsync();

                return entity;
            }
        }

        public List<TaskModel> GetAllItems()
        {
            using (TodoAppDbContext context = _contextFactory.CreateDbContext())
            {
                List<TaskModel> entities = context.Set<TaskModel>().ToList();

                return entities;
            }
        }
    }
}
