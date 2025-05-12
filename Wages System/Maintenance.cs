using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wages_System
{
    internal class Maintenance : Employee
    {
        private const decimal Hardship = 100m;

        public Maintenance(int id, string name, decimal loggedHours, decimal wage) :
            base(id, name, loggedHours, wage)
        {

        }

        protected override decimal CalculateTotal()
        {
            return base.CalculateTotal() + Hardship;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"\nHardship: ${Math.Round(Hardship, 2):N0}" +
                   $"\nNet Salary: ${Math.Round(this.CalculateTotal(), 2):N0}";
        }
    }
}
