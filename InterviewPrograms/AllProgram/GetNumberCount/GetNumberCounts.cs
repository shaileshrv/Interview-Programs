using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms
{
    public static partial class Utility
    {
        public static Dictionary<int, int> GetNumberCount(int[] arr)
        {
            Dictionary<int, int> numberCount = new Dictionary<int, int>();
            for (int index = 0; index < arr.Length; index++)
            {
                if (!numberCount.ContainsKey(arr[index]))
                {
                    numberCount.Add(arr[index], 0);
                }
                numberCount[arr[index]]++;
            }
            return numberCount;
        }
    }
}
