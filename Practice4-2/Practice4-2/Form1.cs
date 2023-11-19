using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice4_2
{
    public partial class Form1 : Form
    {
        int money, seed, fert, fruit, toolStatus = 0;
        bool[,] beenWater = new bool[4, 3];
        bool[,] beenFert = new bool[4, 3];
        Button[,] btn = new Button[4, 3];
        void update(object sender, EventArgs e)
        {
            haveMoney.Text = $"金錢:{money}";
            haveSeed.Text = $"擁有:{seed}";
            haveFert.Text = $"擁有:{fert}";
            haveFruit.Text = $"擁有:{fruit}";
        }
        void createButton(object sender, EventArgs e)
        {
            for(int i=0;i<4;i++)
            {
                for(int j=0;j<3;j++)
                {
                    btn[i, j] = new Button();
                    btn[i, j].Size = new Size(100, 100);
                    btn[i, j].ImageList = imgList;
                    btn[i, j].ImageIndex = 0;
                    btn[i, j].Location = new Point(j * 100, i * 100);
                    btn[i, j].Tag = $"{i}{j}";
                    btn[i, j].Click += Button_Click;
                    tabpgFarm.Controls.Add(btn[i, j]);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void toolWatercan_CheckedChanged(object sender, EventArgs e)
        {
            toolStatus = 1;
        }
        private void toolSeed_CheckedChanged(object sender, EventArgs e)
        {
            toolStatus = 2;
        }
        private void toolFert_CheckedChanged(object sender, EventArgs e)
        {
            toolStatus = 3;
        }
        private void toolSickle_CheckedChanged(object sender, EventArgs e)
        {
            toolStatus = 4;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //createButtonlist(sender, e);
            //tabpgFarm.Size = tabpgStore.Size = this.ClientSize;
            imgList.Images.Add(new Bitmap("img/dirt.jpeg"));
            imgList.Images.Add(new Bitmap("img/seed.jpg"));
            imgList.Images.Add(new Bitmap("img/crop.jpg"));
            imgList.Images.Add(new Bitmap("img/watermelon.jpg"));
            createButton(sender, e);
            money = 100;
            seed = 5;
            fert = 5;
            fruit = 0;
            update(sender, e);
            for(int i=0;i<4;i++)
            {
                for(int j=0;j<3;j++)
                {
                    beenFert[i, j] = beenWater[i, j] = false;
                }
            }
            buyFert.Checked = sellFruit.Checked = buySeed.Checked = false;
        }
        private void deal_Click(object sender, EventArgs e)
        {
            int newmoney = money;
            bool changeSeed = false, changeFert = false, changeFruit = false;
            if (sellFruit.Checked && fruit >= 1)
            {
                newmoney += 40;
                changeFruit = true;
            }
            if (buySeed.Checked && newmoney >= 10)
            {
                newmoney -= 10;
                changeSeed = true;
            }
            if (buyFert.Checked && newmoney >= 10)
            {
                newmoney -= 10;
                changeFert = true;
            }
            if(changeSeed)
            {
                money -= 10;
                seed++;
            }
            if(changeFert)
            {
                money -= 10;
                fert++;
            }
            if(changeFruit)
            {
                money += 40;
                fruit--;
            }
            if (changeSeed || changeFert || changeFruit)
            {
                update(sender, e);
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button cur = (Button)sender;
            int x = int.Parse(cur.Tag as string) / 10;
            int y = int.Parse(cur.Tag as string) % 10;
            if (toolStatus == 2)
            {
                if (btn[x, y].ImageIndex == 0)
                {
                    if(seed > 0)
                    {
                        btn[x, y].ImageIndex = 1;
                        seed--;
                    }
                    else
                    {
                        MessageBox.Show("種子用完了", "警告", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
            if(toolStatus == 1)
            {
                if ((btn[x, y].ImageIndex == 1 || btn[x, y].ImageIndex == 2) && !beenWater[x, y])
                {
                    beenWater[x,y] = true;
                    if (beenWater[x, y] && beenFert[x, y])
                    {
                        beenWater[x, y] = false;
                        beenFert[x, y] = false;
                        btn[x, y].ImageIndex++;
                    }
                }
            }
            if(toolStatus == 3)
            {
                if((btn[x, y].ImageIndex == 1 || btn[x, y].ImageIndex == 2) && !beenFert[x, y])
                {
                    if(fert > 0)
                    {
                        beenFert[x, y] = true;
                        fert--;
                        if (beenWater[x, y] && beenFert[x, y])
                        {
                            beenWater[x, y] = false;
                            beenFert[x, y] = false;
                            btn[x, y].ImageIndex++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("肥料用完了", "警告", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
            if(toolStatus == 4 && btn[x, y].ImageIndex == 3)
            {
                fruit++;
                btn[x, y].ImageIndex = 0;
            }
            update(sender, e);
        }

    }
}
