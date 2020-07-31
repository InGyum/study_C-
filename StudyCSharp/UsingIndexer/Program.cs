using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingIndexer
{
    class Mylist
    {
        private int[] array;
        public Mylist()
        {
            array = new int[3];
        }
        public int this[int index]
        {
            get { return array[index];}
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }
                array[index] = value;
            }
        }

        public int Length
        {
            get { return array.Length; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mylist list = new Mylist();
            for (int i = 0; i < 5; i++)
                list[i] = i;
            for (int i = 0; i < list.Length; i++)
                Console.WriteLine(list[i]);            
        }
    }
}
