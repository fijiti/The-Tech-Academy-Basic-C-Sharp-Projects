using System;


namespace ConsoleApp254
{
    class Program
    {
        static void Main()
        {
            bool isDayOfWeek = false;
            do
            {
                try
                {
                    Console.WriteLine("Please enter a day of the week:");
                    string day = Console.ReadLine();
                    DaysOfWeek aDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), day, true);
                    Console.WriteLine($"{aDay} is a day of the week!");
                    isDayOfWeek = true;


                }
                catch (Exception)
                {

                    Console.WriteLine("That is not a day of the week.");
                }
                finally
                {
                    Console.WriteLine("");
                }
            } while (!isDayOfWeek);

            Console.WriteLine("Thanks!");
            Console.ReadLine();
    
        }

        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday, 
            Saturday,
            Sunday
        }


    }
}
