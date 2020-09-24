using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp290
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\fijit\Logs\log.txt", false))
            {
                file.WriteLine(number);
  
            }
            string num;
            using (StreamReader file = new StreamReader(@"C:\Users\fijit\Logs\log.txt"))
            {
                num = file.ReadLine();
                
            }
            Console.WriteLine($"Your number {num} was read from the log file.");
            Console.ReadLine();
        }
    }
}
