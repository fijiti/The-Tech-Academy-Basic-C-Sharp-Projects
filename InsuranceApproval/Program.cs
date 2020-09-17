using System;


namespace InsuranceApproval
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Basic Approval Program for Car Insurance");

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI (true or false)?");
            bool hadDUI = bool.Parse(Console.ReadLine());

            Console.WriteLine("How many speeding tickes do you have?");
            int numberOfTickets = int.Parse(Console.ReadLine());

            Console.WriteLine("Qualafied?");
            bool qualified;
            if (age > 15 && hadDUI == false && numberOfTickets <= 3 )
            {
                qualified = true;
            } else
            {
                qualified = false;
            }
            Console.WriteLine(qualified);
            
            Console.ReadLine();
           

        }
    }
}
