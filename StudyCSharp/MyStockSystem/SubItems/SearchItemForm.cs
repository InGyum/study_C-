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

namespace MyStockSystem.SubItems
{
    public partial class SearchItemForm : MetroForm  //Form
    {
        public SearchItemForm()
        {
            InitializeComponent();
        }

        private void SearchItemForm_Load(object sender, EventArgs e)
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
            XmlDocument doc = new XmlDocument();

            StringBuilder str = new StringBuilder();
            str.Append("http://api.seibro.or.kr/openapi/service/StockSvc/getStkIsinByNmN1"); // API 기본 URL
            str.Append("?serviceKey=mRbMNKDzb9tcAL3LiJUgErn3Migyn%2Bzb%2BzlDni%2BI0OYwfvVvHaVUSeaZNF3%2FviHxLQA8PAIn4GK99yW62s7yjg%3D%3D"); //인증키
            str.Append($"&secnNm={TxtSearchItem.Text}"); //종목명
            str.Append("&pageNo=1"); //페이지 수
            str.Append("&numOfRows=200"); //읽어올 데이터 수
            str.Append("&martTpcd=11"); //주식시장종류 : 11은 유가증권시장

            string xml = wc.DownloadString(str.ToString());
            doc.LoadXml(xml);

            XmlElement root = doc.DocumentElement;
            XmlNodeList items = doc.GetElementsByTagName("item");

            DgvSearchItem.Rows.Clear();
            try
            {
                foreach (XmlNode item in items)
                {
                    DgvSearchItem.Rows.Add(item["isin"].InnerText,       //isin 표준코드
                                           item["issuDt"].InnerText,//item["issuDt"] == null ? string.Empty : item["issuDt"].InnerText,     // 주식 발행일자
                                           item["korSecnNm"].InnerText,  // 한글종목명
                                           item["secnKacdNm"].InnerText, // 보통주/우선주
                                           item["shotnIsin"].InnerText   // 단축코드
                                           );
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(this,$"에러발생 : {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
