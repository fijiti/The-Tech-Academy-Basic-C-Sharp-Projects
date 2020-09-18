using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ConsoleAppArraysAndLists191
{
    class Program
    {
        static void Main()
        {
            // Page 191
            // Array of strings 
            string[] names = { "John", "Jim", "Joe", "Mary", "Elmer" };
            Console.WriteLine("Help me test out the Indexes of my String Array of Names:");
            Console.WriteLine("Choose an index number:");
            int number = int.Parse(Console.ReadLine());
            int i = 0;
            do
            {
                if (number >= 0 && number < names.Length)
                {
                    Console.WriteLine($"Name: {names[number]}");
                    if (i == 3) { break; }
                    else
                    {
                        Console.WriteLine("Choose Another:");
                        number = int.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    Console.WriteLine("Not in Array.");
                    if (i == 3) { break; }
                    else
                    {
                        Console.WriteLine("Choose Another:");
                        number = int.Parse(Console.ReadLine());
                    }
                }
                i++;
            } while (i < 4);
            Console.WriteLine("Thanks!");

            // Array of integers 
            int[] numbers = { 4, 5, 33, 55, 344, 45, 54 };
            Console.WriteLine("\nHelp me test out the Indexes of my Integer Array of Numbers:");
            Console.WriteLine("Choose an index number:");
            int num1 = int.Parse(Console.ReadLine());
            int y = 0;

            do
            {
                if (num1 >= 0 && num1 < numbers.Length)
                {
                    Console.WriteLine($"Number: {numbers[num1]}");
                    if (y == 3) { break; }
                    else
                    {
                        Console.WriteLine("Choose Another:");
                        num1 = int.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    Console.WriteLine("Not in Array.");
                    if (y == 3) { break; }
                    else
                    {
                        Console.WriteLine("Choose Another:");
                        num1 = int.Parse(Console.ReadLine());
                    }
                }
                y++;
            } while (y < 4);
            Console.WriteLine("Thanks!");

            // List of strings
            List<string> animals = new List<string>(){"Bear", "Lion", "Tiger", "Giraffe", "Moose", "Wolf", "Fox"};
            Console.WriteLine("\nHelp me test out the Indexes of my List of Animals:");
            Console.WriteLine("Choose an index number:");
            int num2 = int.Parse(Console.ReadLine());
            int z = 0;
            do
            {
                if (num2 >= 0 && num2 < animals.Count)
                {
                    Console.WriteLine($"Animal: {animals[num2]}");
                    if (z == 3) { break; }
                    else
                    {
                        Console.WriteLine("Choose Another:");
                        num2 = int.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    Console.WriteLine("Not in Array.");
                    if (z == 3) { break; }
                    else
                    {
                        Console.WriteLine("Choose Another:");
                        num2 = int.Parse(Console.ReadLine());
                    }
                }
                z++;
            } while (z < 4);
            Console.WriteLine("Thanks!");



            Console.ReadLine();


        }
    }
}
