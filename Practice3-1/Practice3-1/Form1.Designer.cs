namespace Practice3_1
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirth = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelCatdog = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.txtboxGender = new System.Windows.Forms.TextBox();
            this.txtboxBirth = new System.Windows.Forms.TextBox();
            this.txtboxDate = new System.Windows.Forms.TextBox();
            this.txtboxCatdog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorName = new System.Windows.Forms.Label();
            this.errorGender = new System.Windows.Forms.Label();
            this.errorBirth = new System.Windows.Forms.Label();
            this.errorDate = new System.Windows.Forms.Label();
            this.errorCatdog = new System.Windows.Forms.Label();
            this.btonEnter = new System.Windows.Forms.Button();
            this.ansName = new System.Windows.Forms.Label();
            this.ansGender = new System.Windows.Forms.Label();
            this.ansBirth = new System.Windows.Forms.Label();
            this.ansDate = new System.Windows.Forms.Label();
            this.ansCatdog = new System.Windows.Forms.Label();
            this.fortune = new System.Windows.Forms.Label();
            this.suggestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.labelName.Location = new System.Drawing.Point(90, 64);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(36, 18);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "姓名";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.labelGender.Location = new System.Drawing.Point(90, 112);
            this.labelGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(36, 18);
            this.labelGender.TabIndex = 1;
            this.labelGender.Text = "性別";
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.labelBirth.Location = new System.Drawing.Point(90, 160);
            this.labelBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(78, 18);
            this.labelBirth.TabIndex = 2;
            this.labelBirth.Text = "出生年月日";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.labelDate.Location = new System.Drawing.Point(90, 208);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(64, 18);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "今日日期";
            // 
            // labelCatdog
            // 
            this.labelCatdog.AutoSize = true;
            this.labelCatdog.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.labelCatdog.Location = new System.Drawing.Point(90, 256);
            this.labelCatdog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCatdog.Name = "labelCatdog";
            this.labelCatdog.Size = new System.Drawing.Size(78, 18);
            this.labelCatdog.TabIndex = 4;
            this.labelCatdog.Text = "貓派or狗派";
            // 
            // txtboxName
            // 
            this.txtboxName.Font = new System.Drawing.Font("微軟正黑體", 12.5F);
            this.txtboxName.Location = new System.Drawing.Point(188, 64);
            this.txtboxName.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(300, 30);
            this.txtboxName.TabIndex = 5;
            this.txtboxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtboxGender
            // 
            this.txtboxGender.Font = new System.Drawing.Font("微軟正黑體", 12.5F);
            this.txtboxGender.Location = new System.Drawing.Point(188, 112);
            this.txtboxGender.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxGender.Name = "txtboxGender";
            this.txtboxGender.Size = new System.Drawing.Size(300, 30);
            this.txtboxGender.TabIndex = 6;
            this.txtboxGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtboxBirth
            // 
            this.txtboxBirth.Font = new System.Drawing.Font("微軟正黑體", 12.5F);
            this.txtboxBirth.Location = new System.Drawing.Point(188, 160);
            this.txtboxBirth.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxBirth.Name = "txtboxBirth";
            this.txtboxBirth.Size = new System.Drawing.Size(300, 30);
            this.txtboxBirth.TabIndex = 7;
            this.txtboxBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtboxDate
            // 
            this.txtboxDate.Font = new System.Drawing.Font("微軟正黑體", 12.5F);
            this.txtboxDate.Location = new System.Drawing.Point(188, 208);
            this.txtboxDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxDate.Name = "txtboxDate";
            this.txtboxDate.Size = new System.Drawing.Size(300, 30);
            this.txtboxDate.TabIndex = 8;
            this.txtboxDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtboxCatdog
            // 
            this.txtboxCatdog.Font = new System.Drawing.Font("微軟正黑體", 12.5F);
            this.txtboxCatdog.Location = new System.Drawing.Point(188, 256);
            this.txtboxCatdog.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxCatdog.Name = "txtboxCatdog";
            this.txtboxCatdog.Size = new System.Drawing.Size(300, 30);
            this.txtboxCatdog.TabIndex = 9;
            this.txtboxCatdog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F);
            this.label1.Location = new System.Drawing.Point(255, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "資料輸入";
            // 
            // errorName
            // 
            this.errorName.AutoSize = true;
            this.errorName.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.errorName.Location = new System.Drawing.Point(435, 64);
            this.errorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorName.Name = "errorName";
            this.errorName.Size = new System.Drawing.Size(0, 18);
            this.errorName.TabIndex = 11;
            // 
            // errorGender
            // 
            this.errorGender.AutoSize = true;
            this.errorGender.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.errorGender.Location = new System.Drawing.Point(435, 112);
            this.errorGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorGender.Name = "errorGender";
            this.errorGender.Size = new System.Drawing.Size(0, 18);
            this.errorGender.TabIndex = 12;
            // 
            // errorBirth
            // 
            this.errorBirth.AutoSize = true;
            this.errorBirth.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.errorBirth.Location = new System.Drawing.Point(435, 160);
            this.errorBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorBirth.Name = "errorBirth";
            this.errorBirth.Size = new System.Drawing.Size(0, 18);
            this.errorBirth.TabIndex = 13;
            // 
            // errorDate
            // 
            this.errorDate.AutoSize = true;
            this.errorDate.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.errorDate.Location = new System.Drawing.Point(435, 208);
            this.errorDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorDate.Name = "errorDate";
            this.errorDate.Size = new System.Drawing.Size(0, 18);
            this.errorDate.TabIndex = 14;
            // 
            // errorCatdog
            // 
            this.errorCatdog.AutoSize = true;
            this.errorCatdog.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.errorCatdog.Location = new System.Drawing.Point(435, 256);
            this.errorCatdog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorCatdog.Name = "errorCatdog";
            this.errorCatdog.Size = new System.Drawing.Size(0, 18);
            this.errorCatdog.TabIndex = 15;
            // 
            // btonEnter
            // 
            this.btonEnter.Font = new System.Drawing.Font("微軟正黑體", 12.5F);
            this.btonEnter.Location = new System.Drawing.Point(188, 336);
            this.btonEnter.Margin = new System.Windows.Forms.Padding(2);
            this.btonEnter.Name = "btonEnter";
            this.btonEnter.Size = new System.Drawing.Size(300, 30);
            this.btonEnter.TabIndex = 16;
            this.btonEnter.Text = "AI大神";
            this.btonEnter.UseVisualStyleBackColor = true;
            this.btonEnter.Click += new System.EventHandler(this.btonEnter_Click);
            // 
            // ansName
            // 
            this.ansName.AutoSize = true;
            this.ansName.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.ansName.Location = new System.Drawing.Point(500, 98);
            this.ansName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ansName.Name = "ansName";
            this.ansName.Size = new System.Drawing.Size(49, 18);
            this.ansName.TabIndex = 17;
            this.ansName.Text = "label2";
            // 
            // ansGender
            // 
            this.ansGender.AutoSize = true;
            this.ansGender.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.ansGender.Location = new System.Drawing.Point(499, 135);
            this.ansGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ansGender.Name = "ansGender";
            this.ansGender.Size = new System.Drawing.Size(49, 18);
            this.ansGender.TabIndex = 18;
            this.ansGender.Text = "label3";
            // 
            // ansBirth
            // 
            this.ansBirth.AutoSize = true;
            this.ansBirth.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.ansBirth.Location = new System.Drawing.Point(500, 188);
            this.ansBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ansBirth.Name = "ansBirth";
            this.ansBirth.Size = new System.Drawing.Size(49, 18);
            this.ansBirth.TabIndex = 19;
            this.ansBirth.Text = "label4";
            // 
            // ansDate
            // 
            this.ansDate.AutoSize = true;
            this.ansDate.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.ansDate.Location = new System.Drawing.Point(501, 225);
            this.ansDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ansDate.Name = "ansDate";
            this.ansDate.Size = new System.Drawing.Size(49, 18);
            this.ansDate.TabIndex = 20;
            this.ansDate.Text = "label5";
            // 
            // ansCatdog
            // 
            this.ansCatdog.AutoSize = true;
            this.ansCatdog.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.ansCatdog.Location = new System.Drawing.Point(501, 261);
            this.ansCatdog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ansCatdog.Name = "ansCatdog";
            this.ansCatdog.Size = new System.Drawing.Size(49, 18);
            this.ansCatdog.TabIndex = 21;
            this.ansCatdog.Text = "label6";
            // 
            // fortune
            // 
            this.fortune.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Italic);
            this.fortune.Location = new System.Drawing.Point(177, 301);
            this.fortune.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fortune.Name = "fortune";
            this.fortune.Size = new System.Drawing.Size(700, 30);
            this.fortune.TabIndex = 22;
            this.fortune.Text = "運勢";
            // 
            // suggestion
            // 
            this.suggestion.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Italic);
            this.suggestion.Location = new System.Drawing.Point(261, 300);
            this.suggestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.suggestion.Name = "suggestion";
            this.suggestion.Size = new System.Drawing.Size(700, 30);
            this.suggestion.TabIndex = 23;
            this.suggestion.Text = "建議";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.suggestion);
            this.Controls.Add(this.fortune);
            this.Controls.Add(this.ansCatdog);
            this.Controls.Add(this.ansDate);
            this.Controls.Add(this.ansBirth);
            this.Controls.Add(this.ansGender);
            this.Controls.Add(this.ansName);
            this.Controls.Add(this.btonEnter);
            this.Controls.Add(this.errorCatdog);
            this.Controls.Add(this.errorDate);
            this.Controls.Add(this.errorBirth);
            this.Controls.Add(this.errorGender);
            this.Controls.Add(this.errorName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxCatdog);
            this.Controls.Add(this.txtboxDate);
            this.Controls.Add(this.txtboxBirth);
            this.Controls.Add(this.txtboxGender);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.labelCatdog);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelBirth);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelCatdog;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.TextBox txtboxGender;
        private System.Windows.Forms.TextBox txtboxBirth;
        private System.Windows.Forms.TextBox txtboxDate;
        private System.Windows.Forms.TextBox txtboxCatdog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorName;
        private System.Windows.Forms.Label errorGender;
        private System.Windows.Forms.Label errorBirth;
        private System.Windows.Forms.Label errorDate;
        private System.Windows.Forms.Label errorCatdog;
        private System.Windows.Forms.Button btonEnter;
        private System.Windows.Forms.Label ansName;
        private System.Windows.Forms.Label ansGender;
        private System.Windows.Forms.Label ansBirth;
        private System.Windows.Forms.Label ansDate;
        private System.Windows.Forms.Label ansCatdog;
        private System.Windows.Forms.Label fortune;
        private System.Windows.Forms.Label suggestion;
    }
}

