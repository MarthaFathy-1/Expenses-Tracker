using ExpensesTracker.Core.Interfaces;
using ExpensesTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracker.Services.Services
{
    public class CategoryService
    {
        private readonly IGenericRepository _repo;
        public CategoryService(IGenericRepository repo)
        {
            _repo = repo;
        }
        public async Task AddCategory(Category category)
        {
            await _repo.Add(category);
        }
        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await _repo.GetAll<Category>();
        }
        public async Task<Category> GetCategoryById(int id)
        {
            return await _repo.GetById<Category>(id);
        }
        public async Task UpdateCategory(Category category)
        {
            await _repo.Update(category);
        }
        public async Task DeleteCategory(Category category)
        {
            await _repo.Delete(category);
        }
    }
}
