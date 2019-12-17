using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms
{
    public static partial class Utility
    {
        public static int[] GetDuplicateNumber(int[] arr)
        {
            List<int> duplicateNumber = new List<int>();
            foreach (var item in GetNumberCount(arr))
            {
                if (item.Value > 1)
                {
                    duplicateNumber.Add(item.Key);
                }
            }
            return duplicateNumber.ToArray();
        }
    }
}
