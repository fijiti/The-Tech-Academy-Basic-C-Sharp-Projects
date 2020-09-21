using System;


namespace ConsoleAppInputDiffTypes219
{
    class Program
    {
        static void Main()
        {

            MathMethods answers = new MathMethods();
            Console.WriteLine($"Passed 12 to MathMethod(int number) 'Returns 12 * 12 Result: {answers.MathMethod(12)}");
            Console.WriteLine($"Passed 12.44m MathMethod(decimnal number) Returns 12 + 12 Result: { answers.MathMethod(12.44m)}");
            Console.WriteLine($"Passed \"8\" to MathMethod(string number) Returns 8 - 8 Result: {answers.MathMethod("8")}");
            Console.WriteLine("All overloaded methods returned an int result.");
            Console.ReadLine();
        }
    }
}
