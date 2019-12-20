using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms
{
   public static partial class Utility
    {
        public static int Factorial(int number)
        {
            if (number == 1) { return number; }
            return number *= Factorial(number - 1);
        }
    }
}
