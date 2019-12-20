using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms
{
  public static partial  class Utility
    {
        public static int sum_of_digits_of_a_number(int number)
        {
            if (number == 0)
            {
                return number;
            }
            int sum = 0;
            sum += number%10 + sum_of_digits_of_a_number(number / 10);
            return sum;
        }
    }
}
