using System;
using System.Text;

namespace StringFunctions
{
    class Program
    {
        static void Main()
        {
            // Step 184
            string name = "Jesse";

            string quote = "The man said, \"Hello\" Jessie. \nHello on a new line. \n\tHello on a tab.";
            Console.WriteLine($"quote: {quote}");

            string fileName = @"C:\Users\Jesse";
            Console.WriteLine($"fileName: {fileName}");

            bool trueOrFalse = name.Contains("s");
            Console.WriteLine($"Jesse Contains s: {trueOrFalse}");

            trueOrFalse = name.EndsWith("z");
            Console.WriteLine($"Jesse EndsWith z: {trueOrFalse}");

            int length = name.Length;
            Console.WriteLine($"Jesse name length: {name.Length}");

            Console.WriteLine($"Jesse name.ToUpper(): {name.ToUpper()}");
            Console.WriteLine($"Jesse name.ToLower(): {name.ToLower()}");

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jesse");
            Console.WriteLine($"StringBuilder sb.Append(): {sb}");

            Console.ReadLine();
        }
    }
}
