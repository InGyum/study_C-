using Bogus;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;

namespace MQTT
{
    class Program
    {
        public static string MqttBrokerUrl { get; private set; }
        public static MqttClient Client { get; private set; }
        private static Thread MqttThread { get; set; }
        private static Faker<SensorInfo> SensorFaker { get; set; }
        private static string CurrValue { get; set; }

        static void Main(string[] args)
        {
            InitializeAll();
            ConnectMqttBroker();
            StartPublish();
        }

        private static void StartPublish()
        {
            MqttThread = new Thread(() => LoopPublish());
            MqttThread.Start();
        }

        private static void LoopPublish()
        {
            while (true)
            {
                SensorInfo ThisValue = SensorFaker.Generate();
                CurrValue = JsonConvert.SerializeObject(ThisValue, Formatting.Indented);
                Client.Publish("home/device/data/", Encoding.Default.GetBytes(CurrValue));
                Console.WriteLine($"Published : {CurrValue}");
                Thread.Sleep(1000);
            }
        }

        private static void ConnectMqttBroker()
        {
            Client = new MqttClient(MqttBrokerUrl);
            Client.Connect("FakerDaemon");
        }

        private static void InitializeAll()
        {
            MqttBrokerUrl = "localhost";

            var Rooms = new[] { "DiningRoom", "LivingRoom", "BathRoom", "BedRoom" };

            SensorFaker = new Faker<SensorInfo>()
                .RuleFor(s => s.Dev_Id, f => f.PickRandom(Rooms))
                .RuleFor(s => s.Curr_Time, f => f.Date.Past(0).ToString("yyyy-MM-dd HH:mm:ss.ff"))
                .RuleFor(s => s.Temp, f => float.Parse(f.Random.Float(20.0f, 35.9f).ToString("0.00")))
                .RuleFor(s => s.Humid, f => float.Parse(f.Random.Float(40.0f, 63.9f).ToString("0.0")))
                .RuleFor(s => s.Press, f => float.Parse(f.Random.Float(899.0f, 1005.9f).ToString("0.0")));
        }
    }
}
