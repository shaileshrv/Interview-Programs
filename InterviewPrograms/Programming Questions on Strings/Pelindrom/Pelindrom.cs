using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms
{
    public static partial class Utility
    {
        public static bool Pelindrom(string str)
        {
            bool status = false;
            string temp_str = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                temp_str += str[i];
            }
            status = str == temp_str;
            return status;
        }

        public static string LongestPelindrom(string str)
        {
            string temp_str = string.Empty;
            string result = string.Empty;
            for (int index = 0; index < str.Length; index++)
            {
                temp_str = string.Empty;
                for (int index_j = index; index_j < str.Length; index_j++)
                {
                    temp_str += str[index_j];
                    var pel = Pelindrom(temp_str);
                    if (pel)
                    {
                        result = temp_str.Length > result.Length ? temp_str : result;
                    }
                }
            }
            return result;
        }
    }
}
