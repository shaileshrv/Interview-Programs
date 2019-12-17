using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms
{
    public static partial class Utility
    {
        public static char[] UniqeChar(string str)
        {
            var charCount = GetCharCount(str);
            List<char> uniqeChar = new List<char>();
            foreach (var item in charCount)
            {
                if (item.Value == 1)
                {
                    uniqeChar.Add(item.Key);
                }
            }
            return uniqeChar.ToArray();
        }
    }
}
