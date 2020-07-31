using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingGenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            //for (int i = 0; i < 5; i++)
            //    list.Add(i);

            //foreach (var item in list)
            //    Console.Write($"{item}");
            //Console.WriteLine();

            //list.RemoveAt(2);
            //foreach (var item in list)
            //    Console.Write($"{item}");
            //Console.WriteLine();

            //list.Insert(2, 2);

            //foreach (var item in list)
            //    Console.Write($"{item}");
            //Console.WriteLine();

            Queue<double> queue = new Queue<double>();

            queue.Enqueue(1.1);
            queue.Enqueue(2.2);
            queue.Enqueue(3.3);
            queue.Enqueue(4.4);
            queue.Enqueue(5.5);
            queue.Enqueue(6.6);

            while (queue.Count > 0)
                Console.WriteLine(queue.Dequeue());
        }
    }
}
