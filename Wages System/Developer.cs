using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wages_System
{
    internal class Developer : Employee
    {
        private const decimal Commission = 0.03m;
        protected bool TaskCompleted { get; set; }

        public Developer(int id, string name, decimal loggedHours, decimal wage,
           bool taskCompleted) : base(id, name, loggedHours, wage)
        {
            this.TaskCompleted = taskCompleted;
        }

        private decimal CalculateBonus()
        {
            if (TaskCompleted) 
            return Commission * base.CalculateTotal();
            else return 0;
        }

        protected override decimal CalculateTotal()
        {
            return base.CalculateTotal() + CalculateBonus();
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"\nTask Completed: ${(TaskCompleted ? "Yes" : "No")}" +
                   $"\nBonus: ${Math.Round(CalculateBonus(), 2):N0}" +
                   $"\nNet Salary: ${Math.Round(this.CalculateTotal(), 2):N0}";
        }
    }
}
