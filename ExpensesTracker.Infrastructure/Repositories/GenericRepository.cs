using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpensesTracker.Core.Interfaces;
using ExpensesTracker.Infrastructure.Data;

namespace ExpensesTracker.Infrastructure.Repositories
{
    internal class GenericRepository : IGenericRepository
    {
        private readonly AppDbContext appDbContext;
        public GenericRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public Task<T> Add<T>(T entity) where T : class
        {
            appDbContext.Set<T>().Add(entity);
            return Task.FromResult(entity);
        }
        public Task Delete<T>(T entity) where T : class
        {
            appDbContext.Set<T>().Remove(entity);
            return Task.CompletedTask;
        }
        public Task<IEnumerable<T>> GetAll<T>() where T : class
        {
            appDbContext.Set<T>().ToList();
            return Task.FromResult(appDbContext.Set<T>().AsEnumerable());
        }
        public Task<T> GetById<T>(int id) where T : class
        {
            var entity = appDbContext.Set<T>().Find(id);
            if (entity == null)
            {
                throw new Exception("Entity not found");
            }
            return Task.FromResult(entity);
        }
        public Task<T> Update<T>(T entity) where T : class
        {
            var updatedEntity = appDbContext.Set<T>().Update(entity);
            return Task.FromResult(updatedEntity.Entity);
        }
    }
}
