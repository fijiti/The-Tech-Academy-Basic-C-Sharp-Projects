using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp265
{
    class Program
    {
        static void Main(string[] args)
        {
            // Created list of employees
            List<Employee> employees = new List<Employee>();
            employees.AddRange(new List<Employee>
            {
                new Employee("Joe", "Smith", 1),
                new Employee("Elmer", "Johnson", 2),
                new Employee("Jeff", "Johnson", 3),
                new Employee("Jim", "Ash", 4),
                new Employee("Joe", "Johnson", 5),
                new Employee("Jeff", "Johnson", 6),
                new Employee("Mary", "Ash", 7),
                new Employee("Fred", "Smith", 8),
                new Employee("Lola", "Green", 9),
                new Employee("Alice", "Ash", 10)
            });

            // Printed employee list to console.
            Console.WriteLine("Original Employee List:");
            foreach(Employee employee in employees)
            {
                Console.WriteLine($"Id: {employee.Id}\t{employee.FirstName} {employee.LastName} ");
            }

            // Created new list using foreach loop checking where first name Joe matched. 
            List<Employee> newList = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    newList.Add(employee);
                }
            }

            // Printed newList to screen
            Console.WriteLine("\nNew list where first name is Joe matched using foreach loop:");
            foreach (Employee employee in newList)
            {
                Console.WriteLine($"Id: {employee.Id}\t{employee.FirstName} {employee.LastName} ");
            }

            // Created new list where employee first name Joe matched using Lambda
            List<Employee> newList2 = employees.Where(x => x.FirstName == "Joe").ToList();

            // Printed new list to screen.
            Console.WriteLine("\nNew list where first name Joe matched using Lambda:");
            foreach (Employee employee in newList2)
            {
                Console.WriteLine($"Id: {employee.Id}\t{employee.FirstName} {employee.LastName}");
            }

            // Created new list whre employee Id number greater than 5 using Lambda
            List<Employee> newList3 = employees.Where(x => x.Id > 5).ToList();

            // Printed newList3 to screen
            Console.WriteLine("\nNew list where Id number greater than 5 using Lambda:");
            foreach (Employee employee in newList3)
            {
                Console.WriteLine($"Id: {employee.Id}\t{employee.FirstName} {employee.LastName}");
            }

            Console.WriteLine("\nThanks!");
            Console.ReadLine();

        }
    }
}
