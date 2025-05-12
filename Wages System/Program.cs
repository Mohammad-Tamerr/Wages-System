using System;

namespace Wages_System
{
    class Program
    {
        static void Main(string[] args)
        {
            // Developer
            Developer developer = new Developer(
                id: 1,
                name: "Ali",
                loggedHours: 180,
                wage: 50,
                taskCompleted: true
            );

            // Maintenance
            Maintenance maintenance = new Maintenance(
                id: 2,
                name: "Sara",
                loggedHours: 170,
                wage: 30
            );

            // Manager
            Manager manager = new Manager(
                id: 3,
                name: "Hossam",
                loggedHours: 185,
                wage: 60
            );

            // Sales
            Sales sales = new Sales(
                id: 4,
                name: "Nour",
                loggedHours: 178,
                wage: 40,
                SalesVolume: 20000,
                Commission: 0.02m // 2%
            );

            // info
            Console.WriteLine(developer);
            Console.WriteLine("\n----------------------\n");
            Console.WriteLine(maintenance);
            Console.WriteLine("\n----------------------\n");
            Console.WriteLine(manager);
            Console.WriteLine("\n----------------------\n");
            Console.WriteLine(sales);
        }
    }
}
