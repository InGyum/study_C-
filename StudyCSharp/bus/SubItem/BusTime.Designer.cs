namespace bus.SubItem
{
    partial class BusTime
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TxtSearch = new MetroFramework.Controls.MetroTextBox();
            this.Btn = new MetroFramework.Controls.MetroButton();
            this.SearchItem = new System.Windows.Forms.DataGridView();
            this.nodeNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.llineNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.min1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.station1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.min2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.station2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BntBack = new MetroFramework.Controls.MetroTile();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchItem)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(772, 464);
            this.metroTabControl1.TabIndex = 1;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.splitContainer1);
            this.metroTabPage1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 36);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(764, 424);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Station";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TxtSearch);
            this.splitContainer1.Panel1.Controls.Add(this.Btn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SearchItem);
            this.splitContainer1.Size = new System.Drawing.Size(764, 424);
            this.splitContainer1.SplitterDistance = 30;
            this.splitContainer1.TabIndex = 2;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(399, 4);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(241, 25);
            this.TxtSearch.TabIndex = 1;
            // 
            // Btn
            // 
            this.Btn.Location = new System.Drawing.Point(646, 3);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(99, 25);
            this.Btn.TabIndex = 0;
            this.Btn.Text = "검색";
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // SearchItem
            // 
            this.SearchItem.AllowUserToAddRows = false;
            this.SearchItem.AllowUserToDeleteRows = false;
            this.SearchItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nodeNm,
            this.llineNo,
            this.min1,
            this.station1,
            this.min2,
            this.station2});
            this.SearchItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchItem.Location = new System.Drawing.Point(0, 0);
            this.SearchItem.Name = "SearchItem";
            this.SearchItem.RowTemplate.Height = 23;
            this.SearchItem.Size = new System.Drawing.Size(764, 390);
            this.SearchItem.TabIndex = 0;
            // 
            // nodeNm
            // 
            this.nodeNm.HeaderText = "정류소명";
            this.nodeNm.Name = "nodeNm";
            this.nodeNm.Width = 75;
            // 
            // llineNo
            // 
            this.llineNo.HeaderText = "버스번호";
            this.llineNo.Name = "llineNo";
            this.llineNo.Width = 75;
            // 
            // min1
            // 
            this.min1.HeaderText = "1.버스 남은 도착시간";
            this.min1.Name = "min1";
            this.min1.Width = 140;
            // 
            // station1
            // 
            this.station1.HeaderText = "1.버스 남은 정류소 수";
            this.station1.Name = "station1";
            this.station1.Width = 145;
            // 
            // min2
            // 
            this.min2.HeaderText = "2.버스 남은 도착시간";
            this.min2.Name = "min2";
            this.min2.Width = 140;
            // 
            // station2
            // 
            this.station2.HeaderText = "2.버스 남은 정류소 수";
            this.station2.Name = "station2";
            this.station2.Width = 145;
            // 
            // BntBack
            // 
            this.BntBack.Location = new System.Drawing.Point(720, 526);
            this.BntBack.Name = "BntBack";
            this.BntBack.Size = new System.Drawing.Size(75, 69);
            this.BntBack.TabIndex = 0;
            this.BntBack.TileImage = global::bus.Properties.Resources.package;
            this.BntBack.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BntBack.UseTileImage = true;
            this.BntBack.Click += new System.EventHandler(this.BntBack_Click);
            // 
            // BusTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.BntBack);
            this.MaximizeBox = false;
            this.Name = "BusTime";
            this.Resizable = false;
            this.Text = "도착 정보";
            this.Load += new System.EventHandler(this.BusTime_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile BntBack;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroTextBox TxtSearch;
        private MetroFramework.Controls.MetroButton Btn;
        private System.Windows.Forms.DataGridView SearchItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nodeNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn llineNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn min1;
        private System.Windows.Forms.DataGridViewTextBoxColumn station1;
        private System.Windows.Forms.DataGridViewTextBoxColumn min2;
        private System.Windows.Forms.DataGridViewTextBoxColumn station2;
    }
}