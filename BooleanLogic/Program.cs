using System;


namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine(true && false); // false
            //Console.WriteLine(true && true); // true
            //Console.WriteLine(false && false); // false

            //Console.WriteLine(true || true); // true 
            //Console.WriteLine(true || false); // true
            //Console.WriteLine(false || false); // false

            //Console.WriteLine(true == true); // true
            //Console.WriteLine(true == false); // false 
            //Console.WriteLine(false == false); // true

            //Console.WriteLine(true != true); // false
            //Console.WriteLine(true != false); // true 
            //Console.WriteLine(false != false); // false 

            // XOR operator below.  It is true when it is exclusively true because of OR not AND.
            //Console.WriteLine(true ^ true); // false 
            //Console.WriteLine(true ^ false); // true
            //Console.WriteLine(false ^ false); // false 

            // Multiple Ands and ORs allowed. 
            Console.WriteLine(true && true && true || false); // true 
            
            Console.ReadLine();
        }
    }
}
