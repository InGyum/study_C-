using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Timers;
using System.Windows;

namespace Exam
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    /// 
    

    public partial class MainWindow : Window
    {
        // MySQL
        SerialPort serial;
        private short xCount = 200;
        private short maxPhotoVal = 1023;
        List<Sensor> photoDatas = new List<Sensor>();

        string strConnString = "Server=localhost;Port=3306;" +
            "Database=iot_sensordata;Uid=root;Pwd=mysql_p@ssw0rd";

        public bool IsSimulation { get; set; }

        Timer timer = new Timer();
        Random rand = new Random();

        private void InsertDataToDB(Sensor data)
        {
            string strQuery = "INSERT INTO sensordatatbl " +
                " (Date, Value) " +
                " VALUES " +
                " (@Date, @Value) ";

            using (MySqlConnection conn = new MySqlConnection(strConnString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(strQuery, conn);
                MySqlParameter paramDate = new MySqlParameter("@Date", MySqlDbType.DateTime)
                {
                    Value = data.Date
                };
                cmd.Parameters.Add(paramDate);
                MySqlParameter paramValue = new MySqlParameter("@Value", MySqlDbType.Int32)
                {
                    Value = data.Value
                };
                cmd.Parameters.Add(paramValue);
                cmd.ExecuteNonQuery();
            }
        }

        // 연결시간
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            serial.Open();
            LblConnectionTime.Text = $"연결시간 : {DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}";
            BtnConnect.Enabled = false;
            BtnDisconnect.Enabled = true;
        }


        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var x = Enumerable.Range(0, 1000).Select(i => i / 10.0).ToArray();
            var y = x.Select(v => Math.Abs(v) < 1e-10 ? 1 : Math.Sign(v) / v).ToArray();

            linegraph.Plot(x, y);
        }
    }
}
