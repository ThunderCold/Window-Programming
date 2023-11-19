using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Practice6_2
{
    public partial class Form1 : Form
    {
        bool setMusic;
        string filePath;
        SoundPlayer player = new SoundPlayer();
        DateTime currentTime, currentTime2;
        int setMin, setHr;
        List<string> record;
        string[] recordType = { "鬧鐘響鈴!\n", "錯誤訊息!\n", "已設定鬧鈴\n", "已設定鬧鐘\n", "已關閉鬧鐘\n", "已匯出記錄檔\n" };
        public Form1()
        {
            InitializeComponent();
        }
        private void DrawNumber(PictureBox pictureBox, int n)
        {
            pictureBox.Width = 101;
            pictureBox.Height = 141;
            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            int[,] num0 = {
                {0, 1, 1, 1, 0},
                {1, 0, 0, 0, 1},
                {1, 0, 0, 0, 1},
                {0, 0, 0, 0, 0},
                {1, 0, 0, 0, 1},
                {1, 0, 0, 0, 1},
                {0, 1, 1, 1, 0}
            };
            int[,] num1 = {
                {0, 0, 0, 0, 0},
                {0, 0, 0, 0, 1},
                {0, 0, 0, 0, 1},
                {0, 0, 0, 0, 0},
                {0, 0, 0, 0, 1},
                {0, 0, 0, 0, 1},
                {0, 0, 0, 0, 0}
            };
            int[,] num2 = {
                {0, 1, 1, 1, 0},
                {0, 0, 0, 0, 1},
                {0, 0, 0, 0, 1},
                {0, 1, 1, 1, 0},
                {1, 0, 0, 0, 0},
                {1, 0, 0, 0, 0},
                {0, 1, 1, 1, 0}
            };
            int[,] num3 = {
                {0, 1, 1, 1, 0},
                {0, 0, 0, 0, 1},
                {0, 0, 0, 0, 1},
                {0, 1, 1, 1, 0},
                {0, 0, 0, 0, 1},
                {0, 0, 0, 0, 1},
                {0, 1, 1, 1, 0}
            };
            int[,] num4 = {
                {0, 0, 0, 0, 0},
                {1, 0, 0, 0, 1},
                {1, 0, 0, 0, 1},
                {0, 1, 1, 1, 0},
                {0, 0, 0, 0, 1},
                {0, 0, 0, 0, 1},
                {0, 0, 0, 0, 0}
            };
            int[,] num5 = {
                {0, 1, 1, 1, 0},
                {1, 0, 0, 0, 0},
                {1, 0, 0, 0, 0},
                {0, 1, 1, 1, 0},
                {0, 0, 0, 0, 1},
                {0, 0, 0, 0, 1},
                {0, 1, 1, 1, 0}
            };
            int[,] num6 = {
                {0, 1, 1, 1, 0},
                {1, 0, 0, 0, 0},
                {1, 0, 0, 0, 0},
                {0, 1, 1, 1, 0},
                {1, 0, 0, 0, 1},
                {1, 0, 0, 0, 1},
                {0, 1, 1, 1, 0}
            };
            int[,] num7 = {
                {0, 1, 1, 1, 0},
                {0, 0, 0, 0, 1},
                {0, 0, 0, 0, 1},
                {0, 0, 0, 0, 0},
                {0, 0, 0, 0, 1},
                {0, 0, 0, 0, 1},
                {0, 0, 0, 0, 0}
            };
            int[,] num8 = {
                {0, 1, 1, 1, 0},
                {1, 0, 0, 0, 1},
                {1, 0, 0, 0, 1},
                {0, 1, 1, 1, 0},
                {1, 0, 0, 0, 1},
                {1, 0, 0, 0, 1},
                {0, 1, 1, 1, 0}
            };
            int[,] num9 = {
                {0, 1, 1, 1, 0},
                {1, 0, 0, 0, 1},
                {1, 0, 0, 0, 1},
                {0, 1, 1, 1, 0},
                {0, 0, 0, 0, 1},
                {0, 0, 0, 0, 1},
                {0, 1, 1, 1, 0}
            };

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White); // 清空PictureBox，設定背景顏色為白色
                int[,] curnum = new int[7, 5];
                if (n == 0) curnum = num0;
                else if (n == 1) curnum = num1;
                else if (n == 2) curnum = num2;
                else if (n == 3) curnum = num3;
                else if (n == 4) curnum = num4;
                else if (n == 5) curnum = num5;
                else if (n == 6) curnum = num6;
                else if (n == 7) curnum = num7;
                else if (n == 8) curnum = num8;
                else if (n == 9) curnum = num9;

                int cellWidth = 20;
                int cellHeight = 20;
                
                for (int x = 0; x < pictureBox.Width; x += cellWidth) // 黑色格線
                {
                    g.DrawLine(Pens.Black, x, 0, x, pictureBox.Height);
                }
                for (int y = 0; y < pictureBox.Height; y += cellHeight)
                {
                    g.DrawLine(Pens.Black, 0, y, pictureBox.Width, y);
                }
                for (int row = 0; row < 7; row++)
                {
                    for (int col = 0; col < 5; col++)
                    {
                        if (curnum[row, col] == 1)
                        {
                            Rectangle rect = new Rectangle(col * cellWidth, row * cellHeight, cellWidth, cellHeight);
                            g.FillRectangle(Brushes.Blue, rect);
                        }
                    }
                }
            }
            pictureBox.Image = bitmap;
        }
        private void showTime(object sender, EventArgs e)
        {
            currentTime = DateTime.Now;
            int hr = currentTime.Hour;
            int min = currentTime.Minute;
            int sec = currentTime.Second;
            string ampm;
            if (hr == 0)
            {
                DrawNumber(picBox1, 1);
                DrawNumber(picBox2, 2);
                ampm = "上午";
            }
            else if (hr <= 11)
            {
                DrawNumber(picBox1, hr / 10);
                DrawNumber(picBox2, hr % 10);
                ampm = "上午";
            }
            else if (hr == 12)
            {
                DrawNumber(picBox1, hr / 10);
                DrawNumber(picBox2, hr % 10);
                ampm = "下午";
            }
            else
            {
                DrawNumber(picBox1, (hr - 12) / 10);
                DrawNumber(picBox2, (hr - 12) % 10);
                ampm = "下午";
            }
            DrawNumber(picBox3, min / 10);
            DrawNumber(picBox4, min % 10);
            DrawNumber(picBox5, sec / 10);
            DrawNumber(picBox6, sec % 10);
            lblampm.Text = ampm;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1400, 400);
            record = new List<string>();
            picBox1.Size = picBox2.Size = picBox3.Size = picBox4.Size = picBox5.Size = picBox6.Size = new Size(101, 141);
            vScrollBar1.Size = new Size(24, 234);
            picBox1.Location = new Point(40, 40);
            picBox2.Location = new Point(190, 40);
            picBox3.Location = new Point(340, 40);
            picBox4.Location = new Point(490, 40);
            picBox5.Location = new Point(640, 40);
            picBox6.Location = new Point(790, 40);
            lblColon1.Location = new Point(298, 76);
            lblColon2.Location = new Point(598, 76);
            lblampm.Location = new Point(920, 165);
            lblRecord.Location = new Point(990, 40);
            btnMusic.Location = new Point(40, 250);
            lblMusic.Location = new Point(160, 250);
            lbl1.Location = new Point(580, 250);
            dateTimePicker1.Location = new Point(700, 250);
            btnSet.Location = new Point(850, 250);
            btnExport.Location = new Point(1245, 300);

            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = 0;

            lblMusic.Size = new Size(400, 30);
            lblRecord.Text = lblMusic.Text = "";
            setMusic = false;
            showTime(sender, e);
            openFileDialog1.Filter = "音訊檔案|*.mp3;*.wav";
            saveFileDialog1.Filter = "文字檔案|*.txt";
            timer.Enabled = true;
            timer2.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            showTime(sender, e);
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "開啟";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                try
                {
                    setMusic = true;
                    lblMusic.Text = filePath;
                    recordAdd(sender, e, 2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("讀取檔案時發生錯誤" + ex.Message);
                }
            }
        }
        private void recordShow(object sender, EventArgs e, int value)
        {
            if (record.Count < 14)
            {
                string tmp = "";
                foreach(string i in record)
                {
                    tmp += i;
                }
                lblRecord.Text = tmp;
            }
            else
            {
                string tmp = "";
                for (int i = value; i < value + 13; i++)
                {
                    tmp += record[i];
                }
                lblRecord.Text = tmp;
            }
        }
        private void recordAdd(object sender, EventArgs e, int n)
        {
            lblRecord.Text += $"{currentTime.ToString("yyyy/MM/dd tt hh:mm:ss")}: {recordType[n]}";
            record.Add($"{currentTime.ToString("yyyy/MM/dd tt hh:mm:ss")}: {recordType[n]}");
            if (record.Count < 14)
            {
                vScrollBar1.Maximum = 0;
            }
            else
            {
                vScrollBar1.Maximum = record.Count - 13;
            }
            recordShow(sender, e, vScrollBar1.Value);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, lblRecord.Text);
                recordAdd(sender, e, 5);
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            recordShow(sender, e, vScrollBar1.Value);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            currentTime2 = DateTime.Now;
            if (currentTime2.Hour == setHr && currentTime2.Minute == setMin)
            {
                timer2.Enabled = false;
                player.SoundLocation = filePath;
                player.Load();
                player.Play();
                recordAdd(sender, e, 0);
                MessageBox.Show("時間到! 該起床囉~", "", MessageBoxButtons.OK);
                btnSet.Text = "停止";
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (btnSet.Text == "啟動")
            {
                if(!setMusic)
                {
                    recordAdd(sender, e, 1);
                    MessageBox.Show("請先設定鬧鈴!", "", MessageBoxButtons.OK);
                }
                else
                {
                    setMin = dateTimePicker1.Value.Minute;
                    setHr = dateTimePicker1.Value.Hour;
                    timer2.Enabled = true;
                    recordAdd(sender, e, 3);
                    btnSet.Text = "停止";
                }
            }
            else
            {
                recordAdd(sender, e, 4);
                timer2.Enabled = false;
                player.Stop();
                btnSet.Text = "啟動";
            }
        }
    }
}
