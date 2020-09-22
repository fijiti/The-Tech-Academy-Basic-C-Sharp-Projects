using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp248
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Instantiate Employee object with string as generic data type.");
            Console.WriteLine("Assigned a list of strings as property value of Things:");
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>() {"House", "Car", "Tree", "Ball", "Garage"};
            foreach (string thing in employee.Things)
            {
                Console.WriteLine(thing);


            }

            Console.WriteLine("\nInstantiate an Employee object with int as generic data type.");
            Console.WriteLine("Assigned a list of ints as property value of Things:");
            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int>() { 4, 5, 6, 9, 32, 55, 44 };
            foreach (int thing in employee2.Things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
            
            
            
        }
    }
}
