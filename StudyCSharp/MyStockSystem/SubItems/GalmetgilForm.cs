using MetroFramework.Forms;
using Newtonsoft.Json.Linq;
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

namespace MyStockSystem.SubItems
{
    public partial class GalmetgilForm : MetroForm  //Form
    {
        public GalmetgilForm()
        {
            InitializeComponent();
        }


        private void GalmetgilForm_Load(object sender, EventArgs e)
        {
            DgvSearchItem.Font = new Font(@"NanumGothic", 10, FontStyle.Regular);
        }


        private void MtlBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            MainForm Main = new MainForm();
            Main.Location = this.Location;
            Main.ShowDialog();
            this.Close();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DgvSearchItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTN_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient { Encoding = Encoding.UTF8 };

            StringBuilder str = new StringBuilder();
            str.Append("http://apis.data.go.kr/6260000/BusanGalmaetGilService/getGalmaetGilInfo"); // API 기본 URL
            str.Append("?serviceKey=mRbMNKDzb9tcAL3LiJUgErn3Migyn%2Bzb%2BzlDni%2BI0OYwfvVvHaVUSeaZNF3%2FviHxLQA8PAIn4GK99yW62s7yjg%3D%3D"); //인증키
            str.Append("&pageNo=1"); //페이지 수
            str.Append("&numOfRows=10"); //읽어올 데이터 수
            str.Append("&resultType=json"); //주식시장종류 : 11은 유가증권시장

            string json = wc.DownloadString(str.ToString());
            JObject obj = JObject.Parse(json);

            JArray items = JArray.Parse(obj.SelectToken("getGalmaetGilInfo.item").ToString());
            

            DgvSearchItem.Rows.Clear();

            foreach (var item in items)
            {
                DgvSearchItem.Rows.Add(
                    $"{item.SelectToken("kosNm")}",
                    $"{item.SelectToken("kosType")}",
                    $"{item.SelectToken("kosTxt")}",
                    $"{item.SelectToken("img")}",
                    $"{item.SelectToken("txt1")}",
                    $"{item.SelectToken("title")}",
                    $"{item.SelectToken("txt2")}"
                    );
            }
            
            DgvSearchItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void TxtSearchItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                BTN_Click(sender, new EventArgs());
            }
        }

        private void DgvSearchItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selvalue = DgvSearchItem.Rows[e.RowIndex].Cells[3].Value.ToString();
            // MessageBox.Show(selvalue);
            DownloadForm form = new DownloadForm();
            form.ParentUrl = selvalue;
            form.ShowDialog();
        }
    }
}
