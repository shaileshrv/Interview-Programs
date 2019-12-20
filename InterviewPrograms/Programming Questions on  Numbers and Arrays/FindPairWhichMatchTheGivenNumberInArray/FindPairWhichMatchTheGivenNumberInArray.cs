using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms
{
    public static partial class Utility
    {
        public static string[] FindPairWhichMatchTheGivenNumberInArray(int[] arr, int number)
        {
            List<string> pair = new List<string>();
            for (int index = 0; index < arr.Length; index++)
            {
                for (int index_j = index + 1; index_j < arr.Length - 1; index_j++)
                {
                    if ((arr[index] + arr[index_j]) == number)
                    {
                        pair.Add("{" + arr[index] + "," + arr[index_j] + "}");
                    }
                }
            }
            return GetUniqueFromList(pair.ToArray()).ToArray();
        }
    }
}
