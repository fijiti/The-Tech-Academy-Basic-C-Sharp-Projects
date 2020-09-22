using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp245
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee();
            employee1.FirstName = "Joe";
            employee1.LastName = "Smith";
            employee1.Id = 2;
            employee2.FirstName = "Jim";
            employee2.LastName = "Smith";
            employee2.Id = 3;
        
            Console.WriteLine("Employee Id's different:");
            Console.WriteLine("Calling overloaded ==:");
            Console.WriteLine(employee1 == employee2);
            Console.WriteLine("Calling overloaded !=:");
            Console.WriteLine(employee1 != employee2);
            
            Console.WriteLine("\nEmployee Id's same:");
            Console.WriteLine("Calling overloaded ==:");
            Console.WriteLine(employee2 == employee2);
            Console.WriteLine("Calling overloaded !=:");
            Console.WriteLine(employee2 != employee2);

            Console.ReadLine();

        }
    }
}
