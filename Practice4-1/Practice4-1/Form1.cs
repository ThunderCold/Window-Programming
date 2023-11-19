using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice4_1
{
    public partial class Form1 : Form
    {
        int[] ans = new int[5];
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=1;i<=4;i++)
            {
                ans[i] = random.Next(0, 10);
            }
            label1.Text = $"{ans[1]}{ans[2]}{ans[3]}{ans[4]}";
            label1.Visible = false;
            imageList1.Images.Add(new Bitmap("img/0.jpg"));
            imageList1.Images.Add(new Bitmap("img/1.jpg"));
            imageList1.Images.Add(new Bitmap("img/2.jpg"));
            imageList1.Images.Add(new Bitmap("img/3.jpg"));
            imageList1.Images.Add(new Bitmap("img/4.jpg"));
            imageList1.Images.Add(new Bitmap("img/5.jpg"));
            imageList1.Images.Add(new Bitmap("img/6.jpg"));
            imageList1.Images.Add(new Bitmap("img/7.jpg"));
            imageList1.Images.Add(new Bitmap("img/8.jpg"));
            imageList1.Images.Add(new Bitmap("img/9.jpg"));
            button1.ImageIndex = 0;
            button2.ImageIndex = 0;
            button3.ImageIndex = 0;
            button4.ImageIndex = 0;
            /*button1.Image = new Bitmap(button1.Image, new Size(50, 50));
            button2.Image = new Bitmap(button2.Image, new Size(50, 50));
            button3.Image = new Bitmap(button3.Image, new Size(50, 50));
            button4.Image = new Bitmap(button4.Image, new Size(50, 50));*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.ImageIndex == 9)
            {
                button1.ImageIndex = 0;
            }
            else
            {
                button1.ImageIndex++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.ImageIndex == 9)
            {
                button2.ImageIndex = 0;
            }
            else
            {
                button2.ImageIndex++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.ImageIndex == 9)
            {
                button3.ImageIndex = 0;
            }
            else
            {
                button3.ImageIndex++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.ImageIndex == 9)
            {
                button4.ImageIndex = 0;
            }
            else
            {
                button4.ImageIndex++;
            }
        }

        private void btonEnter_Click(object sender, EventArgs e)
        {
            int correct = 0;
            if (ans[1] == button1.ImageIndex)
            {
                correct++;
            }
            if (ans[2] == button2.ImageIndex)
            {
                correct++;
            }
            if (ans[3] == button3.ImageIndex)
            {
                correct++;
            }
            if (ans[4] == button4.ImageIndex)
            {
                correct++;
            }
            DialogResult result;
            if(correct == 4)
            {
                result = MessageBox.Show("解鎖成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            else
            {
                result = MessageBox.Show($"猜對{correct}個位置", "失敗", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if(result == DialogResult.Cancel)
                {
                    result = MessageBox.Show($"答案是{ans[1]}{ans[2]}{ans[3]}{ans[4]}", "", MessageBoxButtons.OK);
                    if (result==DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            }
        }
    }
}
