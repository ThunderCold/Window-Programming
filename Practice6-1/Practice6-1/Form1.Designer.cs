namespace Practice6_1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.trkbarVis = new System.Windows.Forms.TrackBar();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblStep = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblNoshow = new System.Windows.Forms.Label();
            this.lblShow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkbarVis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(143, 300);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(125, 35);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "繪製拼圖板";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(507, 321);
            this.btnChoose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(103, 35);
            this.btnChoose.TabIndex = 1;
            this.btnChoose.Text = "選擇圖片";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // trkbarVis
            // 
            this.trkbarVis.Location = new System.Drawing.Point(687, 411);
            this.trkbarVis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trkbarVis.Maximum = 1;
            this.trkbarVis.Name = "trkbarVis";
            this.trkbarVis.Size = new System.Drawing.Size(166, 56);
            this.trkbarVis.TabIndex = 2;
            this.trkbarVis.Value = 1;
            this.trkbarVis.Scroll += new System.EventHandler(this.trkbarVis_Scroll);
            // 
            // picbox
            // 
            this.picbox.Location = new System.Drawing.Point(618, 35);
            this.picbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(376, 357);
            this.picbox.TabIndex = 3;
            this.picbox.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(442, 166);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(140, 23);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "label1";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStep
            // 
            this.lblStep.Location = new System.Drawing.Point(442, 233);
            this.lblStep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(146, 23);
            this.lblStep.TabIndex = 5;
            this.lblStep.Text = "label2";
            this.lblStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblNoshow
            // 
            this.lblNoshow.AutoSize = true;
            this.lblNoshow.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNoshow.Location = new System.Drawing.Point(568, 431);
            this.lblNoshow.Name = "lblNoshow";
            this.lblNoshow.Size = new System.Drawing.Size(61, 22);
            this.lblNoshow.TabIndex = 6;
            this.lblNoshow.Text = "不顯示";
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblShow.Location = new System.Drawing.Point(1002, 438);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(44, 22);
            this.lblShow.TabIndex = 7;
            this.lblShow.Text = "顯示";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 690);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.lblNoshow);
            this.Controls.Add(this.lblStep);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.trkbarVis);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkbarVis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.TrackBar trkbarVis;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblNoshow;
        private System.Windows.Forms.Label lblShow;
    }
}

