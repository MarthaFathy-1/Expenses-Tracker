using ExpensesTracker.Core.Interfaces;
using ExpensesTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracker.Services.Services
{
    public class BudgetService
    {
        private readonly IGenericRepository _repo;
        public BudgetService(IGenericRepository repo)
        {
            _repo = repo;
        }

        public async Task AddBudget(Budget budget)
        {
            await _repo.Add(budget);
        }
        public async Task<IEnumerable<Budget>> GetAllBudgets()
        {
            return await _repo.GetAll<Budget>();
        }
        public async Task<Budget> GetBudgetById(int id)
        {
            return await _repo.GetById<Budget>(id);
        }
        public async Task UpdateBudget(Budget budget)
        {
            await _repo.Update(budget);
        }
        public async Task DeleteBudget(Budget budget)
        {
            await _repo.Delete(budget);
        }
    }
}
