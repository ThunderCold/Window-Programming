namespace Practice7_2
{
    partial class Form2
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
            this.lblEn = new System.Windows.Forms.Label();
            this.lblMark = new System.Windows.Forms.Label();
            this.chkboxMark = new System.Windows.Forms.CheckBox();
            this.lblZh = new System.Windows.Forms.Label();
            this.lblAttr = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEn
            // 
            this.lblEn.AutoSize = true;
            this.lblEn.Location = new System.Drawing.Point(57, 60);
            this.lblEn.Name = "lblEn";
            this.lblEn.Size = new System.Drawing.Size(61, 23);
            this.lblEn.TabIndex = 0;
            this.lblEn.Text = "label1";
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Location = new System.Drawing.Point(532, 146);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(46, 23);
            this.lblMark.TabIndex = 1;
            this.lblMark.Text = "標記";
            // 
            // chkboxMark
            // 
            this.chkboxMark.AutoSize = true;
            this.chkboxMark.Location = new System.Drawing.Point(480, 150);
            this.chkboxMark.Name = "chkboxMark";
            this.chkboxMark.Size = new System.Drawing.Size(18, 17);
            this.chkboxMark.TabIndex = 2;
            this.chkboxMark.UseVisualStyleBackColor = true;
            // 
            // lblZh
            // 
            this.lblZh.AutoSize = true;
            this.lblZh.Location = new System.Drawing.Point(57, 134);
            this.lblZh.Name = "lblZh";
            this.lblZh.Size = new System.Drawing.Size(61, 23);
            this.lblZh.TabIndex = 3;
            this.lblZh.Text = "label1";
            // 
            // lblAttr
            // 
            this.lblAttr.AutoSize = true;
            this.lblAttr.Location = new System.Drawing.Point(88, 218);
            this.lblAttr.Name = "lblAttr";
            this.lblAttr.Size = new System.Drawing.Size(61, 23);
            this.lblAttr.TabIndex = 4;
            this.lblAttr.Text = "label2";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(492, 209);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 32);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "查看";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(492, 263);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 32);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "下一個";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 353);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lblAttr);
            this.Controls.Add(this.lblZh);
            this.Controls.Add(this.chkboxMark);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.lblEn);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "單字測驗";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEn;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.CheckBox chkboxMark;
        private System.Windows.Forms.Label lblZh;
        private System.Windows.Forms.Label lblAttr;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnNext;
    }
}