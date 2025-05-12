using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wages_System
{
    public class Employee
    {
        public const int MinimumLoggedHours = 176;
        public const decimal OverTimeRate = 1.25m;
        protected int Id { get; set; }
        protected string Name { get; set; }
        protected decimal LoggedHours { get; set; }
        protected decimal Wage { get; set; }

        public Employee(int id, string name, decimal loggedHours, decimal wage)
        {
            this.Id = id;
            this.Name = name;
            this.LoggedHours = loggedHours;
            this.Wage = wage;
        }

        private decimal CalculateBaseSalary()
        {
            decimal regularHours = Math.Min(LoggedHours, MinimumLoggedHours);
            return regularHours * Wage;
        }
        private decimal CalculateOverTime()
        {
            var additionalHours = ((LoggedHours - MinimumLoggedHours) > 0 ? LoggedHours - MinimumLoggedHours : 0);
            return (additionalHours * Wage * OverTimeRate);
        }
        protected virtual decimal CalculateTotal()
        {
            return CalculateBaseSalary() + CalculateOverTime();
        }

        public override string ToString()
        {
            var type = GetType().ToString().Replace("Wages_System.", "");
            return $"{type}:" +
                   $"\nId: {Id}" +
                   $"\nName: {Name}" +
                   $"\nLogged Hours: {LoggedHours} hrs" +
                   $"\nWage: {Wage} $/hr" +
                   $"\nBase Salary: ${Math.Round(CalculateBaseSalary(), 2):N0}" +
                   $"\nOvertime: ${Math.Round(CalculateOverTime(), 2):N0}";
        }
    }
}
