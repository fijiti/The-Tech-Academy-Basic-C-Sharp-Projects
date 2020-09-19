using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Pick a number:");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick another number:");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine($"{numberOne} diveded by {numberTwo} equals {numberThree}");
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
