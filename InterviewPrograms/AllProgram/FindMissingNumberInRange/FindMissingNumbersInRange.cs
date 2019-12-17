using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms
{
    public static partial class Utility
    {
        public static int[] FindMissingNumberInRange(int start, int end, int[] arr)
        {
            List<int> missingNumber = new List<int>();
            for (int i = start; i < end; i++)
            {
                if (!arr.Contains(i))
                {
                    missingNumber.Add(i);
                }
            }
            return missingNumber.ToArray();
        }
    }
}
