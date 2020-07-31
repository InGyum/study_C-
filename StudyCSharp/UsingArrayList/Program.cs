using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                int iresult = list.Add(i); // 리스트 맨마지막 추가
                Console.WriteLine($"{iresult}번째에 데이터 {i}추가 완료");
            }
            foreach (var item in list)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();

            list.RemoveAt(2); // 인덱스 위치값 제거
            foreach (var item in list)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();

            list.Insert(5,4.5); // 인덱스 위치값 추가
            foreach (var item in list)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();

            list.Clear(); //초기화
            foreach (var item in list)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
    }
}
