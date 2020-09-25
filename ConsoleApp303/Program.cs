using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp303
{
    class Program
    {
        static void Main(string[] args)
        {
            const string companyName = "Acme Widget Maker Company";
            Console.WriteLine($"Welcome to the {companyName}\n");

            // Variable using keyword var
            var employees = new List<Employee>();
            
            employees.AddRange(new List<Employee>
            {
                // Using chained constructor
                new Employee("Jim", "Smith"),
                new Employee("Jane", "Ash", 12.00m),
                new Employee("Alice", "Green", 14.00m),
                new Employee("George", "Green", 12.50m),
                // Using chained constructor
                new Employee("Mary", "Summer")

            });

            foreach (Employee employee  in employees)
            {
                Console.WriteLine($"Employee {employee.FirstName} {employee.LastName} Hourly Wage is ${employee.HourlyPay}.");
            }
            Console.WriteLine("\nThanks!");
            Console.ReadLine();
        }
    }
}

