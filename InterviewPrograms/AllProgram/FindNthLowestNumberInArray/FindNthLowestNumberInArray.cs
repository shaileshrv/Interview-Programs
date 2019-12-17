using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms
{
    public static partial class Utility
    {
        public static int FindNthLowestNumber(int[] arr, int positionNuber)
        {
            for (int index = 0; index < arr.Length; index++)
            {
                for (int index_j = 0; index_j < arr.Length; index_j++)
                {
                    if (arr[index] < arr[index_j])
                    {
                        int swap = arr[index];
                        arr[index] = arr[index_j];
                        arr[index_j] = swap;
                    }
                }
            }
            return arr[positionNuber - 1];
        }
    }
}
