using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Models;
using TodoApp.Domain.Services;

namespace TodoApp.EntityFramework.Services
{
    public class GenericDataService<T> : IDataService<T> where T : DomainObject
    {

        private readonly TodoAppDbContextFactory _contextFactory;
        /// <summary>
        /// Creates an instance of GenericDataService
        /// </summary>
        /// <param name="contextFactory"></param>
        public GenericDataService(TodoAppDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }
        /// <summary>
        /// Creates an entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<T> Create(T entity)
        {
            using(TodoAppDbContext context = _contextFactory.CreateDbContext())
            {
                var createdEntity = context.Set<T>().Add(entity);
                context.SaveChanges();

                return createdEntity;
            }
        }


        /// <summary>
        /// Gets all entities
        /// </summary>
        /// <returns></returns>
        public List<T> GetAllItems()
        {
            using (TodoAppDbContext context = _contextFactory.CreateDbContext())
            {
                List<T> entities = context.Set<T>().ToList();

                return entities;
            }
        }
        /// <summary>
        /// Deletes entity
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> Delete(int id)
        {
            using (TodoAppDbContext context = _contextFactory.CreateDbContext())
            {
                T entity = context.Set<T>().FirstOrDefault((e) => e.Id == id);
                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();

                return true;
            }
        }
        /// <summary>
        /// Gets entity
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<T> Get(int id)
        {
            using (TodoAppDbContext context = _contextFactory.CreateDbContext())
            {
                T entity = context.Set<T>().FirstOrDefault((e) => e.Id == id);

                return entity;
            }
        }
        /// <summary>
        /// Gets all entities
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<T>> GetAll()
        {
            using (TodoAppDbContext context = _contextFactory.CreateDbContext())
            {
                IEnumerable<T> entities = context.Set<T>().ToList();

                return (Task<IEnumerable<T>>)entities;
            }
        }
        /// <summary>
        /// Updates entity
        /// </summary>
        /// <param name="id"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<T> Update(int id, T entity)
        {
            using (TodoAppDbContext context = _contextFactory.CreateDbContext())
            {
                entity.Id = id;

                context.Set<T>().Add(entity);

                await context.SaveChangesAsync();

                return entity;
            }
        }

    }
}
