using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilolaExam
{
    internal class Insert
    {
        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public static void InsertionSort(int[] inArray)
        {
            int current;
            int ind;
            for (int i = 1; i < inArray.Length; i++)
            {
                current = 0;
                ind = i;
                while (ind > 0 && inArray[ind - 1] > current)
                {
                    Swap(inArray, ind, ind - 1);
                    ind -= 1;
                    Console.WriteLine(String.Join(" ", inArray));
                }
                inArray[ind] = current;
            }
        }
    }
}
