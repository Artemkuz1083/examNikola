using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilolaExam
{
    internal class Cocktail
    {
        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public static void ShakerSort(int[] inArray)
        {
            for (int i = 0; i < inArray.Length / 2; i++)
            {
                bool swapFlag = false;

                Console.WriteLine("\nПроход направо\n");

                for (int j = i; j < inArray.Length - 1 - i; j++) 
                {
                    if (inArray[j] > inArray[j + 1])
                    {
                        Swap(inArray, j + 1, j) ;
                        swapFlag = true;
                        Console.WriteLine(String.Join(" ", inArray));
                    }                   
                }

                Console.WriteLine("\nПроход налево\n");

                for (int j = inArray.Length - 2 - i;  j > i; j--)
                {
                    if (inArray[j - 1] > inArray[j])
                    {
                        Swap(inArray, j - 1, j);
                        swapFlag = true;
                        Console.WriteLine(String.Join(" ", inArray));
                    }
                }

                if (!swapFlag)
                {
                    break;
                }
            }
        }
    }
}
