using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Property
{
    class BirthdayInfo
    {
        public string Name { get; set; } = "Unknown";
        public DateTime Birthday { get; set; } = new DateTime(1900, 1, 1);
        public int Age
        {
            get { return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo origin = new BirthdayInfo();
            Console.WriteLine($"Name : {origin.Name}");
            Console.WriteLine($"Birthday : {origin.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {origin.Age}");
            BirthdayInfo birth = new BirthdayInfo
            {
                Name = "서현",
                Birthday = new DateTime(1991, 6, 28)
            };
            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");

            var myIns = new { Name = "김인겸", Home = "부산" };
            Console.WriteLine($"{myIns.Name} / {myIns.Home}");

            var b = new { Subject = "수학", Scores = new int[] { 99, 88, 77 } };
            Console.WriteLine($"{b.Subject}");
            foreach (var item in b.Scores)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
