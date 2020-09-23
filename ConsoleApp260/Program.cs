using System;


namespace ConsoleApp260
{
    class Program
    {
        static void Main()
        {
            Number number = new Number();
            number.Amount = 14.57m;
            Console.WriteLine($"The Amount assigned to number is {number.Amount}");
            Console.ReadLine();
        }
    }
}
