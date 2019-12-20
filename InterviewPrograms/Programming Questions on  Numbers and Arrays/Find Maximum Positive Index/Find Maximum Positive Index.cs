using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms
{
    public static partial class Utility
    {
        public static int Find_Maximum_Positive_Index(int[] arr)
        {
            int maxRangeSize = 0;
            int minIndex, maxIndex;
            for (int index = 0; index < arr.Length; index++)
            {
                minIndex = maxIndex = index;
                for (int index_j = index; index_j < arr.Length; index_j++)
                {
                    if (arr[index] < arr[index_j])
                    {
                        maxIndex = index_j;
                    }
                }
                if ((maxIndex - minIndex) + 1 > maxRangeSize)
                {
                    maxRangeSize = maxIndex - minIndex + 1;
                }
            }            
            return maxRangeSize;
        }
    }
}
