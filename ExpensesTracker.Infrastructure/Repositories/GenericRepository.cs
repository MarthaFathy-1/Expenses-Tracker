using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpensesTracker.Core.Interfaces;

namespace ExpensesTracker.Infrastructure.Repositories
{
    internal class GenericRepository : IGenericRepository
    {
        public Task<T> Add<T>(T entity) where T : class
        {
            return Task.FromResult(entity);
        }
        public Task Delete<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<T>> GetAll<T>() where T : class
        {
            throw new NotImplementedException();
        }
        public Task<T> GetById<T>(int id) where T : class
        {
            throw new NotImplementedException();
        }
        public Task<T> Update<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
