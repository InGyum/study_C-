using System;
using System.IO;


namespace Interface
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger:ILogger
    {
        public void WriteLog(string message)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine($"[{now.ToLocalTime()}] {message}"); // 터미널 입력
        }
    }
    class FileLogger : ILogger
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }
        public void WriteLog(string message)
        {
            DateTime now = DateTime.Now;
            writer.WriteLine($"[{now.ToLocalTime()}] {message}");  //메모장 입력
        }
    }

    class ClimateMonitor
    {
        private ILogger logger;
        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }
        public void start()
        {
            while (true)
            {
                Console.Write( "온도를 입력해주세요 : ") ;
                string temperature = Console.ReadLine();
                if (temperature == "q")
                    break;

                logger.WriteLog( "현재 온도 : " + temperature );
                
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClimateMonitor monitor = new ClimateMonitor(new FileLogger("MyLog.txt"));
            //ClimateMonitor monitor = new ClimateMonitor(new ConsoleLogger());  // 콘솔창 입력 < - > 출력

            monitor.start();
        }
    }
}
