using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms
{
    public static partial class Utility
    {
        public static string Fibonaci(int number)
        {
            int a = 0;
            int b = 1;
            string series = string.Empty;
            series = "0,1,";
            for (int index = 2; index < number; index++)
            {
                int sum = a + b;
                a = b;
                b = sum;
                series += sum + ",";
            }
            series = series.Trim(new char[] { ',' });
            return series;
        }
    }
}
