using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingHashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["이름"] = "김인겸";
            ht["주소"] = "부산광역시 사상구";
            ht["전화번호"] = "010-8736-9192";
            ht["나이"] = 29;
            ht["키"] = 180.0;
            ht["결혼여부"] = false;

            Console.WriteLine(ht["이름"]);
            Console.WriteLine(ht["주소"]);
            Console.WriteLine(ht["전화번호"]);
            Console.WriteLine(ht["나이"]);
            Console.WriteLine(ht["키"]);
            Console.WriteLine(ht["결혼여부"]);


        }
    }
}
