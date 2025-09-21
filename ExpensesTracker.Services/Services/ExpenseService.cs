using ExpensesTracker.Core.Interfaces;
using ExpensesTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracker.Services.Services
{
    public class ExpenseService
    {
        private readonly IGenericRepository _repo;
        public ExpenseService(IGenericRepository repo)
        {
            _repo = repo;
        }
        public async Task AddExpense(Expense expense)
        {
            await _repo.Add(expense);
        }

        public async Task<IEnumerable<Expense>> GetAllExpenses()
        {
            return await _repo.GetAll<Expense>();
        }
        public async Task<Expense> GetExpenseById(int id)
        {
            return await _repo.GetById<Expense>(id);
        }
        public async Task UpdateExpense(Expense expense)
        {
            await _repo.Update(expense);
        }
        public async Task DeleteExpense(Expense expense)
        {
            await _repo.Delete(expense);
        }
    }
}
