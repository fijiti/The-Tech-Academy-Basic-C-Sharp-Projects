using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(5 + 2);
            Console.WriteLine(44 - 455);
            Console.WriteLine(55 * 4454);
            Console.WriteLine(55 / 33);

            string aName = "John";
            int aNum = 7;
            Console.WriteLine(aName + aNum);

            // Page 165
            string name = "jim";
            if (name == "jim"){
                Console.WriteLine("Hi Jim!");
            } else if (name == "joe") {
                Console.WriteLine("Hi Joe!");
            } else {
                Console.WriteLine("I don't know who you are.");
            }

            // Page 167
            name = "sam";
            if (name != "jim") {
                Console.WriteLine("Your not Jim!");
            } else {
                Console.WriteLine("Hi Jim!");
            }

            // Page 167
            int num1 = 10;
            int num2 = 12;
            if (num1 > num2 ) {
                Console.WriteLine("First number is greater than second number.");
            } else if (num1 < num2) {
                Console.WriteLine("Second number is greater than first number.");
            } else {
            
                Console.WriteLine("First and Second number are equal.");
            }

            // Page 175
            string result = num1 > num2 ? "num1 is greater than num2" : "num2 is greater than num1";
            Console.WriteLine(result);

            Console.ReadLine();


            
        }
    }
}
