using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms
{
    public static partial class Utility
    {
        public static bool Anagram(string str1, string str2)
        {
            bool status = true;
            var getCharCount1 = GetCharCount(str1);
            var getCharCount2 = GetCharCount(str2);
            foreach (var item in getCharCount2)
            {
                if (!(getCharCount1.ContainsKey(item.Key) && getCharCount1[item.Key] >= getCharCount2[item.Key]))
                {
                    status = false;
                    break;
                }
            }
            return status;
        }
    }
}
