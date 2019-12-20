using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms
{
    public static partial class Utility
    {
        public static List<string> Count_the_triplets(int[] arr)
        {
            List<string> list = new List<string>();
            for (int index = 0; index < arr.Length-1; index++)
            {
                for (int index_j = index + 1; index_j < arr.Length ; index_j++)
                {
                    if (arr.Contains(arr[index] + arr[index_j]))
                    {
                        list.Add("{" + arr[index] + "," + arr[index_j] + "}");
                    }
                }
            }
            return list;
        }
    }
}
