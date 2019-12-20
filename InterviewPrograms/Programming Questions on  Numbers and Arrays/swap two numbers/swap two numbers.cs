using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms
{
   public static partial class Utility
    {
        public static void swap_two_numbers()
        {
            int a = 13;
            int b = 26;
            a = a + b;
            b = a - b;
            a = a - b;
        }
    }
}
