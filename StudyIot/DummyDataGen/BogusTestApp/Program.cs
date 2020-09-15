using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogusTestApp
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            var repostory = new SempleCustomerRepository();
            var customers = repostory.GetCustomers();
            Console.WriteLine(JsonConvert.SerializeObject(customers, Formatting.Indented));
        }
    }
}
