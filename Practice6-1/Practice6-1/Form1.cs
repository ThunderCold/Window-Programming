using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice6_1
{
    public partial class Form1 : Form
    {
        Button[,] btn = new Button[3, 3];
        Random random = new Random();
        int curtime = 0, curstep = 0, curmin = 0, cursec = 0;
        bool imgChosen;
        bool[,] btnExist = new bool[3, 3];
        int[,] imgRec = new int[3, 3];
        Image resizedImage;
        String min, sec;
        private Image[] dividedImages = new Image[9];
        public Form1()  
        {
            InitializeComponent();
        }
        private void checkWin(object sender, EventArgs e)
        {
            bool win = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i != 2 || j != 2)
                    {
                        int a = int.Parse(btn[i, j].Tag as string) / 10;
                        int b = int.Parse(btn[i, j].Tag as string) % 10;
                        if (a * 3 + b != imgRec[i, j])
                        {
                            win = false;
                            break;
                        }
                    }
                }
            }
            if (win)
            {
                timer.Enabled = false;
                MessageBox.Show($"你獲勝了!\n完成時間: {min}:{sec}\n移動步數: {curstep}", "", MessageBoxButtons.OK);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (i != 2 || j != 2)
                        {
                            btn[i, j].Enabled = false;
                        }
                    }
                }
                curtime = curstep = 0;
                lblTime.Text = $"Time: 00:00";
                lblStep.Text = $"移動步數: 0";
            }
        }

        private void btnClick(object sender, EventArgs e)
        {
            Button cur = (Button)sender;
            int x = int.Parse(cur.Tag as string) / 10;
            int y = int.Parse(cur.Tag as string) % 10;
            if (y > 0 && !btnExist[x, y - 1])
            {
                cur.Location = new Point(cur.Location.X - 90, cur.Location.Y);
                btnExist[x, y] = false;
                btnExist[x, y - 1] = true;
                cur.Tag = $"{x}{y - 1}";
                curstep += 1;
            }
            else if (y < 2 && !btnExist[x, y + 1])
            {
                cur.Location = new Point(cur.Location.X + 90, cur.Location.Y);
                btnExist[x, y] = false;
                btnExist[x, y + 1] = true;
                cur.Tag = $"{x}{y + 1}";
                curstep += 1;
            }
            else if (x > 0 && !btnExist[x - 1, y])
            {
                cur.Location = new Point(cur.Location.X, cur.Location.Y - 90);
                btnExist[x, y] = false;
                btnExist[x - 1, y] = true;
                cur.Tag = $"{x - 1}{y}";
                curstep += 1;
            }
            else if (x < 2 && !btnExist[x + 1, y])
            {
                cur.Location = new Point(cur.Location.X, cur.Location.Y + 90);
                btnExist[x, y] = false;
                btnExist[x + 1, y] = true;
                cur.Tag = $"{x + 1}{y}";
                curstep += 1;
            }
            else
            {
                return;
            }
            lblStep.Text = $"移動步數: {curstep.ToString()}";
            checkWin(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(760, 430);
            lblNoshow.Visible = lblShow.Visible = trkbarVis.Visible = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i != 2 || j != 2)
                    {
                        btn[i, j] = new Button();
                        btn[i, j].Size = new Size(90, 90);
                        btn[i, j].Location = new Point(10 + 90 * j, 10 + 90 * i);
                        btn[i, j].Tag = $"{i}{j}";
                        this.Controls.Add(btn[i, j]);
                        btnExist[i, j] = true;
                        btn[i, j].Click += btnClick;
                    }
                    else
                    {
                        btnExist[i, j] = false;
                    }
                }
            }
            lblTime.Text = $"Time: 00:00";
            lblStep.Text = $"移動步數: 0";
            lblStep.Size = lblTime.Size = new System.Drawing.Size(140, 23);
            btnChoose.Size = btnStart.Size = new System.Drawing.Size(120, 35);
            trkbarVis.Size = new System.Drawing.Size(125, 50);
            lblNoshow.Location= new Point(480, 290);
            lblShow.Location = new Point(658, 290);
            trkbarVis.Location = new Point(530, 290);
            btnStart.Location = new Point(85, 340);
            btnChoose.Location = new Point(535, 340);
            lblTime.Location = new Point(300, 150);
            lblStep.Location = new Point(300, 200);
            picbox.Location = new Point(460, 10);
            picbox.Size = new Size(270, 270);
            imgChosen = false;
            curstep = curtime = 0;
        }

        private void divide(Image img)
        {
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Bitmap dividedImage = new Bitmap(90, 90);
                    Graphics g = Graphics.FromImage(dividedImage);
                    g.DrawImage(img, new Rectangle(0, 0, 90, 90), new Rectangle(j * 90, i * 90, 90, 90), GraphicsUnit.Pixel);
                    g.Dispose();
                    dividedImages[i * 3 + j] = dividedImage;
                }
            }
            List<int> numList = new List<int>();
            for (int i = 0; i <= 7; i++)
            {
                numList.Add(i);
            }
            for (int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    if (i != 2 || j != 2)
                    {
                        int tmp = random.Next(0, 8 - (i * 3 + j));
                        btn[i, j].Image = dividedImages[numList[tmp]];
                        imgRec[i, j] = numList[tmp];
                        numList.RemoveAt(tmp);
                    }
                }
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.ico";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImage = openFileDialog.FileName;
                Image originalImage = Image.FromFile(selectedImage);
                resizedImage = new Bitmap(270, 270);
                using (Graphics g = Graphics.FromImage(resizedImage))
                {
                    g.DrawImage(originalImage, 0, 0, 270, 270);
                }
                picbox.Image = resizedImage;
                imgChosen = true;
                lblNoshow.Visible = lblShow.Visible = trkbarVis.Visible = true;
                trkbarVis.Value = 1;
            }
        }

        private void trkbarVis_Scroll(object sender, EventArgs e)
        {
            if (trkbarVis.Value == 0)
            {
                picbox.Image = null;
                picbox.BackColor = Color.Gray;
            }
            else
            {
                picbox.Image = resizedImage;
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            if(imgChosen)
            {
                for (int i = 0; i < 3; i++)//
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (i != 2 || j != 2)
                        {
                            btn[i, j].Location = new Point(10 + 90 * j, 10 + 90 * i);
                            btn[i, j].Tag = $"{i}{j}";
                            btnExist[i, j] = true;
                        }
                        else
                        {
                            btnExist[i, j] = false;
                        }
                    }
                }
                divide(resizedImage);
                curstep = curtime = 0;
                for(int i=0;i<3;i++)
                {
                    for(int j=0;j<3;j++)
                    {
                        if(i!=2||j!=2)
                        {
                            btn[i, j].Enabled = true;
                        }
                    }
                }
                curtime = curstep = 0;
                lblTime.Text = $"Time: 00:00";
                lblStep.Text = $"移動步數: 0";
                timer.Enabled = true;
                checkWin(sender, e);
            }
            else
            {
                MessageBox.Show("請先選擇圖片!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            curtime++;
            curmin = curtime / 60;
            cursec = curtime % 60;
            if(curmin>=10)
            {
                min = curmin.ToString();
            }
            else
            {
                min = $"0{curmin}";
            }
            if(cursec>=10)
            {
                sec = cursec.ToString();
            }
            else
            {
                sec = $"0{cursec}";
            }
            lblTime.Text = $"Time: {min}:{sec}";
        }
    }
}
