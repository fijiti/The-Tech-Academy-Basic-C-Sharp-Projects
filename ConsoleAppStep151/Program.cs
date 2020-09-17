using System;

namespace ConsoleAppStep151
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input number to multiply by 50: ");
            long num = long.Parse(Console.ReadLine());
            long product = num * 50;
            Console.WriteLine($"Your result is: {product}");

            Console.WriteLine("Input a number to add 25 to: ");
            int num1 = int.Parse(Console.ReadLine());
            int sum = num1 + 25;
            Console.WriteLine($"Your result is: {sum}");

            Console.WriteLine("Input a number to divide by 12.5: ");
            float num2 = float.Parse(Console.ReadLine());
            float result = num2 / 12.5f;
            Console.WriteLine($"Your result is: {result}");

            Console.WriteLine("Input a number and we will see if it is greater than 50: ");
            int num3 = int.Parse(Console.ReadLine());
            if (num3 > 50)
            {
                Console.WriteLine("Number you entered is greater than 50!");
            }
            else
            {
                Console.WriteLine("Numer you entered is not greater than 50!");
            }

            Console.WriteLine("Input a number and we will divide it by 7 and return the remainder: ");
            int num4 = int.Parse(Console.ReadLine());
            int remainder = num4 % 7;
            Console.WriteLine($"The remainder is: {remainder}");

           
        }
    }
}
