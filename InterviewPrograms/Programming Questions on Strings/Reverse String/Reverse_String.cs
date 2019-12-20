using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms
{
    public static partial class  Utility
    {
        public static string Reverse_String(string str)
        {
            string reverse = string.Empty;
            for (int i = str.Length-1; i >=0 ; i--)
            {
                reverse += str[i];
            }
            return reverse;
        }
    }
}
