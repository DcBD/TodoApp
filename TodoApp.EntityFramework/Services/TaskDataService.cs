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
        /// <summary>
        /// Creates an instance of TaskDataService
        /// </summary>
        /// <param name="contextFactory"></param>
        public TaskDataService(TodoAppDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        /// <summary>
        /// Creates Task
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<TaskModel> Create(TaskModel entity)
        {
            using (TodoAppDbContext context = _contextFactory.CreateDbContext())
            {
          
                var createdEntity = context.Tasks.Add(entity);
                context.SaveChanges();

                return createdEntity;
            }
        }
        /// <summary>
        /// Deletes task
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> Delete(int id)
        {
            using (TodoAppDbContext context = _contextFactory.CreateDbContext())
            {
                TaskModel entity = context.Set<TaskModel>().FirstOrDefault((e) => e.Id == id);
                context.Set<TaskModel>().Remove(entity);
                context.SaveChanges();

                return true;
            }
        }
        /// <summary>
        /// Gets task
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<TaskModel> Get(int id)
        {
            using (TodoAppDbContext context = _contextFactory.CreateDbContext())
            {
                TaskModel entity = context.Set<TaskModel>().FirstOrDefault((e) => e.Id == id);

                return entity;
            }
        }
        /// <summary>
        /// Gets all tasks
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<TaskModel>> GetAll()
        {
            using (TodoAppDbContext context = _contextFactory.CreateDbContext())
            {
                IEnumerable<TaskModel> entities = await context.Set<TaskModel>().ToListAsync();

                return entities;
            }
        }
        
        /// <summary>
        /// Updates task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<TaskModel> Update(int id, TaskModel entity)
        {
            using (TodoAppDbContext context = _contextFactory.CreateDbContext())
            {
                var editedEntity = context.Tasks.Where(e => e.Id == entity.Id).First();

                context.Entry(editedEntity).CurrentValues.SetValues(entity);

                await context.SaveChangesAsync();

                return entity;
            }
        }
        /// <summary>
        /// Gets all task sync
        /// </summary>
        /// <returns></returns>
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
