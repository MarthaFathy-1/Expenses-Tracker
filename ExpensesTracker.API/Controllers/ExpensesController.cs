using ExpensesTracker.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExpensesTracker.Services.Services;

namespace ExpensesTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        private readonly ExpenseService _expenseService;

        public ExpensesController(ExpenseService expenseService)
        {
            _expenseService = expenseService;
        }

        [HttpPost]
        public async Task<IActionResult> AddExpense(Expense expense)
        {
            await _expenseService.AddExpense(expense);
            return Ok(expense);
        }

        [HttpGet]
        public async Task<IActionResult> GetExpenses()
        {
            var expenses = await _expenseService.GetAllExpenses();
            return Ok(expenses);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetExpenseById(int id)
        {
            var expense = await _expenseService.GetExpenseById(id);
            if (expense == null)
            {
                return NotFound();
            }
            return Ok(expense);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateExpense(int id, Expense expense)
        {
            if (id != expense.Id)
            {
                return BadRequest();
            }
            await _expenseService.UpdateExpense(expense);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExpense(int id)
        {
            var expense = await _expenseService.GetExpenseById(id);
            if (expense == null)
            {
                return NotFound();
            }
            await _expenseService.DeleteExpense(expense);
            return NoContent();
        }

    }
}
