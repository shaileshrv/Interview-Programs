using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms
{
   public static partial class Utility
    {
        public static bool Armstrong(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                var reminder = number % 10;
                number /= 10;
                sum += (reminder * reminder * reminder);
            }
            return sum == number; ;
        }
    }
}
