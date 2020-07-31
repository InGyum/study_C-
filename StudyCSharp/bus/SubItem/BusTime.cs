using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace bus.SubItem
{
    public partial class BusTime : MetroForm
    {
        public BusTime()
        {
            InitializeComponent();
        }

        private void BusTime_Load(object sender, EventArgs e)
        {
            SearchItem.Font = new Font("NanumGothic", 8, FontStyle.Regular);
        }

        private void BntBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            MainForm Main = new MainForm();
            Main.Location = this.Location;
            Main.ShowDialog();
            this.Close();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient { Encoding = Encoding.UTF8 };
            XmlDocument doc = new XmlDocument();

            StringBuilder str = new StringBuilder();
            str.Append("http://61.43.246.153/openapi-data/service/busanBIMS2/stopArr"); // API 기본 URL
            str.Append("?serviceKey=mRbMNKDzb9tcAL3LiJUgErn3Migyn%2Bzb%2BzlDni%2BI0OYwfvVvHaVUSeaZNF3%2FviHxLQA8PAIn4GK99yW62s7yjg%3D%3D"); //인증키
            str.Append($"&bstopid={TxtSearch.Text}"); //정류소ID

            string xml = wc.DownloadString(str.ToString());
            doc.LoadXml(xml);

            XmlElement root = doc.DocumentElement;
            XmlNodeList items = doc.GetElementsByTagName("item");

            SearchItem.Rows.Clear();
            try
            {
                foreach (XmlNode item in items)
                {
                    SearchItem.Rows.Add(item["nodeNm"].InnerText,
                                        item["lineNo"].InnerText,       // 버스번호
                                        item["min1"].InnerText,     // 첫번째 버스 남은 도착시간
                                        item["station1"].InnerText,  // 첫번째 버스 남은 정류소 수
                                        item["min2"].InnerText,     // 두번째 버스 남은 도착시간
                                        item["station2"].InnerText  // 두번째 버스 남은 정류소 수
                                        );
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(this, $"에러발생 : {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SearchItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}
