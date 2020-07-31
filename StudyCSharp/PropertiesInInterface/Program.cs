using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesInInterface
{
    interface INamedValue
    {
        string Name { get; set; }
        string Value { get; set; }
        string GetOtherValue();
    }

    class NamedValue : INamedValue
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public string GetOtherValue()
        {
            return "Value";
        }
    }
    abstract class Product
    {
        private static int Serial = 0;
        public string SerialID
        {
            get { return String.Format($"{Serial++:d5}"); }
        }
        abstract public DateTime ProductDate { get; set; }
    }
    class MyProduct : Product
    {
        public override DateTime ProductDate { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NamedValue name = new NamedValue()
            { Name = "이름", Value = "김임겸" };
            NamedValue height = new NamedValue()
            { Name = "키", Value = "180Cm" };
            NamedValue weight = new NamedValue()
            { Name = "몸무게", Value = "65Kg" };

            Console.WriteLine($"{name.Name} : {name.Value}");
            Console.WriteLine($"{height.Name} : {height.Value}");
            Console.WriteLine($"{weight.Name} : {weight.Value}");
        }
    }
}
