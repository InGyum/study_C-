using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLambda
{
    class Program
    {
        //delegate int Calculate(int a, int b);
        delegate string Concatenate(string[] args);
        //static int Plus(int a, int b)
        //{
        //    return a + b;
        //}
        static void Main(string[] args)
        {
            #region
            //Calculate calc = new Calculate(Plus);
            //Console.WriteLine(calc(3, 4));

            //Calculate calc = (a, b) => a + b;

            //Console.WriteLine($"{3} + {4} : {calc(3, 4)}");
            #endregion
            Concatenate concat = (arr) =>
            {
                string result = "";
                foreach (var item in arr)
                    result += item;
                return result;
            };
            Console.WriteLine(concat(args));
        }
    }
}
