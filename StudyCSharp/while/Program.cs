using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        { var i = 0;
            
                //Console.WriteLine($"{i--}");
                List<string> strings = new List<string>();
                strings.Add("Hello");
                strings.Add("Bye");
                strings.Add("Hey~");
                List<string> subs = new List<string> { "Banana", "Strawberry" };
                strings.AddRange(subs);
                foreach (var item in strings)
                {
                    Console.WriteLine($"{++i} 번째 item : {item}");
                }
            
        }
    }
}
