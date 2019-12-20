using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms
{
    public static partial class Utility
    {
        public static Dictionary<char, int> GetCharCount(string str)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            for (int index = 0; index < str.Length; index++)
            {
                if (!charCount.ContainsKey(str[index]))
                {
                    charCount.Add(str[index], 0);
                }
                charCount[str[index]]++;
            }
            return charCount;
        }
    }
}
