using System;

namespace Challenges
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine(5 + 2);
            //Console.WriteLine(44 - 455);
            //Console.WriteLine(55 * 4454);
            //Console.WriteLine(55 / 33);

            //string aName = "John";
            //int aNum = 7;
            //Console.WriteLine(aName + aNum);

            //// Page 165
            //string name = "jim";
            //if (name == "jim"){
            //    Console.WriteLine("Hi Jim!");
            //} else if (name == "joe") {
            //    Console.WriteLine("Hi Joe!");
            //} else {
            //    Console.WriteLine("I don't know who you are.");
            //}

            //// Page 167
            //name = "sam";
            //if (name != "jim") {
            //    Console.WriteLine("Your not Jim!");
            //} else {
            //    Console.WriteLine("Hi Jim!");
            //}

            //// Page 167
            //int num1 = 10;
            //int num2 = 12;
            //if (num1 > num2 ) {
            //    Console.WriteLine("First number is greater than second number.");
            //} else if (num1 < num2) {
            //    Console.WriteLine("Second number is greater than first number.");
            //} else {

            //    Console.WriteLine("First and Second number are equal.");
            //}

            //// Page 175
            //string result = num1 > num2 ? "num1 is greater than num2" : "num2 is greater than num1";
            //Console.WriteLine(result);

            // Switch statement Page 180
            Console.WriteLine("Choose a number of a month 1 - 12: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choice: ");
            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Wrong, not from 1 - 12!");
                    break;
            }
           
            Console.ReadLine();


            
        }
    }
}
