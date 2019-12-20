using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms.AllProgram.GetMissingNumber
{
    class GetMissingNumbers
    {
        public static int[] GetMissingNumber(int[] arr1, int[] arr2)
        {
            List<int> duplicateNumber = new List<int>();
            for (int index = 0; index < arr2.Length; index++)
            {
                if (!arr1.Contains(arr2[index]))
                {
                    duplicateNumber.Add(arr2[index]);
                }
            }
            return duplicateNumber.ToArray();
        }
    }
}
