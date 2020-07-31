using System;

namespace NullableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            double? b = null;
            float? c = null;
            string s = null;


            Console.WriteLine(a.HasValue);
            if (a.HasValue)
            {
                Console.WriteLine(a.Value);
            }
            Console.WriteLine(b.HasValue);
            Console.WriteLine(c == null);
            Console.WriteLine(string.IsNullOrEmpty(s));
            Console.WriteLine(string.IsNullOrWhiteSpace(s));

            c = 3.141592F;
            if (c.HasValue)
            {
                Console.WriteLine($"c={c.Value}");
            }

        }
    }
}
