using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp303
{
    public class Employee
    {
        // Chained Constructor
        public Employee(string firstName, string lastName) : this(firstName, lastName, 10.00m)
        {
        }
        // Constructor 
        public Employee(string firstName, string lastName, decimal hourlyPay)
        {
            FirstName = firstName;
            LastName = lastName;
            HourlyPay = hourlyPay;

        }
      
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal HourlyPay { get; set; }

    }
}
