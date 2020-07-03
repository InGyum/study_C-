using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegralConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = sbyte.MaxValue;
            WriteLine($"a = {a}");

            int b = a;
            WriteLine($"b = {b}");

            int x = 128;
            WriteLine($"x = {x}");

            sbyte y = (sbyte)x;  // 오버플로우 발생!
            WriteLine($"y = {y}");
        }
    }
}
