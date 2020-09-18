using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            // Page 187 Array Practice
            Console.WriteLine("Testing values for different ways of initializing Arrays in C#:");
            int[] numArray = new int[5];
            numArray[0] = 5;
            numArray[1] = 2;
            numArray[2] = 10;
            numArray[3] = 200;
            numArray[4] = 5000;
            Console.WriteLine($"numArray[3] 200?: { numArray[3]}");

            int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };
            Console.WriteLine($"numArray1[3] 200?: { numArray1[3]}");

            int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };
            Console.WriteLine($"numArray2[3] 200?: {numArray2[3]}");

            Console.WriteLine("\nChanging data in array:");
            Console.WriteLine($"numArray2[5] before change: {numArray2[5]}");
            numArray2[5] = 650;
            Console.WriteLine($"numArray2[5] after change: {numArray2[5]}");

            //Now working with lists
            Console.WriteLine("\nNow using Lists:");

            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(10);


            Console.WriteLine($"intList[0] 4?: {intList[0]}");
            Console.WriteLine($"intList[1] 10?: {intList[1]}");
            intList.Remove(10);
            intList.Add(33);
            Console.WriteLine($"intList[1] after intList.Remove(10) and intList.Add(33): { intList[1]}");

            Console.WriteLine("\nList of strings:");
            List<string> stringList = new List<string>();
            stringList.Add("Hello!");
            stringList.Add("Hello Again!");
            Console.WriteLine($"stringList[0]: {stringList[0]}\nstringList[1]: {stringList[1]}");

           



            Console.ReadLine();
        }
    }
}
