using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp221
{
    class MathAndDisplay
    {
        public void SquareOneShowOne(int number1, int number2)
        {
            int result = number1 * number1;
            Console.WriteLine($"{number1} Squared is: {result}");
            Console.WriteLine($"Second number provided {number2}");
        }
    }
}
