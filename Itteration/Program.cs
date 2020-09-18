using System;
using System.Collections.Generic;

namespace Itteration
{
    class Program
    {
        static void Main()
        {
            int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 98, 94};

            for (int i = 0; i< testScores.Length; i++)
            {
                if (testScores[i] > 85)
                {
                    Console.WriteLine("Passing test score: " + testScores[i]);
                }
            }

            string[] names = { "Jesse", "Erik", "Daniel", "Adam" };
            for (int j = 0; j < names.Length; j++)
            { 
                if (names[j] == "Jesse")
                {
                    Console.WriteLine(names[j]);
                }
               
               
            }

            List<int> testScores2 = new List<int>();
            testScores2.Add(98);
            testScores2.Add(99);
            testScores2.Add(81);
            testScores2.Add(72);
            testScores2.Add(70);

            foreach (int score in testScores2)
            {
                if (score > 85)
                {
                    Console.WriteLine("Passing test score: " + score);
                }
            }

            List<string> names2 = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };
            foreach (string name in names2)
            {
          
                Console.WriteLine(name);
               
            }

            List<int> testScores3 = new List<int>() { 98, 99, 12, 74, 23, 99 };
            List<int> passingScores = new List<int>();
            foreach (int score in testScores3)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }
            Console.WriteLine($"Passing Scores Count: {passingScores.Count}");


            Console.ReadLine();

        }
    }
}
