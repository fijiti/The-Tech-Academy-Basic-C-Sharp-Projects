using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp221
{
    class Program
    {
        static void Main(string[] args)
        {
            MathAndDisplay mathAndShow = new MathAndDisplay();
            mathAndShow.SquareOneShowOne(55, 44);
            mathAndShow.SquareOneShowOne(number1: 27, number2: 777);
            Console.ReadLine();
        }
    }
}
