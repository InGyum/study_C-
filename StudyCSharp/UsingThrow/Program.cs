using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingThrow
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DoSomthing(1);
                DoSomthing(3);
                DoSomthing(5);
                DoSomthing(7);
                DoSomthing(9);
                DoSomthing(11);
                DoSomthing(13);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
                Console.WriteLine($"도움말 링크 : {ex.HelpLink}");
                Console.WriteLine($"소스 : {ex.Source}");
            }
            finally
            {
                Console.WriteLine("에러가 무시 수행");
            }
        }

        private static void DoSomthing(int arg)
        {
            if (arg < 10)
            {
                Console.WriteLine($"arg : {arg}");
            }
            else
                throw new Exception("arg가 10보다 큽니다.")
                {
                    HelpLink = "http://www.google.com",
                    Source = "UsingThrow line 34"
                };
        }
    }
}
