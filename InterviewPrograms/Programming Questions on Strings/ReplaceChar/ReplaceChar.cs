using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms
{
    public static partial class Utility
    {
        public static string Replace(string str, char replaceChar, char replaceWith)
        {
            string temp_str = string.Empty;
            for (int index = 0; index < str.Length; index++)
            {
                if (replaceChar == str[index])
                {
                    temp_str += replaceWith;
                }
                else
                {
                    temp_str += str[index];
                }
            }
            return temp_str;
        }
    }
}
