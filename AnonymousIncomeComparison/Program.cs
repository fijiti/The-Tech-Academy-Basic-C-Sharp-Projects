using System;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");

            Console.WriteLine("What is your hourly rate of pay?");
            decimal hourlyRate = decimal.Parse(Console.ReadLine());

            Console.WriteLine("How many hours do you work per week?");
            decimal hoursPerWeek = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Person 2");

            Console.WriteLine("What is your hourly rate of pay?");
            decimal hourlyRate2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("How many hours do you work per week?");
            decimal hoursPerWeek2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Annual salary of Person 1:");
            decimal annualSalary1 = (hoursPerWeek * hourlyRate * 52m);
            Console.WriteLine($"${annualSalary1}");

            Console.WriteLine("Annual salary of Person 2:");
            decimal annualSalary2 = (hoursPerWeek2 * hourlyRate2 * 52m);
            Console.WriteLine($"${annualSalary2}");

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(annualSalary1 > annualSalary2);
        }
    }
}
