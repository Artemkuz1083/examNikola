using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilolaExam
{
    internal class Selection
    {
        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public static void SelectionSort(int[] inArray)
        {
            for (int i = 0; i < inArray.Length; i++)
            {
                int max = inArray[0];
                int ind = 0;
                Console.WriteLine(String.Join(" ", inArray));
                for (int j = 0; j < inArray.Length - i; j++)
                {
                    if (inArray[j] > max)
                    {
                        max = inArray[j];
                        ind = j;
                    }
                }
                int lastIndex = inArray.Length - 1- i;
                Swap(inArray, lastIndex, ind);
            }
        }
    }
}
