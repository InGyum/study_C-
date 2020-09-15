using Bogus;
using Microsoft.SqlServer.Server;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogusFakeTempHumidApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var Rooms = new[] { "DiningRoom", "LivingRoom", "BathRoom", "BedRoom" };

            var sensorFaker = new Faker<SensorInfo>()
                .RuleFor(s => s.Dev_Id, f => f.PickRandom(Rooms))
                .RuleFor(s => s.Curr_Time, f => f.Date.Past(0).ToString("yyyy-MM-dd HH:mm:ss.ff"))
                .RuleFor(s => s.Temp, f => float.Parse(f.Random.Float(20.0f, 35.9f).ToString("0.00")))
                .RuleFor(s => s.Humid, f => float.Parse(f.Random.Float(40.0f, 63.9f).ToString("0.0")))
                .RuleFor(s => s.Press, f => float.Parse(f.Random.Float(899.0f, 1005.9f).ToString("0.0")));

            var thisValue = sensorFaker.Generate(100);
            


            Console.WriteLine(JsonConvert.SerializeObject(thisValue, Formatting.Indented));

        }
    }
}
