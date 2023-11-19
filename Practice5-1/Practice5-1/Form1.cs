using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice5_1
{
    public partial class Form1 : Form
    {
        Button[] btn = new Button[36];
        Random random = new Random();
        List<int> mylist = new List<int>();
        int[] ans = new int[3];
        int cur = 5, stage;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            start.Enabled = true;
            start.Visible = true;
            labelStage.Visible = false;
            labelTimer.Visible = false;
            tmp.Visible = false;
            stage = 0;
        }
        void createButton(object sender, EventArgs e)
        {
            for(int i=0;i<36;i++)
            {
                btn[i] = new Button();
                btn[i].Size = new Size(40, 40);
                if(i<10)
                {
                    btn[i].Text = i.ToString();
                }
                else
                {
                    btn[i].Text = ((char)('A' - 10 + i)).ToString();
                }
                btn[i].Location = new Point(70 + (i % 12) * 45, 150 + (i / 12) * 45);
                this.Controls.Add(btn[i]);
            }
        }
        private void start_Click(object sender, EventArgs e)
        {
            start.Enabled = false;
            stage = 1;
            start.Visible = false;
            createButton(sender, e);
            labelStage.Visible = true;
            labelTimer.Visible = true;
            labelStage.Text = "準備階段";
            mylist.Clear();
            for(int i=0;i<36;i++)
            {
                mylist.Add(i);
            }
            for(int i=0;i<3;i++)
            {
                int randomIndex = random.Next(0, mylist.Count);
                ans[i] = mylist[randomIndex];
                mylist.RemoveAt(randomIndex);
                btn[ans[i]].BackColor = Color.PaleGreen;
            }
            cur = 5;
            labelTimer.Text = cur.ToString();
            timer.Enabled = true; //開始看牌
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            cur--;
            labelTimer.Text = cur.ToString();
            if (cur==0)
            {
                timer.Enabled = false;
                if(stage==1) //看牌時間到
                {
                    btn[ans[0]].BackColor = btn[ans[1]].BackColor = btn[ans[2]].BackColor = Color.White;
                    stage = 2;
                    labelStage.Text = "玩家階段";
                    cur = 5;
                    labelTimer.Text = cur.ToString();
                    timer.Enabled = true;
                }
                else if(stage==2)
                {
                    stage = 3;
                    bool win = true;
                    for(int i=0;i<36;i++)
                    {
                        if (btn[i].BackColor == Color.PowderBlue && Array.IndexOf(ans, i) != -1)
                        {
                            btn[i].BackColor = Color.PaleGreen;
                        }
                        else if(btn[i].BackColor == Color.PowderBlue && Array.IndexOf(ans, i) == -1)
                        {
                            btn[i].BackColor = Color.Red;
                            win = false;
                        }
                        else if (btn[i].BackColor == Color.PowderBlue && Array.IndexOf(ans, i) != -1)
                        {
                            btn[i].BackColor = Color.Red;
                            win = false;
                        }
                    }
                    if(win)
                    {
                        MessageBox.Show("You Win!", "", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("You Lose!\nTry again!", "", MessageBoxButtons.OK);
                    }
                    for(int i=0;i<36;i++)
                    {
                        Controls.Remove(btn[i]);
                    }
                    Form1_Load(sender, e);
                }
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            tmp.Text = e.KeyValue.ToString();
            if(stage==2)
            {
                if (e.KeyValue >= 48 && e.KeyValue <= 57)
                {
                    btn[e.KeyValue - 48].BackColor = Color.PowderBlue;
                }
                else if(e.KeyValue >= 65 && e.KeyValue <= 90)
                {
                    btn[e.KeyValue - 55].BackColor = Color.PowderBlue;
                }
            }
        }
    }
}
