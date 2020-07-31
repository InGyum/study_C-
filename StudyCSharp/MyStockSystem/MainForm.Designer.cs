namespace MyStockSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MtlStockAnals = new MetroFramework.Controls.MetroTile();
            this.MtlInvestSimul = new MetroFramework.Controls.MetroTile();
            this.MtlGalmetgilGuide = new MetroFramework.Controls.MetroTile();
            this.MtlSearchitem = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // MtlStockAnals
            // 
            this.MtlStockAnals.Location = new System.Drawing.Point(329, 63);
            this.MtlStockAnals.Name = "MtlStockAnals";
            this.MtlStockAnals.Size = new System.Drawing.Size(150, 150);
            this.MtlStockAnals.Style = MetroFramework.MetroColorStyle.Yellow;
            this.MtlStockAnals.TabIndex = 1;
            this.MtlStockAnals.Text = "주식정보분석";
            this.MtlStockAnals.TileImage = global::MyStockSystem.Properties.Resources.analysis2;
            this.MtlStockAnals.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlStockAnals.UseTileImage = true;
            // 
            // MtlInvestSimul
            // 
            this.MtlInvestSimul.Location = new System.Drawing.Point(329, 219);
            this.MtlInvestSimul.Name = "MtlInvestSimul";
            this.MtlInvestSimul.Size = new System.Drawing.Size(300, 150);
            this.MtlInvestSimul.Style = MetroFramework.MetroColorStyle.Red;
            this.MtlInvestSimul.TabIndex = 1;
            this.MtlInvestSimul.Text = "투자시뮬레이션";
            this.MtlInvestSimul.TileImage = global::MyStockSystem.Properties.Resources.simulator2;
            this.MtlInvestSimul.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlInvestSimul.UseTileImage = true;
            // 
            // MtlGalmetgilGuide
            // 
            this.MtlGalmetgilGuide.Location = new System.Drawing.Point(485, 63);
            this.MtlGalmetgilGuide.Name = "MtlGalmetgilGuide";
            this.MtlGalmetgilGuide.Size = new System.Drawing.Size(300, 150);
            this.MtlGalmetgilGuide.Style = MetroFramework.MetroColorStyle.Green;
            this.MtlGalmetgilGuide.TabIndex = 1;
            this.MtlGalmetgilGuide.Text = "갈맷길";
            this.MtlGalmetgilGuide.TileImage = global::MyStockSystem.Properties.Resources.seagull2;
            this.MtlGalmetgilGuide.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlGalmetgilGuide.UseTileImage = true;
            this.MtlGalmetgilGuide.Click += new System.EventHandler(this.MtlGalmetgilGuide_Click);
            // 
            // MtlSearchitem
            // 
            this.MtlSearchitem.Location = new System.Drawing.Point(23, 63);
            this.MtlSearchitem.Name = "MtlSearchitem";
            this.MtlSearchitem.Size = new System.Drawing.Size(300, 150);
            this.MtlSearchitem.TabIndex = 1;
            this.MtlSearchitem.Text = "주식정보검색";
            this.MtlSearchitem.TileImage = global::MyStockSystem.Properties.Resources.marketing2;
            this.MtlSearchitem.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlSearchitem.UseTileImage = true;
            this.MtlSearchitem.Click += new System.EventHandler(this.MtlSearchitem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.MtlStockAnals);
            this.Controls.Add(this.MtlInvestSimul);
            this.Controls.Add(this.MtlGalmetgilGuide);
            this.Controls.Add(this.MtlSearchitem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "주식분석시스템";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile MtlSearchitem;
        private MetroFramework.Controls.MetroTile MtlStockAnals;
        private MetroFramework.Controls.MetroTile MtlInvestSimul;
        private MetroFramework.Controls.MetroTile MtlGalmetgilGuide;
    }
}

