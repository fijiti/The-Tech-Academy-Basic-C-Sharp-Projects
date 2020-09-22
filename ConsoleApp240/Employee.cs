using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp240
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            base.SayName();
        }
        public void Quit()
        {
            Console.WriteLine("You can quit if you want. But we don't want you too!");
        }

    }
}
