using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp307
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validAnswer = false;
            int age = 0;
            DateTime currentDate = DateTime.Now;
     
            while (!validAnswer)
            {
                try
                {
                    Console.WriteLine("What is your age?");
                    age = Convert.ToInt32(Console.ReadLine());
                    if (age <= 0)
                    {                      
                        Console.WriteLine("Your age cannot be zero or negative.");
                        validAnswer = false;
                    }
                    else
                    {
                        int yearBorn = currentDate.Year - age;
                        Console.WriteLine($"You were born in {yearBorn}");
                        validAnswer = true;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("You need to put in digits, no decimals");
                    validAnswer = false;

                }
            }
            Console.WriteLine("\nThanks!");
            Console.ReadLine();

        }

    }
}
