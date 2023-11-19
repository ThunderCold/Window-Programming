namespace Practice4_2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpgFarm = new System.Windows.Forms.TabPage();
            this.grpboxTool = new System.Windows.Forms.GroupBox();
            this.toolSickle = new System.Windows.Forms.RadioButton();
            this.toolFert = new System.Windows.Forms.RadioButton();
            this.toolSeed = new System.Windows.Forms.RadioButton();
            this.toolWatercan = new System.Windows.Forms.RadioButton();
            this.tabpgStore = new System.Windows.Forms.TabPage();
            this.haveMoney = new System.Windows.Forms.Label();
            this.deal = new System.Windows.Forms.Button();
            this.haveFruit = new System.Windows.Forms.Label();
            this.haveFert = new System.Windows.Forms.Label();
            this.haveSeed = new System.Windows.Forms.Label();
            this.sellFruit = new System.Windows.Forms.CheckBox();
            this.buyFert = new System.Windows.Forms.CheckBox();
            this.buySeed = new System.Windows.Forms.CheckBox();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabpgFarm.SuspendLayout();
            this.grpboxTool.SuspendLayout();
            this.tabpgStore.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpgFarm);
            this.tabControl1.Controls.Add(this.tabpgStore);
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 463);
            this.tabControl1.TabIndex = 0;
            // 
            // tabpgFarm
            // 
            this.tabpgFarm.Controls.Add(this.grpboxTool);
            this.tabpgFarm.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.tabpgFarm.Location = new System.Drawing.Point(4, 29);
            this.tabpgFarm.Margin = new System.Windows.Forms.Padding(2);
            this.tabpgFarm.Name = "tabpgFarm";
            this.tabpgFarm.Padding = new System.Windows.Forms.Padding(2);
            this.tabpgFarm.Size = new System.Drawing.Size(780, 430);
            this.tabpgFarm.TabIndex = 0;
            this.tabpgFarm.Text = "農場";
            this.tabpgFarm.UseVisualStyleBackColor = true;
            // 
            // grpboxTool
            // 
            this.grpboxTool.Controls.Add(this.toolSickle);
            this.grpboxTool.Controls.Add(this.toolFert);
            this.grpboxTool.Controls.Add(this.toolSeed);
            this.grpboxTool.Controls.Add(this.toolWatercan);
            this.grpboxTool.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpboxTool.Location = new System.Drawing.Point(315, 291);
            this.grpboxTool.Margin = new System.Windows.Forms.Padding(2);
            this.grpboxTool.Name = "grpboxTool";
            this.grpboxTool.Padding = new System.Windows.Forms.Padding(2);
            this.grpboxTool.Size = new System.Drawing.Size(454, 135);
            this.grpboxTool.TabIndex = 0;
            this.grpboxTool.TabStop = false;
            this.grpboxTool.Text = "工具";
            // 
            // toolSickle
            // 
            this.toolSickle.AutoSize = true;
            this.toolSickle.Location = new System.Drawing.Point(367, 64);
            this.toolSickle.Margin = new System.Windows.Forms.Padding(2);
            this.toolSickle.Name = "toolSickle";
            this.toolSickle.Size = new System.Drawing.Size(59, 24);
            this.toolSickle.TabIndex = 3;
            this.toolSickle.TabStop = true;
            this.toolSickle.Text = "鐮刀";
            this.toolSickle.UseVisualStyleBackColor = true;
            this.toolSickle.CheckedChanged += new System.EventHandler(this.toolSickle_CheckedChanged);
            // 
            // toolFert
            // 
            this.toolFert.AutoSize = true;
            this.toolFert.Location = new System.Drawing.Point(258, 64);
            this.toolFert.Margin = new System.Windows.Forms.Padding(2);
            this.toolFert.Name = "toolFert";
            this.toolFert.Size = new System.Drawing.Size(59, 24);
            this.toolFert.TabIndex = 2;
            this.toolFert.TabStop = true;
            this.toolFert.Text = "肥料";
            this.toolFert.UseVisualStyleBackColor = true;
            this.toolFert.CheckedChanged += new System.EventHandler(this.toolFert_CheckedChanged);
            // 
            // toolSeed
            // 
            this.toolSeed.AutoSize = true;
            this.toolSeed.Location = new System.Drawing.Point(151, 64);
            this.toolSeed.Margin = new System.Windows.Forms.Padding(2);
            this.toolSeed.Name = "toolSeed";
            this.toolSeed.Size = new System.Drawing.Size(59, 24);
            this.toolSeed.TabIndex = 1;
            this.toolSeed.TabStop = true;
            this.toolSeed.Text = "種子";
            this.toolSeed.UseVisualStyleBackColor = true;
            this.toolSeed.CheckedChanged += new System.EventHandler(this.toolSeed_CheckedChanged);
            // 
            // toolWatercan
            // 
            this.toolWatercan.AutoSize = true;
            this.toolWatercan.Location = new System.Drawing.Point(30, 64);
            this.toolWatercan.Margin = new System.Windows.Forms.Padding(2);
            this.toolWatercan.Name = "toolWatercan";
            this.toolWatercan.Size = new System.Drawing.Size(75, 24);
            this.toolWatercan.TabIndex = 0;
            this.toolWatercan.TabStop = true;
            this.toolWatercan.Text = "澆水器";
            this.toolWatercan.UseVisualStyleBackColor = true;
            this.toolWatercan.CheckedChanged += new System.EventHandler(this.toolWatercan_CheckedChanged);
            // 
            // tabpgStore
            // 
            this.tabpgStore.Controls.Add(this.haveMoney);
            this.tabpgStore.Controls.Add(this.deal);
            this.tabpgStore.Controls.Add(this.haveFruit);
            this.tabpgStore.Controls.Add(this.haveFert);
            this.tabpgStore.Controls.Add(this.haveSeed);
            this.tabpgStore.Controls.Add(this.sellFruit);
            this.tabpgStore.Controls.Add(this.buyFert);
            this.tabpgStore.Controls.Add(this.buySeed);
            this.tabpgStore.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.tabpgStore.Location = new System.Drawing.Point(4, 29);
            this.tabpgStore.Margin = new System.Windows.Forms.Padding(2);
            this.tabpgStore.Name = "tabpgStore";
            this.tabpgStore.Padding = new System.Windows.Forms.Padding(2);
            this.tabpgStore.Size = new System.Drawing.Size(780, 430);
            this.tabpgStore.TabIndex = 1;
            this.tabpgStore.Text = "商店";
            this.tabpgStore.UseVisualStyleBackColor = true;
            // 
            // haveMoney
            // 
            this.haveMoney.AutoSize = true;
            this.haveMoney.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.haveMoney.Location = new System.Drawing.Point(342, 49);
            this.haveMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.haveMoney.Name = "haveMoney";
            this.haveMoney.Size = new System.Drawing.Size(54, 20);
            this.haveMoney.TabIndex = 7;
            this.haveMoney.Text = "label1";
            // 
            // deal
            // 
            this.deal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.deal.Location = new System.Drawing.Point(346, 316);
            this.deal.Margin = new System.Windows.Forms.Padding(2);
            this.deal.Name = "deal";
            this.deal.Size = new System.Drawing.Size(65, 28);
            this.deal.TabIndex = 6;
            this.deal.Text = "買/賣";
            this.deal.UseVisualStyleBackColor = true;
            this.deal.Click += new System.EventHandler(this.deal_Click);
            // 
            // haveFruit
            // 
            this.haveFruit.AutoSize = true;
            this.haveFruit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.haveFruit.Location = new System.Drawing.Point(566, 217);
            this.haveFruit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.haveFruit.Name = "haveFruit";
            this.haveFruit.Size = new System.Drawing.Size(54, 20);
            this.haveFruit.TabIndex = 5;
            this.haveFruit.Text = "label3";
            // 
            // haveFert
            // 
            this.haveFert.AutoSize = true;
            this.haveFert.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.haveFert.Location = new System.Drawing.Point(342, 217);
            this.haveFert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.haveFert.Name = "haveFert";
            this.haveFert.Size = new System.Drawing.Size(54, 20);
            this.haveFert.TabIndex = 4;
            this.haveFert.Text = "label2";
            // 
            // haveSeed
            // 
            this.haveSeed.AutoSize = true;
            this.haveSeed.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.haveSeed.Location = new System.Drawing.Point(125, 217);
            this.haveSeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.haveSeed.Name = "haveSeed";
            this.haveSeed.Size = new System.Drawing.Size(54, 20);
            this.haveSeed.TabIndex = 3;
            this.haveSeed.Text = "label1";
            // 
            // sellFruit
            // 
            this.sellFruit.AutoSize = true;
            this.sellFruit.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.sellFruit.Location = new System.Drawing.Point(570, 121);
            this.sellFruit.Margin = new System.Windows.Forms.Padding(2);
            this.sellFruit.Name = "sellFruit";
            this.sellFruit.Size = new System.Drawing.Size(60, 24);
            this.sellFruit.TabIndex = 2;
            this.sellFruit.Text = "果實";
            this.sellFruit.UseVisualStyleBackColor = true;
            // 
            // buyFert
            // 
            this.buyFert.AutoSize = true;
            this.buyFert.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.buyFert.Location = new System.Drawing.Point(346, 121);
            this.buyFert.Margin = new System.Windows.Forms.Padding(2);
            this.buyFert.Name = "buyFert";
            this.buyFert.Size = new System.Drawing.Size(60, 24);
            this.buyFert.TabIndex = 1;
            this.buyFert.Text = "肥料";
            this.buyFert.UseVisualStyleBackColor = true;
            // 
            // buySeed
            // 
            this.buySeed.AutoSize = true;
            this.buySeed.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.buySeed.Location = new System.Drawing.Point(129, 121);
            this.buySeed.Margin = new System.Windows.Forms.Padding(2);
            this.buySeed.Name = "buySeed";
            this.buySeed.Size = new System.Drawing.Size(60, 24);
            this.buySeed.TabIndex = 0;
            this.buySeed.Text = "種子";
            this.buySeed.UseVisualStyleBackColor = true;
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgList.ImageSize = new System.Drawing.Size(100, 100);
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabpgFarm.ResumeLayout(false);
            this.grpboxTool.ResumeLayout(false);
            this.grpboxTool.PerformLayout();
            this.tabpgStore.ResumeLayout(false);
            this.tabpgStore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpgFarm;
        private System.Windows.Forms.TabPage tabpgStore;
        private System.Windows.Forms.CheckBox sellFruit;
        private System.Windows.Forms.CheckBox buyFert;
        private System.Windows.Forms.CheckBox buySeed;
        private System.Windows.Forms.Label haveSeed;
        private System.Windows.Forms.Label haveFruit;
        private System.Windows.Forms.Label haveFert;
        private System.Windows.Forms.Label haveMoney;
        private System.Windows.Forms.Button deal;
        private System.Windows.Forms.GroupBox grpboxTool;
        private System.Windows.Forms.RadioButton toolSickle;
        private System.Windows.Forms.RadioButton toolFert;
        private System.Windows.Forms.RadioButton toolSeed;
        private System.Windows.Forms.RadioButton toolWatercan;
        private System.Windows.Forms.ImageList imgList;
    }
}

