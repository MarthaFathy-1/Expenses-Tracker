using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracker.Core.Models
{
    public class Budget
    {
        public int Id { get; set; }
        public decimal LimitAmount { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int Month { get; set; }
        public int Year { get; set; }
        [NotMapped]
        public DateTime StartDate => new DateTime(Year, Month, 1);

        [NotMapped]
        public DateTime EndDate => new DateTime(Year, Month,
                                DateTime.DaysInMonth(Year, Month));
    }
}
