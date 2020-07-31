﻿namespace CharTestApp
{
    partial class ChartForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.BtnMultiChar = new MetroFramework.Controls.MetroButton();
            this.BtnDataBind = new MetroFramework.Controls.MetroButton();
            this.BtnXYValues = new MetroFramework.Controls.MetroButton();
            this.BtnYValues = new MetroFramework.Controls.MetroButton();
            this.BntDBBind = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(23, 63);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Score";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(713, 534);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.BntDBBind);
            this.metroPanel1.Controls.Add(this.BtnMultiChar);
            this.metroPanel1.Controls.Add(this.BtnDataBind);
            this.metroPanel1.Controls.Add(this.BtnXYValues);
            this.metroPanel1.Controls.Add(this.BtnYValues);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(742, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(415, 534);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // BtnMultiChar
            // 
            this.BtnMultiChar.Location = new System.Drawing.Point(248, 50);
            this.BtnMultiChar.Name = "BtnMultiChar";
            this.BtnMultiChar.Size = new System.Drawing.Size(164, 40);
            this.BtnMultiChar.TabIndex = 2;
            this.BtnMultiChar.Text = "MulitChar";
            this.BtnMultiChar.UseSelectable = true;
            this.BtnMultiChar.Click += new System.EventHandler(this.BtnMultiChar_Click);
            // 
            // BtnDataBind
            // 
            this.BtnDataBind.Location = new System.Drawing.Point(3, 50);
            this.BtnDataBind.Name = "BtnDataBind";
            this.BtnDataBind.Size = new System.Drawing.Size(164, 40);
            this.BtnDataBind.TabIndex = 2;
            this.BtnDataBind.Text = "Data Bind";
            this.BtnDataBind.UseSelectable = true;
            this.BtnDataBind.Click += new System.EventHandler(this.BtnDataBind_Click);
            // 
            // BtnXYValues
            // 
            this.BtnXYValues.Location = new System.Drawing.Point(248, 4);
            this.BtnXYValues.Name = "BtnXYValues";
            this.BtnXYValues.Size = new System.Drawing.Size(164, 40);
            this.BtnXYValues.TabIndex = 2;
            this.BtnXYValues.Text = "X Y Values";
            this.BtnXYValues.UseSelectable = true;
            this.BtnXYValues.Click += new System.EventHandler(this.BtnXYValues_Click);
            // 
            // BtnYValues
            // 
            this.BtnYValues.Location = new System.Drawing.Point(3, 4);
            this.BtnYValues.Name = "BtnYValues";
            this.BtnYValues.Size = new System.Drawing.Size(164, 40);
            this.BtnYValues.TabIndex = 2;
            this.BtnYValues.Text = "Only Y Values";
            this.BtnYValues.UseSelectable = true;
            this.BtnYValues.Click += new System.EventHandler(this.BtnYValues_Click);
            // 
            // BntDBBind
            // 
            this.BntDBBind.Location = new System.Drawing.Point(3, 96);
            this.BntDBBind.Name = "BntDBBind";
            this.BntDBBind.Size = new System.Drawing.Size(409, 79);
            this.BntDBBind.TabIndex = 2;
            this.BntDBBind.Text = "DataBase DB Bind";
            this.BntDBBind.UseSelectable = true;
            this.BntDBBind.Click += new System.EventHandler(this.BntDBBind_Click);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 620);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.chart1);
            this.Name = "ChartForm";
            this.Text = "Chart Test App";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton BtnXYValues;
        private MetroFramework.Controls.MetroButton BtnYValues;
        private MetroFramework.Controls.MetroButton BtnDataBind;
        private MetroFramework.Controls.MetroButton BtnMultiChar;
        private MetroFramework.Controls.MetroButton BntDBBind;
    }
}

