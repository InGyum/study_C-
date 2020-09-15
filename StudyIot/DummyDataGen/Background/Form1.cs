using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Background
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BgwTest.WorkerReportsProgress = true;
            BgwTest.WorkerSupportsCancellation = true;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (BgwTest.IsBusy != true)
            {
                BgwTest.RunWorkerAsync();
                LblResult.Text = "실행";
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (BgwTest.WorkerSupportsCancellation == true)
            {
                BgwTest.CancelAsync();
                LblResult.Text = "실행취소";
            }
        }

        private void BgwTest_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = (BackgroundWorker)sender;
            for (int i = 0; i < 10; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    Thread.Sleep(200);
                    worker.ReportProgress(i * 10);
                }
            }
        }

        private void BgwTest_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            LblResult.Text = $"{e.ProgressPercentage}%";
        }

        private void BgwTest_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                LblResult.Text = "Canceled!";
            }
            else if (e.Error != null)
            {
                LblResult.Text = "Error: " + e.Error.Message;
            }
            else
            {
                LblResult.Text = "Done!";
            }
        }

        
    }
}
