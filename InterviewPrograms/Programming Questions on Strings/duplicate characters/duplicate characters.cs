using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms
{
    public static partial class Utility
    {
        public static char[] duplicate_characters(string str)
        {
            var charCount = GetCharCount(str);
            var duplicateChar = new List<char>();
            foreach (var item in charCount)
            {
                if (item.Value > 1)
                {
                    duplicateChar.Add(item.Key);
                }
            }
            return duplicateChar.ToArray();
        }
    }
}
