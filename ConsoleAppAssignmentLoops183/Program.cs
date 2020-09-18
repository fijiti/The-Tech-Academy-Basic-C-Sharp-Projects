using System;
using System.Runtime.Remoting.Contexts;

namespace ConsoleAppAssignmentLoops183
{
    class Program
    {
        static void Main()
        {
            // While Loop
            Console.WriteLine("Here is a boolean comparison using a While Loop:");
            int num = 1;

            while (num < 8)
            {
                Console.WriteLine($"The Number is now {num}");
                num++;
            }

            // Do While loop
            Console.WriteLine("\nHere is boolean comparison using a Do While Loop:");
            Console.WriteLine("Guess a number 1 to 7: ");
            int number = int.Parse(Console.ReadLine());
            bool isGuessed = number == 6;
            do
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("You guessed 1. Try again");
                        number = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You guessed 2. Try again");
                        number = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed 3. Try again");
                        number = int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("You guessed 4. Try again");
                        number = int.Parse(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("You guessed 5. Try again");
                        number = int.Parse(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("You guessed correctly. The number is 6!");
                        isGuessed = true;
                        break;
                    case 7:
                        Console.WriteLine("You guessed 7. Try again");
                        number = int.Parse(Console.ReadLine());
                        break;


                    default:
                        Console.WriteLine("Not in the right ball park. Try again.");
                        number = int.Parse(Console.ReadLine());
                        break;
                }
            } while (!isGuessed);

            Console.ReadLine();
        }
    }
}
