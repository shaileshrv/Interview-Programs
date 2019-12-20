using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms
{
    public static partial class Utility
    {
        public static Tuple<int,int> Subarray_with_given_sum(int[] arr, int sum)
        {
            int startIndex=-1, endIndex=-1;
            bool flagFind = false;
            for (int index = 0; index < arr.Length; index++)
            {
                int tempSum = 0;
                startIndex = index;
                for (int index_j = index; index_j < arr.Length; index_j++)
                {
                    tempSum += arr[index_j];
                    if (tempSum == sum)
                    {
                        endIndex = index_j;
                        flagFind = true;
                        break;
                    }
                    else if (tempSum > sum)
                    {
                        break;
                    }                    
                }
                if (flagFind) break;
            }
            return new Tuple<int, int>(startIndex, endIndex);
        }
    }
}
