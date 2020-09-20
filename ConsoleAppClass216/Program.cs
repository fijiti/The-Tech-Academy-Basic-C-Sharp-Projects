using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClass216
{
    class Program
    {
        static void Main(string[] args)
        {
            MathMethods doMath = new MathMethods();
            bool isValidInput = false;
            Console.WriteLine("Im testing some class methods:");
            do
            {
                try
                {

                    Console.WriteLine("Choose a whole number:");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{number} + 5 = {doMath.addFive(number)}");
                    Console.WriteLine($"{number} * 5 = {doMath.timesFive(number)}");
                    Console.WriteLine($"{number} Squared is {doMath.squareNumber(number)}");
                    isValidInput = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please input a whole number.");
                  
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                 
                }
                finally
                {
                    Console.WriteLine("");
                }
            } while (!isValidInput);
            Console.WriteLine("Thanks!");
            Console.ReadLine();

        }
    }
}
