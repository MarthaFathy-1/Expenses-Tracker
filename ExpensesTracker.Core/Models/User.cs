using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracker.Core.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<Expense> Expenses { get; set; }
        public ICollection<Budget> Budgets { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
