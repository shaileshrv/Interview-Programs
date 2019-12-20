using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms
{
   public static partial class Utility
    {
        public static int Reverse_number(int number)
        {
            int rev = 0;
            while (number>0)
            {
                int lastDigit = number % 10;
                rev =(rev* 10) + lastDigit;
                number /= 10;
            }
            return rev;
        }
    
        public static bool Palindromic_number(int number)
        {
            return number == Reverse_number(number);
        }
    }
}
