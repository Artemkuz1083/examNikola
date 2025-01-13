using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilolaExam
{
    internal class TestClass
    {

        public static void Main()
        {
            var testArray = new[] {3,1,9,6,11,7};
            var testArray2 = new[] { 1,2,3,4,5,6,7,8,9 };
            //Console.WriteLine(Binary.BinarySearch(testArray2, 833));
            //Console.WriteLine(String.Join(" ",Tree.TreeSort(testArray)));
            AddresHashTable<int, int> table = new AddresHashTable<int, int>(5);
            table.Insert(0, 0);
            table.Insert(0, 1);
            table.Insert(1, 0);
            table.Insert(4, 1);       
            table.Print();

        
        }
    }
}
