using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms
{
    public static partial class Utility
    {
        public static Tuple<int, int, int> Kadane_s_Algorithm(int[] arr)
        {
            int sum = arr[0];
            int startIndex = 0, endIndex = 0;
            int tempSum = sum;
            for (int index = 0; index < arr.Length - 1; index++)
            {
                startIndex = index;
                tempSum = 0;
                for (int index_j = 0; index_j < arr.Length; index_j++)
                {
                    tempSum += arr[index_j];
                    if (tempSum > sum)
                    {
                        sum = tempSum;
                        endIndex = index_j;
                    }
                }
            }
            return new Tuple<int, int, int>(sum, startIndex, endIndex);
        }
    }
}
