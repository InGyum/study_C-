using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingGeneric
{
    class Mylist<T>
    {
        private T[] array;

        public Mylist()
        {
            array = new T[3];
        }
        public T this[int index]
        {
            get { return array[index]; }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
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
            Mylist<string> str_list = new Mylist<string>();
            str_list[0] = "abc";
            str_list[1] = "def";
            str_list[2] = "ghi";
            str_list[3] = "jkl";
            str_list[4] = "mno";

            for (int i = 0; i < str_list.Length; i++)
                Console.WriteLine(str_list[i]);
            Console.WriteLine();

            Mylist<float> float_list = new Mylist<float>();
            float_list[0] = 12.4f;
            float_list[1] = 3.14f;
            float_list[2] = 2.14f;
            float_list[3] = 5.12f;
            float_list[4] = 6.87f;

            for (int i = 0; i < float_list.Length; i++)
                Console.WriteLine(float_list[i]);
        }
    }
}
