using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp293
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine($"The date and time now is {currentDateTime}");
            Console.WriteLine("Please enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The date and time in {number} hours would be {currentDateTime.AddHours(number)}");
            Console.ReadLine();

        }
    }
}
