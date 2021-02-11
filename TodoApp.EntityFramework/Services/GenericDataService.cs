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

        public GenericDataService(TodoAppDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<T> Create(T entity)
        {
            using(TodoAppDbContext context = _contextFactory.CreateDbContext())
            {
                var createdEntity = context.Set<T>().Add(entity);
                await context.SaveChangesAsync();

                return createdEntity;
            }
        }

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

        public async Task<T> Get(int id)
        {
            using (TodoAppDbContext context = _contextFactory.CreateDbContext())
            {
                T entity = context.Set<T>().FirstOrDefault((e) => e.Id == id);

                return entity;
            }
        }

        public Task<IEnumerable<T>> GetAll()
        {
            using (TodoAppDbContext context = _contextFactory.CreateDbContext())
            {
                IEnumerable<T> entities = context.Set<T>().ToList();

                return (Task<IEnumerable<T>>)entities;
            }
        }

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
