using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp224
{
    public class DoMath
    {
        public void DivideByTwo(int number)
        {
            int result = number / 2;
            Console.WriteLine(result);
        }

        public void NumbersChanged (out int num1, out int num2)
        {
            num1 = 7;
            num2 = 7;
        }

        public void NumbersChanged (int num1, int num2)
        {
            num1 += num1;
            num2 += num2;
            Console.WriteLine($"num1: {num1}, num2: {num2}");
        }
    }
}
