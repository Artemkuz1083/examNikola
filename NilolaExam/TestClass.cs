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
            //var testArray = new[] {3,1,9,8,11,6};
            //Console.WriteLine(String.Join(" ",Shell.ShellSort(testArray)));
            var table = new ChainHashTable<int, int>(5);
            table.Insert(0, 1);
            table.Insert(0, 1);
            table.Insert(0, 2);
            table.Insert(3, 3);
            table.Print();
        }
    }
}
