using bus.SubItem;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bus
{
    public partial class MainForm : MetroForm//Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Location = new Point(
                Screen.PrimaryScreen.Bounds.Width / 2 - this.Size.Width / 2,
                Screen.PrimaryScreen.Bounds.Height / 2 - this.Size.Height / 2
            );
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //DgvSearchItem.Font = new Font(@"NanumGothic", 10, FontStyle.Regular);

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            BusTime searchItem = new BusTime();
            searchItem.Location = this.Location;
            searchItem.ShowDialog();

            this.Close();
        }
    }
}
