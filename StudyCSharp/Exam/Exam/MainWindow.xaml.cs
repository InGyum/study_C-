using LiveCharts;
using MahApps.Metro.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Threading;

namespace Exam
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    /// 
    public class SensorData
    {
        public DateTime Date { get; set; }
        public ushort Value { get; set; }

        public SensorData(DateTime date, ushort value)
        {
            Date = date;
            Value = value;
        }
    }


    public partial class MainWindow : Window
    {
        // MySQL
        SerialPort serial;
        private short xCount = 200;
        private short maxPhotoVal = 1023;
        List<Sensor> photoDatas = new List<Sensor>();
        Application app;


        string strConnString = "Server=localhost;Port=3306;" +
            "Database=iot_sensordata;Uid=root;Pwd=mysql_p@ssw0rd";

        public bool IsSimulation { get; set; }

        DispatcherTimer timer = new DispatcherTimer();
        Random rand = new Random();
        public MainWindow()
        {
            InitializeComponent();
            InitControls();
            InitializeChartData();
        }
        public ChartValues<int> LineValues { get; set; }

        private void InitializeChartData()
        {
            LineValues = new ChartValues<int> { };
            DataContext = this;
        }

        public void InitControls()
        {
            foreach (var item in SerialPort.GetPortNames())
            {
                CboSerialPort.Items.Add(item);
            }
            CboSerialPort.Text = "Select Port";

            PgbPhotoRegistor.Minimum = 0;
            PgbPhotoRegistor.Maximum = maxPhotoVal;

            BtnConnect.IsEnabled = BtnDisconnect.IsEnabled = false;

        }

        public void CboSerialPort_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var portName = CboSerialPort.SelectedItem.ToString();
            serial = new SerialPort(portName);
            serial.DataReceived += Serial_DataReceived;

            BtnConnect.IsEnabled = true;
        }

        public void Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string sVal = serial.ReadLine();
            this.BeginInvoke(new Action(delegate { DisplayValue(sVal); }));
        }

        public void DisplayValue(string sVal)
        {
            try
            {
                ushort v = ushort.Parse(sVal);
                if (v < 0 || v > maxPhotoVal)
                    return;

                SensorData data = new SensorData(DateTime.Now, v);
                //InsertDataToDB(data);

                TxtSensorCount.Text = photoDatas.Count.ToString();
                PgbPhotoRegistor.Value = v;
                LblPhotoRegistor.Content = v.ToString();

                string item = $"{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}\t{v}";
                LineValues.Add((int)v);
                RtbLog.AppendText($"{item}\n");
                RtbLog.ScrollToEnd();

               
            }
            catch (Exception ex)
            {
                RtbLog.AppendText($"Error : {ex.Message}\n");
                RtbLog.ScrollToEnd();
            }
        }

        public void InsertDataToDB(SensorData data)
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
        public void BtnConnect_Click(object sender, EventArgs e)
        {
            //serial.Open();
            LblConnectionTime.Text = $"연결시간 : {DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}";
            BtnConnect.IsEnabled = false;
            BtnDisconnect.IsEnabled = true;
        }

        public void BtnDisconnect_Click(object sender, EventArgs e)
        {
            //serial.Close();
            BtnConnect.IsEnabled = true;
            BtnDisconnect.IsEnabled = false;
        }

       

        public void MenuSubItemExit_Click(object sender, EventArgs e)
        {
            app.Shutdown();
        }


        public void MenuSubItemStart_Click(object sender, EventArgs e)
        {
            IsSimulation = true;
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();

            // serial통신 끊기
            BtnDisconnect_Click(sender, e);
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            ushort value = (ushort)rand.Next(1, 1024);
            DisplayValue(value.ToString());
        }

        public void MenuSubItemStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            IsSimulation = false;

            // serial 통신 재시작
            BtnConnect_Click(sender, e);
        }

        private void MenuSubItemInfo_Click(object sender, EventArgs e)
        {
            ThisProgramForm form = new ThisProgramForm();
            form.ShowDialog();
        }

        
    }
}
