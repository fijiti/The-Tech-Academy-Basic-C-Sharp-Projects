using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report.");

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Name: " + yourName);

            Console.WriteLine("What course are you on?");
            string courseYourOn = Console.ReadLine();
            Console.WriteLine("Course: " + courseYourOn);

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            if (int.TryParse(pageNumber, out int pageNum))
            {
                pageNum = Convert.ToInt32(pageNumber);
                Console.WriteLine("Page Number: " + pageNum);
            }
            else
            {
                Console.WriteLine("Please put a page number only.");
            }

            Console.WriteLine("Do you need help with anything?  Please answer \"true\" or \"false\".");
            string needsHelp = Console.ReadLine();
            if (needsHelp == "true" || needsHelp == "false")
            {
                bool needHelp = Convert.ToBoolean(needsHelp);
                Console.WriteLine("Need help: " + needHelp);
            }
            else
            {
                Console.WriteLine("You did not put in \"true\" or \"false\".");

            }

            Console.WriteLine("Were there any positive experiences you'd like to share?\nPlease give specifics.");
            string postiveExperiences = Console.ReadLine();
            Console.WriteLine("Positive Experiences: " + postiveExperiences);

            Console.WriteLine("Is there other feedback you'd like to provide?\nPlease be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("Feedback: " + feedback);

            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            if (int.TryParse(hoursStudied, out int timeStudied))
            {
                timeStudied = Convert.ToInt32(hoursStudied);
                Console.WriteLine("Hours Studied: " + timeStudied);
            }
            else
            {
                Console.WriteLine("Please put a value and round to the nearest hour.");
            }

            Console.WriteLine("Thank you for your answers.\nAn instructor will respond to this shortly.\nHave a great day!");

            Console.ReadLine();
        }
    }
}
