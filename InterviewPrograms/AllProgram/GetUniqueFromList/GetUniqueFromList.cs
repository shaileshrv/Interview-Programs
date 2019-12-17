using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms
{
    public static partial class Utility
    {
        public static List<T> GetUniqueFromList<T>(T[] arr)
        {
            List<T> uniqe = new List<T>();
            for (int index = 0; index < arr.Length; index++)
            {
                if (!uniqe.Contains(arr[index]))
                {
                    uniqe.Add(arr[index]);
                }
            }
            return uniqe;
        }
    }
}
