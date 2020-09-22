using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp245
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public int Id { get; set; }

        public static bool operator==(Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static bool operator!=(Employee employee1, Employee employee2)
        {
            if(employee1.Id != employee2.Id)
            {
                return true;
            } else
            {
                return false;
            }
            
        }
    }
}
