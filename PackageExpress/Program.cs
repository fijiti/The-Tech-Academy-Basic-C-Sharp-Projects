using System;

namespace PackageExpress
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express");

            Console.WriteLine("Please enter the package weight:");
            int packageWeight = int.Parse(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {

                Console.WriteLine("Please enter the package width:");
                int packageWidth = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the package height:");
                int packageHeight = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");
                int packageLength = int.Parse(Console.ReadLine());

                int demensions = packageWidth + packageHeight + packageLength;
                if (demensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    
                } else
                {
                    int quote = ((packageLength * packageHeight * packageWidth) * packageWeight) / 100;
                    decimal dollarValue = Convert.ToDecimal(quote);
                    Console.WriteLine("Your estimated total for shipping this package is: " + dollarValue.ToString("C2"));
                    Console.WriteLine("Thank you!");
                    
                }

            }
            Console.ReadLine();
        }
    }
}
