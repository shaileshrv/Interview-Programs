using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms
{
   public static partial class Utility
    {
        public static bool Prime_Number(int number)
        {
            bool isPrime = true; ;
            for (int i = 2; i < number; i++)
            {
                if (number % i != 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}
