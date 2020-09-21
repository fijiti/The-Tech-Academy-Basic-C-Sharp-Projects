using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters220
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOptions addOneOrTwo = new MathOptions();
            Console.WriteLine("Testing optional parameter:");
            int result = 0;
            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number (Optional):");
            string number = Console.ReadLine();
            if (string.IsNullOrEmpty(number))
            {
                result = addOneOrTwo.AddOneOrTwo(num1);
                Console.WriteLine($"{num1} + 0 = {result}");
            }
            else
            {
                int num2 = Convert.ToInt32(number);
                result = addOneOrTwo.AddOneOrTwo(num1, num2);
                Console.WriteLine($"{num1} + {num2} = {result}"); 
            }
            Console.WriteLine("Thanks!");
            Console.ReadLine();

        }
    }
}
