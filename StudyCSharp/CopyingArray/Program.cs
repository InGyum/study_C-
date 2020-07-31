using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyingArray
{
    class Program
    {
        static void CopyArray<T>(T[] source, T[] target)
        {
            for (int i = 0; i < source.Length; i++)
                target[i] = source[i];
        }
        static void Main(string[] args)
        {
            int[] source = { 1, 3, 5, 7, 9 };
            int[] target = new int[source.Length];

            CopyArray(source, target);

            foreach (var item in target)
                Console.WriteLine(item);

            string[] source2 = { "일", "삼", "오", "칠", "구" };
            string[] target2 = new string[source2.Length];

            CopyArray(source2, target2);

            foreach (var item in target2)
                Console.WriteLine(item);
        }
    }
}
