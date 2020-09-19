using System;
using System.Collections.Generic;

namespace ConsoleAppTryCatch207
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>() { 4, 6, 33, 54, 34, 123, 3, 345, 333 };
            bool isValidNow = false;
            do
            {
                Console.WriteLine("Enter a number to divide all the numbers in a list:");

                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    int result;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        result = numbers[i] / number;
                        Console.WriteLine($"{numbers[i]} / {number} = {result}");
                        isValidNow = true;
                    }

                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please enter a whole number.");
                    Console.WriteLine("Try again!");


                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Please do not divide by 0");
                    Console.WriteLine("Try again!");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again!");


                }
                finally
                {
                    Console.WriteLine("");

                }
            } while (!isValidNow);
            Console.WriteLine("Thanks!");
            Console.ReadLine();
        }
    }
}
