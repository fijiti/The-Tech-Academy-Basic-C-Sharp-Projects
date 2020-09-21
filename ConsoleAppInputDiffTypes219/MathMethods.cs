using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInputDiffTypes219
{
    class MathMethods
    {
       public int MathMethod(int number)
        {
            return number * number;
        }

        public int MathMethod(decimal number)
        {
            int numberRevised = Convert.ToInt32(number);
            return numberRevised + numberRevised;
            
        }

        public int MathMethod(string number)
        {
            int numberRevised = Convert.ToInt32(number);
            return numberRevised - numberRevised;
        }
    }
}
