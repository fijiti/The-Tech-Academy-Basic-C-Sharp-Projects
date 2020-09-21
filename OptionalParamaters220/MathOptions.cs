using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters220
{
    class MathOptions
    {
        public int AddOneOrTwo(int num1, int num2 = 0)
        {
            return num1 + num2;
        }

    }
}
