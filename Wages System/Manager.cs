using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wages_System
{
    public class Manager : Employee
    {
        private const decimal AllowanceRate = 0.05m;

        public Manager(int id, string name, decimal loggedHours, decimal wage) : base(id, name, loggedHours, wage)
        {

        }
        private decimal CalculateAllowance()
        {
            return base.CalculateTotal() * AllowanceRate;
        }
        protected override decimal CalculateTotal()
        {
            return base.CalculateTotal() + CalculateAllowance();
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"\nAllowance: ${Math.Round(CalculateAllowance(), 2):N0}" +
                   $"\nNet Salary: ${Math.Round(this.CalculateTotal(), 2):N0}";
        }
    }
}
