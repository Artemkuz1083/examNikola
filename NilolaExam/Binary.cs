using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilolaExam
{
    internal class Binary
    {
        public static int BinarySearch(int[] array, int SearchValue)
        {
            int min = 0;
            int max = array.Length - 1;
            while(min <= max)
            {
                int middle = (min + max) / 2;
                if (array[middle] == SearchValue)
                {
                    return middle;
                }
                if (array[middle] > SearchValue) 
                {
                    max = middle - 1;
                }
                if (array[middle] < SearchValue)
                {
                    min = middle + 1;
                }
            }

            return -1;
        }
    }
}
