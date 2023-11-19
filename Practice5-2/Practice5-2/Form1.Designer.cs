namespace Practice5_2
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
            this.lblStage = new System.Windows.Forms.Label();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBerserker = new System.Windows.Forms.Button();
            this.btnSaber = new System.Windows.Forms.Button();
            this.btnCaster = new System.Windows.Forms.Button();
            this.lblTurn = new System.Windows.Forms.Label();
            this.myChar = new System.Windows.Forms.Label();
            this.myHP = new System.Windows.Forms.Label();
            this.myCharge = new System.Windows.Forms.Label();
            this.myAtk = new System.Windows.Forms.Label();
            this.comChar = new System.Windows.Forms.Label();
            this.comHP = new System.Windows.Forms.Label();
            this.comCharge = new System.Windows.Forms.Label();
            this.comAtk = new System.Windows.Forms.Label();
            this.btnAD = new System.Windows.Forms.Button();
            this.btnAP = new System.Windows.Forms.Button();
            this.btnULT = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStart.Location = new System.Drawing.Point(102, 51);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 36);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "開始遊戲";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblStage
            // 
            this.lblStage.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStage.Location = new System.Drawing.Point(305, 28);
            this.lblStage.Name = "lblStage";
            this.lblStage.Size = new System.Drawing.Size(92, 25);
            this.lblStage.TabIndex = 1;
            this.lblStage.Text = "準備階段";
            this.lblStage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountdown
            // 
            this.lblCountdown.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCountdown.Location = new System.Drawing.Point(332, 76);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(36, 25);
            this.lblCountdown.TabIndex = 2;
            this.lblCountdown.Text = "10";
            this.lblCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnBerserker
            // 
            this.btnBerserker.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBerserker.Location = new System.Drawing.Point(113, 107);
            this.btnBerserker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBerserker.Name = "btnBerserker";
            this.btnBerserker.Size = new System.Drawing.Size(108, 35);
            this.btnBerserker.TabIndex = 3;
            this.btnBerserker.Text = "Berserker";
            this.btnBerserker.UseVisualStyleBackColor = true;
            this.btnBerserker.Click += new System.EventHandler(this.btnBerserker_Click);
            // 
            // btnSaber
            // 
            this.btnSaber.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSaber.Location = new System.Drawing.Point(289, 107);
            this.btnSaber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaber.Name = "btnSaber";
            this.btnSaber.Size = new System.Drawing.Size(108, 35);
            this.btnSaber.TabIndex = 4;
            this.btnSaber.Text = "Saber";
            this.btnSaber.UseVisualStyleBackColor = true;
            this.btnSaber.Click += new System.EventHandler(this.btnSaber_Click);
            // 
            // btnCaster
            // 
            this.btnCaster.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCaster.Location = new System.Drawing.Point(502, 107);
            this.btnCaster.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCaster.Name = "btnCaster";
            this.btnCaster.Size = new System.Drawing.Size(108, 35);
            this.btnCaster.TabIndex = 5;
            this.btnCaster.Text = "Caster";
            this.btnCaster.UseVisualStyleBackColor = true;
            this.btnCaster.Click += new System.EventHandler(this.btnCaster_Click);
            // 
            // lblTurn
            // 
            this.lblTurn.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTurn.Location = new System.Drawing.Point(317, 370);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(51, 19);
            this.lblTurn.TabIndex = 6;
            this.lblTurn.Text = "label1";
            this.lblTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // myChar
            // 
            this.myChar.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.myChar.Location = new System.Drawing.Point(12, 78);
            this.myChar.Name = "myChar";
            this.myChar.Size = new System.Drawing.Size(81, 23);
            this.myChar.TabIndex = 7;
            this.myChar.Text = "label1";
            this.myChar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // myHP
            // 
            this.myHP.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.myHP.Location = new System.Drawing.Point(12, 151);
            this.myHP.Name = "myHP";
            this.myHP.Size = new System.Drawing.Size(61, 23);
            this.myHP.TabIndex = 8;
            this.myHP.Text = "label2";
            this.myHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // myCharge
            // 
            this.myCharge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.myCharge.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.myCharge.Location = new System.Drawing.Point(12, 221);
            this.myCharge.Name = "myCharge";
            this.myCharge.Size = new System.Drawing.Size(95, 23);
            this.myCharge.TabIndex = 9;
            this.myCharge.Text = "label3";
            this.myCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // myAtk
            // 
            this.myAtk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.myAtk.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.myAtk.Location = new System.Drawing.Point(12, 297);
            this.myAtk.Name = "myAtk";
            this.myAtk.Size = new System.Drawing.Size(61, 23);
            this.myAtk.TabIndex = 10;
            this.myAtk.Text = "label4";
            this.myAtk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comChar
            // 
            this.comChar.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comChar.Location = new System.Drawing.Point(610, 84);
            this.comChar.Name = "comChar";
            this.comChar.Size = new System.Drawing.Size(51, 19);
            this.comChar.TabIndex = 11;
            this.comChar.Text = "label5";
            this.comChar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comHP
            // 
            this.comHP.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comHP.Location = new System.Drawing.Point(619, 175);
            this.comHP.Name = "comHP";
            this.comHP.Size = new System.Drawing.Size(51, 19);
            this.comHP.TabIndex = 12;
            this.comHP.Text = "label6";
            this.comHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comCharge
            // 
            this.comCharge.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comCharge.Location = new System.Drawing.Point(619, 236);
            this.comCharge.Name = "comCharge";
            this.comCharge.Size = new System.Drawing.Size(51, 19);
            this.comCharge.TabIndex = 13;
            this.comCharge.Text = "label7";
            this.comCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comAtk
            // 
            this.comAtk.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comAtk.Location = new System.Drawing.Point(619, 301);
            this.comAtk.Name = "comAtk";
            this.comAtk.Size = new System.Drawing.Size(51, 19);
            this.comAtk.TabIndex = 14;
            this.comAtk.Text = "label8";
            this.comAtk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAD
            // 
            this.btnAD.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAD.Location = new System.Drawing.Point(129, 291);
            this.btnAD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAD.Name = "btnAD";
            this.btnAD.Size = new System.Drawing.Size(84, 29);
            this.btnAD.TabIndex = 15;
            this.btnAD.Text = "普攻";
            this.btnAD.UseVisualStyleBackColor = true;
            this.btnAD.Click += new System.EventHandler(this.btnAD_Click);
            // 
            // btnAP
            // 
            this.btnAP.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAP.Location = new System.Drawing.Point(301, 291);
            this.btnAP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAP.Name = "btnAP";
            this.btnAP.Size = new System.Drawing.Size(84, 29);
            this.btnAP.TabIndex = 16;
            this.btnAP.Text = "技能";
            this.btnAP.UseVisualStyleBackColor = true;
            this.btnAP.Click += new System.EventHandler(this.btnAP_Click);
            // 
            // btnULT
            // 
            this.btnULT.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnULT.Location = new System.Drawing.Point(488, 291);
            this.btnULT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnULT.Name = "btnULT";
            this.btnULT.Size = new System.Drawing.Size(84, 29);
            this.btnULT.TabIndex = 17;
            this.btnULT.Text = "寶貝";
            this.btnULT.UseVisualStyleBackColor = true;
            this.btnULT.Click += new System.EventHandler(this.btnULT_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.btnULT);
            this.Controls.Add(this.btnAP);
            this.Controls.Add(this.btnAD);
            this.Controls.Add(this.comAtk);
            this.Controls.Add(this.comCharge);
            this.Controls.Add(this.comHP);
            this.Controls.Add(this.comChar);
            this.Controls.Add(this.myAtk);
            this.Controls.Add(this.myCharge);
            this.Controls.Add(this.myHP);
            this.Controls.Add(this.myChar);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.btnCaster);
            this.Controls.Add(this.btnSaber);
            this.Controls.Add(this.btnBerserker);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.lblStage);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblStage;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBerserker;
        private System.Windows.Forms.Button btnSaber;
        private System.Windows.Forms.Button btnCaster;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label myChar;
        private System.Windows.Forms.Label myHP;
        private System.Windows.Forms.Label myCharge;
        private System.Windows.Forms.Label myAtk;
        private System.Windows.Forms.Label comChar;
        private System.Windows.Forms.Label comHP;
        private System.Windows.Forms.Label comCharge;
        private System.Windows.Forms.Label comAtk;
        private System.Windows.Forms.Button btnAD;
        private System.Windows.Forms.Button btnAP;
        private System.Windows.Forms.Button btnULT;
        private System.Windows.Forms.Timer timer2;
    }
}

