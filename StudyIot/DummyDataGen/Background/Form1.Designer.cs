﻿namespace Background
{
    partial class Form1
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
            this.LblResult = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BgwTest = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(57, 58);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(57, 12);
            this.LblResult.TabIndex = 0;
            this.LblResult.Text = "LblResult";
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(20, 109);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(100, 55);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(162, 109);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 55);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BgwTest
            // 
            this.BgwTest.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwTest_DoWork);
            this.BgwTest.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgwTest_ProgressChanged);
            this.BgwTest.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgwTest_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 205);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LblResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnCancel;
        private System.ComponentModel.BackgroundWorker BgwTest;
    }
}

