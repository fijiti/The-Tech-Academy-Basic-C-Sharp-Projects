using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppSixPartStarts197
{
    class Program
    {
        static void Main()
        {
            // Array that has user input strings 
            string[] words = new string[4];
            Console.WriteLine("Part 1:");
            Console.WriteLine("Enter words below:");
            string word;

            for (int i = 0; i < words.Length; i++)
            { 
                Console.WriteLine("Enter word:");
                word = Console.ReadLine();
                words[i] = word;
            }
            Console.WriteLine("Here are the words you entered:");
            foreach (string item in words)
            {
                Console.WriteLine(item);

            }


            // Part 2 
            // Infinite loop and finite loop.
            Console.WriteLine("\nPart 2:");
            Console.WriteLine("Below is finite loop. Commented out infinite loop:");
            // infinate loop and then fixed
            //bool isTrue = true;
            //while (isTrue)
            //{
            //    Console.WriteLine("Hello");
            //}
            bool isTrue = false;
            int x = 0;
            while(!isTrue)
            {
                if(x < 4)
                {
                    Console.WriteLine("Continuing loop!");
                } else
                {
                    isTrue = true;
                    Console.WriteLine("Loop ending now!");
                }
               x++;
            }

            // Part 3
            // Loop controlled by boolean values
            Console.WriteLine("\nPart 3:");
            Console.WriteLine("Loop will continue while number is < 4:");
            for (int i = 0; i < 6; i++)
            {
                if(i < 4)
                {
                    Console.WriteLine($"Number is: {i}");

                }
                else
                {
                    Console.WriteLine("Number is no longer < 4.");
                    break;
                }

            }

            Console.WriteLine("\nLoop continues while number <= 4:");
            for (int i = 0; i < 6; i++)
            {
               if(i <= 4)
               {
                   Console.WriteLine($"Number is: {i}");
               }
               else
               {
                   Console.WriteLine("Number is no longer <= 4.");
                    break;
              }
            }


            // Part 4:
            // List of strings to access on command line
            Console.WriteLine("\nPart 4:");
            List<string> animals = new List<string>(){"bear", "lion", "tiger", "fox", "wolf"};
            bool isGuessed = false;
            string animal;
            Console.WriteLine("\nHere is an animal name guessing game:");
            Console.WriteLine("Guess an animal name:");
            do {
                
                animal = Console.ReadLine();
                if (animals.IndexOf(animal.ToLower()) == -1) {
                    Console.WriteLine("Not on list.  Guess again:");
                
                } else {
                    
                    Console.WriteLine($"You got it and it is at index {animals.IndexOf(animal.ToLower())}");
                    isGuessed = true;
                
                }
            
            } while(!isGuessed);

            // Part 5
            // List of strings where two strings are identical.  Will do same type of search as above. 
            Console.WriteLine("\nPart 5:");
            List<string> sports = new List<string>(){"baseball", "basketball", "football", "soccer", "cricket", "football"};
            bool guessedSport = false;
            string sport;
            Console.WriteLine("Guess a name of a sport.  Use one word:");
            Console.WriteLine("Guess below:");
            do {
                sport = Console.ReadLine();
                if(sports.IndexOf(sport.ToLower()) == -1 ) {
                    Console.WriteLine("Thats not one. Guess Again: ");
                
                } else {
                    Console.WriteLine($"You guessed it and the index is at {sports.IndexOf(sport.ToLower())}");
                    guessedSport = true;
                }
            
            } while(!guessedSport);

            // Part 6 
            // Creating a list of strings with duplicate strings and using a for loop to iterate through list and will note duplicate string.
            Console.WriteLine("\nPart 6:");
            Console.WriteLine("Foreach itterates through list and flags duplicate:");
            List<string> cars = new List<string>(){"Camaro", "Ferrari", "Firebird", "Corvette", "Camaro", "Mustang", "Miata" };
            List<string> dupCheck = new List<string>();
            foreach (var car in cars)
	        {
                if (dupCheck.IndexOf(car) == -1){
                    dupCheck.Add(car);
                    Console.WriteLine(car);
                
                } else {
                    
                    Console.WriteLine($"{car} has already appeared on the list.");
                    dupCheck.Add(car);
                
                }
 
	        }

            Console.WriteLine("\nThanks!");
            Console.ReadLine();
        }
    }
}
