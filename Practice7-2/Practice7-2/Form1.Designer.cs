﻿namespace Practice7_2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟舊檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.儲存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存新檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.離開ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增單字ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.搜尋單字ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.單字測驗ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.檢視ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字型大小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.只顯示標記單字ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除標記ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.lblWord = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.chkbox1 = new System.Windows.Forms.CheckBox();
            this.chkbox2 = new System.Windows.Forms.CheckBox();
            this.chkbox3 = new System.Windows.Forms.CheckBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.combobox3 = new System.Windows.Forms.ComboBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.功能ToolStripMenuItem,
            this.檢視ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.開啟舊檔ToolStripMenuItem,
            this.儲存ToolStripMenuItem,
            this.另存新檔ToolStripMenuItem,
            this.離開ToolStripMenuItem});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.新增ToolStripMenuItem.Text = "新增";
            this.新增ToolStripMenuItem.Click += new System.EventHandler(this.新增ToolStripMenuItem_Click);
            // 
            // 開啟舊檔ToolStripMenuItem
            // 
            this.開啟舊檔ToolStripMenuItem.Name = "開啟舊檔ToolStripMenuItem";
            this.開啟舊檔ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.開啟舊檔ToolStripMenuItem.Text = "開啟舊檔";
            this.開啟舊檔ToolStripMenuItem.Click += new System.EventHandler(this.開啟舊檔ToolStripMenuItem_Click);
            // 
            // 儲存ToolStripMenuItem
            // 
            this.儲存ToolStripMenuItem.Name = "儲存ToolStripMenuItem";
            this.儲存ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.儲存ToolStripMenuItem.Text = "儲存";
            this.儲存ToolStripMenuItem.Click += new System.EventHandler(this.儲存ToolStripMenuItem_Click);
            // 
            // 另存新檔ToolStripMenuItem
            // 
            this.另存新檔ToolStripMenuItem.Name = "另存新檔ToolStripMenuItem";
            this.另存新檔ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.另存新檔ToolStripMenuItem.Text = "另存新檔";
            this.另存新檔ToolStripMenuItem.Click += new System.EventHandler(this.另存新檔ToolStripMenuItem_Click);
            // 
            // 離開ToolStripMenuItem
            // 
            this.離開ToolStripMenuItem.Name = "離開ToolStripMenuItem";
            this.離開ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.離開ToolStripMenuItem.Text = "離開";
            this.離開ToolStripMenuItem.Click += new System.EventHandler(this.離開ToolStripMenuItem_Click);
            // 
            // 功能ToolStripMenuItem
            // 
            this.功能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增單字ToolStripMenuItem,
            this.搜尋單字ToolStripMenuItem,
            this.單字測驗ToolStripMenuItem});
            this.功能ToolStripMenuItem.Name = "功能ToolStripMenuItem";
            this.功能ToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.功能ToolStripMenuItem.Text = "功能";
            // 
            // 新增單字ToolStripMenuItem
            // 
            this.新增單字ToolStripMenuItem.Name = "新增單字ToolStripMenuItem";
            this.新增單字ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.新增單字ToolStripMenuItem.Text = "新增單字";
            this.新增單字ToolStripMenuItem.Click += new System.EventHandler(this.新增單字ToolStripMenuItem_Click);
            // 
            // 搜尋單字ToolStripMenuItem
            // 
            this.搜尋單字ToolStripMenuItem.Name = "搜尋單字ToolStripMenuItem";
            this.搜尋單字ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.搜尋單字ToolStripMenuItem.Text = "搜尋單字";
            this.搜尋單字ToolStripMenuItem.Click += new System.EventHandler(this.搜尋單字ToolStripMenuItem_Click);
            // 
            // 單字測驗ToolStripMenuItem
            // 
            this.單字測驗ToolStripMenuItem.Name = "單字測驗ToolStripMenuItem";
            this.單字測驗ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.單字測驗ToolStripMenuItem.Text = "單字測驗";
            this.單字測驗ToolStripMenuItem.Click += new System.EventHandler(this.單字測驗ToolStripMenuItem_Click);
            // 
            // 檢視ToolStripMenuItem
            // 
            this.檢視ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.字型大小ToolStripMenuItem,
            this.只顯示標記單字ToolStripMenuItem,
            this.清除標記ToolStripMenuItem});
            this.檢視ToolStripMenuItem.Name = "檢視ToolStripMenuItem";
            this.檢視ToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.檢視ToolStripMenuItem.Text = "檢視";
            // 
            // 字型大小ToolStripMenuItem
            // 
            this.字型大小ToolStripMenuItem.Name = "字型大小ToolStripMenuItem";
            this.字型大小ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.字型大小ToolStripMenuItem.Text = "字型大小";
            this.字型大小ToolStripMenuItem.Click += new System.EventHandler(this.字型大小ToolStripMenuItem_Click);
            // 
            // 只顯示標記單字ToolStripMenuItem
            // 
            this.只顯示標記單字ToolStripMenuItem.Name = "只顯示標記單字ToolStripMenuItem";
            this.只顯示標記單字ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.只顯示標記單字ToolStripMenuItem.Text = "只顯示標記單字";
            this.只顯示標記單字ToolStripMenuItem.Click += new System.EventHandler(this.只顯示標記單字ToolStripMenuItem_Click);
            // 
            // 清除標記ToolStripMenuItem
            // 
            this.清除標記ToolStripMenuItem.Name = "清除標記ToolStripMenuItem";
            this.清除標記ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.清除標記ToolStripMenuItem.Text = "清除標記";
            this.清除標記ToolStripMenuItem.Click += new System.EventHandler(this.清除標記ToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(13, 39);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(61, 23);
            this.lblWord.TabIndex = 1;
            this.lblWord.Text = "label1";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(509, 93);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(46, 23);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "單字";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(513, 180);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(46, 23);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "中文";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(513, 262);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(46, 23);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "詞性";
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(517, 135);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(136, 31);
            this.txtbox1.TabIndex = 5;
            // 
            // txtbox2
            // 
            this.txtbox2.Location = new System.Drawing.Point(513, 216);
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.Size = new System.Drawing.Size(136, 31);
            this.txtbox2.TabIndex = 6;
            // 
            // chkbox1
            // 
            this.chkbox1.AutoSize = true;
            this.chkbox1.Location = new System.Drawing.Point(468, 135);
            this.chkbox1.Name = "chkbox1";
            this.chkbox1.Size = new System.Drawing.Size(18, 17);
            this.chkbox1.TabIndex = 8;
            this.chkbox1.UseVisualStyleBackColor = true;
            // 
            // chkbox2
            // 
            this.chkbox2.AutoSize = true;
            this.chkbox2.Location = new System.Drawing.Point(468, 207);
            this.chkbox2.Name = "chkbox2";
            this.chkbox2.Size = new System.Drawing.Size(18, 17);
            this.chkbox2.TabIndex = 9;
            this.chkbox2.UseVisualStyleBackColor = true;
            // 
            // chkbox3
            // 
            this.chkbox3.AutoSize = true;
            this.chkbox3.Location = new System.Drawing.Point(468, 302);
            this.chkbox3.Name = "chkbox3";
            this.chkbox3.Size = new System.Drawing.Size(18, 17);
            this.chkbox3.TabIndex = 10;
            this.chkbox3.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(578, 39);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 32);
            this.btnEnter.TabIndex = 11;
            this.btnEnter.Text = "新增";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // combobox3
            // 
            this.combobox3.FormattingEnabled = true;
            this.combobox3.Items.AddRange(new object[] {
            "n",
            "v",
            "adj",
            "adv",
            "prep",
            "conj",
            "phr",
            "abbr",
            "pron",
            "other"});
            this.combobox3.Location = new System.Drawing.Point(517, 302);
            this.combobox3.Name = "combobox3";
            this.combobox3.Size = new System.Drawing.Size(136, 31);
            this.combobox3.TabIndex = 12;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 1;
            this.vScrollBar1.Location = new System.Drawing.Point(381, 39);
            this.vScrollBar1.Maximum = 0;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 304);
            this.vScrollBar1.TabIndex = 13;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 353);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.combobox3);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.chkbox3);
            this.Controls.Add(this.chkbox2);
            this.Controls.Add(this.chkbox1);
            this.Controls.Add(this.txtbox2);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "單字卡";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開啟舊檔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 儲存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存新檔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 離開ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增單字ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 搜尋單字ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 檢視ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字型大小ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.TextBox txtbox2;
        private System.Windows.Forms.CheckBox chkbox1;
        private System.Windows.Forms.CheckBox chkbox2;
        private System.Windows.Forms.CheckBox chkbox3;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ComboBox combobox3;
        private System.Windows.Forms.ToolStripMenuItem 單字測驗ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 只顯示標記單字ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除標記ToolStripMenuItem;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

