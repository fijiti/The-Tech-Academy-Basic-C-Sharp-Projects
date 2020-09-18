using System;
using System.Text;

namespace ConsoleAppStrings186
{
    class Program
    {
        static void Main()
        {
            // 1) Concatenates three strings.
            Console.WriteLine("Let's concatenate three strings:");
            Console.WriteLine("Enter one string:");
            string string1 = Console.ReadLine();
            Console.WriteLine("Enter another string:");
            string string2 = Console.ReadLine();
            Console.WriteLine("Enter one more string");
            string string3 = Console.ReadLine();

            string allStrings = string1 + string2 + string3;
            Console.WriteLine("Below are your three strings concatenated:");
            Console.WriteLine(allStrings);

            // 2) Converts a string to uppercase
            Console.WriteLine("\nInput a string and we will convert it to upper case:");
            string aString = Console.ReadLine();
            Console.WriteLine(aString.ToUpper());

            // 3) Creates a StringBuilder and builds a paragraph of text one sentence at a time. 
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("\nLet's write paragraph 1 sentence at a time to 3 sentences:");
            int i = 0;
            do
            {
                Console.WriteLine("Enter sentence:");
                sb.Append(Console.ReadLine()+" ");
                i++;

            } while (i < 3);
            Console.WriteLine("Here is your paragraph:");
            Console.WriteLine(sb.ToString());



            Console.ReadLine();
        }
    }
}
