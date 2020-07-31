using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        abstract class AbstractBase
        {
            protected void ProtectedMethodA()
            {
                Console.WriteLine("AbstractBase.ProtectedMethodA()");
            }

            public void PublicMethodA()
            {
                Console.WriteLine("AbstractBase.PublicMethodA()");
            }
            public abstract void AbstractMethodA();
        }

        class Derived : AbstractBase
        {
            public override void AbstractMethodA()
            {
                Console.WriteLine("Derived.AbstractMethodA()");
                ProtectedMethodA();
            }
        }
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractMethodA();
            obj.PublicMethodA();
        }
    }
}
