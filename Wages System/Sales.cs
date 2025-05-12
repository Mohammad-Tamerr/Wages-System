using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wages_System
{
    internal class Sales: Employee
    {
        protected decimal SalesVolume { get; set; }
        protected decimal Commission { get; set; }

        public Sales(int id, string name, decimal loggedHours, decimal wage , 
            decimal SalesVolume , decimal Commission) : base(id, name, loggedHours, wage)
        {
            this.SalesVolume = SalesVolume;
            this.Commission = Commission;
        }

        private decimal CalculateBonus()
        {
            return SalesVolume * Commission;
        }

        protected override decimal CalculateTotal()
        {
            return base.CalculateTotal() + CalculateBonus();
        }
        public override string ToString()
        {
            return base.ToString() +
                   $"\nCommission: {Math.Round(Commission * 100, 2):N0}%" +
                   $"\nBonus: ${Math.Round(CalculateBonus(), 2):N0}" +
                   $"\nNet Salary: ${Math.Round(this.CalculateTotal(), 2):N0}";
        }

    }
}
