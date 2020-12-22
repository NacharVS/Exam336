using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    class Factorial
    {
        static int factorial(int n)
        {

            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }

        }
        
    }
}
