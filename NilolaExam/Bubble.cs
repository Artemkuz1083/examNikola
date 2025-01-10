using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilolaExam
{
    internal class Bubble
    {
        public static void BubbleSort(int[] str)
        {
            int current = 0;
            for (int i = 0; i < str.Length - 1; i++)
            {
                for(int j = 0; j < str.Length - 1; j++)
                {
                    if (str[j] > str[j+1])
                    {
                        current = str[j];
                        str[j] = str[j+1];
                        str[j+1] = current;
                    }                
                }
                Console.WriteLine(String.Join(" ", str));
            }
        }
    }
}
