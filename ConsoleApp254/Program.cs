using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp254
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isDayOfWeek = false;
           
            try
            {
                Console.WriteLine("Please enter a day of the week capitalized:");
                string day = Console.ReadLine();
                DaysOfWeek aDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), day, true);
                Console.WriteLine(day);
               
 
            }
            catch (Exception)
            {

                Console.WriteLine("That is not one of the days of the week.");
            }
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
