using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp224
{
    class Program
    {
        static void Main(string[] args)
        {
            DoMath aResult = new DoMath();
            Console.WriteLine("Enter a number:");
            int aNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number divided by 2:");
            aResult.DivideByTwo(aNumber);

            int num1 = 0;
            int num2 = 0;
            
            Console.WriteLine("\nLocal before NumbersChanged(out num1, out num2):");
            Console.WriteLine($"num1: {num1}, num2: {num2}");
            aResult.NumbersChanged(out num1, out num2);
            Console.WriteLine("Local after NumbersChanged(out num1, out num2):");
            Console.WriteLine($"num1: {num1}, num2: {num2}");
         
            
            Console.WriteLine("\nOverloaded method (NumbersChanged(num1, num2) output:");
            aResult.NumbersChanged(num1, num2);
            Console.WriteLine($"Not changed locally:");
            Console.WriteLine($"num1: {num1}, num2: {num2}");

            int result2 = DoMoreMath.NumberSquared(7);
            Console.WriteLine("\nHere is result from static class DoMoreMath.NumberSquared(7):");
            Console.WriteLine(result2);

            


            Console.ReadLine();
        }
    }
}
