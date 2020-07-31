using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingBasicThread
{
    class Program
    {
        static void DoSomething()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(1000);
            }
        }
        static void Do()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Do : {i}");
                Thread.Sleep(300);
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(DoSomething));
            Thread t2 = new Thread(new ThreadStart(Do));
            Console.WriteLine("Starting thread...");
            t1.Start(); //스레드 시작 (DoSomething 호출)
            t2.Start();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Main : {i}");
                Thread.Sleep(500);
            }

            Console.WriteLine("Wating until thread stops...");
            t1.Join();
            t2.Join();

            Console.WriteLine("Finished");
        }
    }
}
