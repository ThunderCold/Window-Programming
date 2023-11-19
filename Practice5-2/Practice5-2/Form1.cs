using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice5_2
{
    public partial class Form1 : Form
    {
        class Servant
        {
            public string character;
            public int hp;
            public int charge;
            public int atk;
            public int speed;
            public int skillcd;
            public virtual void skill() { }
        }
        class Saber : Servant
        {
            public Saber()
            {
                character = "Saber";
                hp = 100;
                charge = 0;
                atk = 3;
                speed = 1;
                skillcd = 0;
            }
            public override void skill()
            {
                atk *= 2;
            }
        }
        class Caster : Servant
        {
            public Caster()
            {
                character = "Caster";
                hp = 100;
                charge = 0;
                atk = 2;
                speed = 2;
                skillcd = 0;
            }
            public override void skill()
            {
                hp = hp + hp / 2;
            }
        }
        class Berserker : Servant
        {
            public Berserker()
            {
                character = "Berserker";
                hp = 100;
                charge = 0;
                atk = 4;
                speed = 4;
                skillcd = 0;
            }
            public override void skill()
            {
                atk *= 2;
                hp = hp - hp / 2;
            }
        }
        class Beast : Servant
        {
            public Beast()
            {
                character = "Beast";
                hp = 500;
                charge = 0;
                atk = 2;
                speed = 3;
                skillcd = 0;
            }
            public override void skill()
            {
                atk += 2;
            }
        }
        Random random = new Random();
        int stage, curtime, chosenBerserker, chosenSaber, chosenCaster, curTurn, beastno;
        Servant[] servant = new Servant[3];
        bool[] lose = new bool[3];
        int losecnt;
        //(int speed, int no)[] order = new (int, int)[3];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(700, 400);
            btnStart.Location = new Point(286, 285);
            btnStart.Visible = true;
            btnStart.Enabled = true;
            btnBerserker.Visible = btnCaster.Visible = btnSaber.Visible = btnAD.Visible = btnAP.Visible = btnULT.Visible = false;
            btnBerserker.Enabled = btnCaster.Enabled = btnSaber.Enabled = btnAD.Enabled = btnAP.Enabled = btnULT.Enabled = false;
            lblStage.Visible = lblCountdown.Visible = myAtk.Visible = myChar.Visible = myCharge.Visible = myHP.Visible = comAtk.Visible = comChar.Visible = comCharge.Visible = comHP.Visible = lblTurn.Visible = false;
            lblStage.Size = lblCountdown.Size = lblTurn.Size = new Size(120, 25);
            lblStage.Location = new Point(283, 28);
            lblCountdown.Location = new Point(283, 76);
            lblTurn.Location = new Point(283, 330);
            stage = 0;
        }
        public void beast(object sender, EventArgs e)
        {
            servant[curTurn].skillcd++;
            if (servant[curTurn].skillcd >= 4) //技能
            {
                servant[curTurn].skill();
                MessageBox.Show($"Beast使用了技能\n當前傷害: {servant[curTurn].atk}", "", MessageBoxButtons.OK);
                servant[curTurn].skillcd = 0;
            }
            if (servant[curTurn].charge >= 100) //寶具
            {
                MessageBox.Show($"Beast使用了寶具\n對全體隊友造成{servant[curTurn].atk * 2}點傷害!", "", MessageBoxButtons.OK);
                if (servant[0].character != "Beast")
                {
                    servant[0].hp -= servant[curTurn].atk * 2;
                }
                if (servant[1].character != "Beast")
                {
                    servant[1].hp -= servant[curTurn].atk * 2;
                }
                if (servant[2].character != "Beast")
                {
                    servant[2].hp -= servant[curTurn].atk * 2;
                }
                servant[curTurn].charge -= 100;
            }
            else //普攻
            {
                MessageBox.Show($"Beast對全體隊友造成{servant[curTurn].atk}點傷害!", "", MessageBoxButtons.OK);
                if (servant[0].character != "Beast")
                {
                    servant[0].hp -= servant[curTurn].atk;
                }
                if (servant[1].character != "Beast")
                {
                    servant[1].hp -= servant[curTurn].atk;
                }
                if (servant[2].character != "Beast")
                {
                    servant[2].hp -= servant[curTurn].atk;
                }
                servant[curTurn].charge += 20;
            }
            update(sender, e);
            change(sender, e);
        }
        private void ult()
        {
            string s = servant[curTurn].character;
            if(s=="Saber")
            {
                servant[beastno].hp -= (servant[curTurn].atk + 25);
                servant[curTurn].hp += 5;
                MessageBox.Show($"Saber使用了寶具:\n對Beast造成{servant[curTurn].atk + 25}點傷害並回復5點血量", "", MessageBoxButtons.OK);
            }
            else if(s=="Caster")
            {
                if (servant[0].character != "Beast")
                {
                    servant[0].atk += 1;
                    servant[0].hp += 10;
                }
                if (servant[1].character != "Beast")
                {
                    servant[1].atk += 1;
                    servant[1].hp += 10;
                }
                if (servant[2].character != "Beast")
                {
                    servant[2].atk += 1;
                    servant[2].hp += 10;
                }
                MessageBox.Show($"Caster使用了寶具:\n全體隊友加1點攻擊、回復10點血量", "", MessageBoxButtons.OK);
            }
            else if(s=="Berserker")
            {
                servant[beastno].hp -= (servant[curTurn].atk + 50);
                MessageBox.Show($"Berserker使用了寶具:\n對Beast造成{servant[curTurn].atk + 50}點傷害", "", MessageBoxButtons.OK);
            }
            servant[curTurn].charge -= 100;
        }
        private void update(object sender, EventArgs e)
        {
            if (curTurn == beastno)
            {
                myChar.Text = servant[(curTurn - 1) % 3].character;
                myHP.Text = $"HP: {servant[(curTurn - 1) % 3].hp.ToString()}";
                myCharge.Text = $"Charge: {servant[(curTurn - 1) % 3].charge.ToString()}%";
                myAtk.Text = $"Attack: {servant[(curTurn - 1) % 3].atk.ToString()}";
            }
            else
            {
                myChar.Text = servant[curTurn].character;
                myHP.Text = $"HP: {servant[curTurn].hp.ToString()}";
                myCharge.Text = $"Charge: {servant[curTurn].charge.ToString()}%";
                myAtk.Text = $"Attack: {servant[curTurn].atk.ToString()}";
            }
            comChar.Text = servant[beastno].character;
            comHP.Text = $"HP: {servant[beastno].hp.ToString()}";
            comCharge.Text = $"Charge: {servant[beastno].charge.ToString()}%";
            comAtk.Text = $"Attack: {servant[beastno].atk.ToString()}";
        }
        private void change(object sender, EventArgs e)
        {
            for(int i=0;i<3;i++)
            {
                if (servant[i].hp <= 0)
                {
                    if (servant[i].character == "Beast")
                    {
                        lose[i] = true;
                    }
                    else if (servant[i].character == "Saber" && !lose[i])
                    {
                        lose[i] = true;
                        losecnt++;
                        MessageBox.Show("Saber倒下了", "", MessageBoxButtons.OK);
                    }
                    else if (servant[i].character == "Caster" && !lose[i])
                    {
                        lose[i] = true;
                        losecnt++;
                        MessageBox.Show("Caster倒下了", "", MessageBoxButtons.OK);
                    }
                    else if (servant[i].character == "Berserker" && !lose[i])
                    {
                        lose[i] = true;
                        losecnt++;
                        MessageBox.Show("Berserker倒下了", "", MessageBoxButtons.OK);
                    }
                }
            }
            if (lose[beastno]) //WIN
            {
                timer2.Enabled = false;
                MessageBox.Show($"You Win!\n通關時間: {curtime}", "", MessageBoxButtons.OK);
                Form1_Load(sender, e);
            }
            else if (losecnt >= 2) //LOSE
            {
                timer2.Enabled = false;
                MessageBox.Show($"You Lose\n戰鬥時間: {curtime}", "", MessageBoxButtons.OK);
                Form1_Load(sender, e);
            }
            else
            {
                curTurn = (curTurn + 1) % 3;
                if (lose[curTurn])
                {
                    curTurn = (curTurn + 1) % 3;
                }
                lblTurn.Text = $"{servant[curTurn].character} turn";
                if (curTurn == beastno)
                {
                    update(sender, e);
                    beast(sender, e);
                }
                else
                {
                    update(sender, e);
                    servant[curTurn].skillcd++;
                }
            }
        }
        private void btnAD_Click(object sender, EventArgs e)
        {
            if (random.Next(1, 3) == 1)
            {
                servant[beastno].hp -= servant[curTurn].atk;
                servant[curTurn].charge += random.Next(20, 26);
                //update(sender, e);
                //System.Threading.Thread.Sleep(1000);
            }
            else
            {
                servant[beastno].hp -= servant[curTurn].atk * 2;
                servant[curTurn].charge += 30;
                MessageBox.Show($"對Beast造成了{servant[curTurn].atk * 2}點爆擊傷害", "", MessageBoxButtons.OK);
            }
            change(sender, e);
        }
        private void btnAP_Click(object sender, EventArgs e)
        {
            if (servant[curTurn].skillcd < 3)
            {
                //MessageBox.Show($"{curTurn} {servant[curTurn].skillcd}", "", MessageBoxButtons.OK);
                MessageBox.Show($"技能冷卻中(剩餘回合:{3 - servant[curTurn].skillcd})", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                servant[curTurn].skill();
                servant[curTurn].skillcd = 0;
                MessageBox.Show($"{servant[curTurn].character}使用了技能", "", MessageBoxButtons.OK);
                update(sender, e);
            }
        }

        private void btnULT_Click(object sender, EventArgs e)
        {
            if (servant[curTurn].charge >= 100)
            {
                ult();
            }
            else
            {
                MessageBox.Show("充能不足，無法施放寶具!", "", MessageBoxButtons.OK);
                return;
            }
            change(sender, e);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            btnStart.Enabled = false;
            stage = 1;
            curtime = 10;
            chosenBerserker = chosenCaster = chosenSaber = 0;
            btnBerserker.BackColor = btnCaster.BackColor = btnSaber.BackColor = Color.White;
            btnBerserker.Size = btnCaster.Size = btnSaber.Size = new Size(108, 35);
            btnAD.Size = btnAP.Size = btnULT.Size = new Size(88, 35);
            btnBerserker.Location = new Point(89, 258);
            btnSaber.Location = new Point(289, 258);
            btnCaster.Location = new Point(489, 258);
            btnAD.Location = new Point(198, 258);
            btnAP.Location = new Point(298, 258);
            btnULT.Location = new Point(398, 258);
            btnBerserker.Visible = btnCaster.Visible = btnSaber.Visible = true;
            btnBerserker.Enabled = btnCaster.Enabled = btnSaber.Enabled = true;
            lblStage.Visible = lblCountdown.Visible = true;
            lblCountdown.Text = curtime.ToString();
            lblStage.Text = "準備階段";
            myChar.Location = new Point(10, 80);
            myHP.Location = new Point(10, 150);
            myCharge.Location = new Point(10, 220);
            myAtk.Location = new Point(10, 290);
            myChar.Size = myHP.Size = myAtk.Size = myCharge.Size = new Size(110, 25);
            comChar.Location = new Point(563, 80);
            comHP.Location = new Point(563, 150);
            comCharge.Location = new Point(563, 220);
            comAtk.Location = new Point(563, 290);
            comChar.Size = comHP.Size = comAtk.Size = comCharge.Size = new Size(110, 25);
            lose[0] = lose[1] = lose[2] = false;
            losecnt = 0;
            timer1.Enabled = true;
        }
        private void btnBerserker_Click(object sender, EventArgs e)
        {
            if (stage == 1)
            {
                if (chosenBerserker == 0)
                {
                    if (chosenBerserker + chosenCaster + chosenSaber >= 2)
                    {
                        MessageBox.Show("只能選兩個Servant!", "", MessageBoxButtons.OK);
                    }
                    else
                    {
                        btnBerserker.BackColor = Color.PaleGreen;
                        chosenBerserker = 1;
                    }
                }
                else
                {
                    btnBerserker.BackColor = Color.White;
                    chosenBerserker = 0;
                }
            }
        }
        private void btnSaber_Click(object sender, EventArgs e)
        {
            if (stage == 1)
            {
                if (chosenSaber == 0)
                {
                    if (chosenBerserker + chosenCaster + chosenSaber >= 2)
                    {
                        MessageBox.Show("只能選兩個Servant!", "", MessageBoxButtons.OK);
                    }
                    else
                    {
                        btnSaber.BackColor = Color.PaleGreen;
                        chosenSaber = 1;
                    }
                }
                else
                {
                    btnSaber.BackColor = Color.White;
                    chosenSaber = 0;
                }
            }
        }
        private void btnCaster_Click(object sender, EventArgs e)
        {
            if (stage == 1)
            {
                if (chosenCaster == 0)
                {
                    if (chosenBerserker + chosenCaster + chosenSaber >= 2)
                    {
                        MessageBox.Show("只能選兩個Servant!", "", MessageBoxButtons.OK);
                    }
                    else
                    {
                        btnCaster.BackColor = Color.PaleGreen;
                        chosenCaster = 1;
                    }
                }
                else
                {
                    btnCaster.BackColor = Color.White;
                    chosenCaster = 0;
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            curtime--;
            lblCountdown.Text = curtime.ToString();
            if (curtime==0)
            {
                if(stage == 1)
                {
                    /*servant[0] = new Servant();
                    servant[1] = new Servant();
                    servant[2] = new Servant();*/
                    timer1.Enabled = false;
                    if (chosenBerserker + chosenCaster + chosenSaber == 0)
                    {
                        chosenBerserker = chosenSaber = 1;
                        btnBerserker.BackColor = btnSaber.BackColor = Color.PaleGreen;
                    }
                    else if (chosenBerserker == 1 && chosenCaster + chosenSaber == 0)
                    {
                        chosenSaber = 1;
                        btnSaber.BackColor = Color.PaleGreen;
                    }
                    else if (chosenBerserker + chosenCaster + chosenSaber == 1)
                    {
                        chosenBerserker = 1;
                        btnBerserker.BackColor = Color.PaleGreen;
                    }
                    if (chosenBerserker == 0)
                    {
                        servant[0] = new Saber();
                        servant[1] = new Caster();
                        servant[2] = new Beast();
                        servant[0].character = "Saber";
                        servant[0].hp = 100;
                        servant[0].charge = 0;
                        servant[0].atk = 3;
                        servant[0].speed = 1;
                        servant[1].character = "Caster";
                        servant[1].hp = 100;
                        servant[1].charge = 0;
                        servant[1].atk = 2;
                        servant[1].speed = 2;
                        servant[2].character = "Beast";
                        servant[2].hp = 500;
                        servant[2].charge = 0;
                        servant[2].atk = 2;
                        servant[2].speed = 3;
                    }
                    else if (chosenSaber == 0)
                    {
                        servant[0] = new Caster();
                        servant[1] = new Beast();
                        servant[2] = new Berserker();
                        servant[0].character = "Caster";
                        servant[0].hp = 100;
                        servant[0].charge = 0;
                        servant[0].atk = 2;
                        servant[0].speed = 2;
                        servant[1].character = "Beast";
                        servant[1].hp = 500;
                        servant[1].charge = 0;
                        servant[1].atk = 2;
                        servant[1].speed = 3;
                        servant[2].character = "Berserker";
                        servant[2].hp = 100;
                        servant[2].charge = 0;
                        servant[2].atk = 4;
                        servant[2].speed = 4;
                    }
                    else
                    {
                        servant[0] = new Saber();
                        servant[1] = new Beast();
                        servant[2] = new Berserker();
                        servant[0].character = "Saber";
                        servant[0].hp = 100;
                        servant[0].charge = 0;
                        servant[0].atk = 3;
                        servant[0].speed = 1;
                        servant[1].character = "Beast";
                        servant[1].hp = 500;
                        servant[1].charge = 0;
                        servant[1].atk = 2;
                        servant[1].speed = 3;
                        servant[2].character = "Berserker";
                        servant[2].hp = 100;
                        servant[2].charge = 0;
                        servant[2].atk = 4;
                        servant[2].speed = 4;
                    }
                    /*order[0] = (servant[0].speed, 0);
                    order[1] = (servant[1].speed, 1);
                    order[2] = (servant[2].speed, 2);
                    order = order.OrderBy(item => item.speed).ToArray();*/
                    stage = 2;
                    lblStage.Text = "時間";
                    btnAD.Visible = btnAP.Visible = btnULT.Visible = myAtk.Visible = myChar.Visible = myCharge.Visible = myHP.Visible = comAtk.Visible = comChar.Visible = comCharge.Visible = comHP.Visible = lblTurn.Visible = true;
                    if (servant[0].character == "Beast") //準備開始
                    {
                        beastno = 0;
                        myChar.Text = servant[1].character;
                        myHP.Text = $"HP: {servant[1].hp.ToString()}";
                        myCharge.Text = $"Charge: {servant[1].charge.ToString()}%";
                        myAtk.Text = $"Attack: {servant[1].atk.ToString()}";
                        comChar.Text = servant[0].character;
                        comHP.Text = $"HP: {servant[0].hp.ToString()}";
                        comCharge.Text = $"Charge: {servant[0].charge.ToString()}%";
                        comAtk.Text = $"Attack: {servant[0].atk.ToString()}";
                    }
                    else if (servant[1].character == "Beast")
                    {
                        beastno = 1;
                        myChar.Text = servant[0].character;
                        myHP.Text = $"HP: {servant[0].hp.ToString()}";
                        myCharge.Text = $"Charge: {servant[0].charge.ToString()}%";
                        myAtk.Text = $"Attack: {servant[0].atk.ToString()}";
                        comChar.Text = servant[1].character;
                        comHP.Text = $"HP: {servant[1].hp.ToString()}";
                        comCharge.Text = $"Charge: {servant[1].charge.ToString()}%";
                        comAtk.Text = $"Attack: {servant[1].atk.ToString()}";
                    }
                    else
                    {
                        beastno = 2;
                        myChar.Text = servant[0].character;
                        myHP.Text = $"HP: {servant[0].hp.ToString()}";
                        myCharge.Text = $"Charge: {servant[0].charge.ToString()}%";
                        myAtk.Text = $"Attack: {servant[0].atk.ToString()}";
                        comChar.Text = servant[2].character;
                        comHP.Text = $"HP: {servant[2].hp.ToString()}";
                        comCharge.Text = $"Charge: {servant[2].charge.ToString()}%";
                        comAtk.Text = $"Attack: {servant[2].atk.ToString()}";
                    }
                    curTurn = -1;
                    curtime = 0;
                    btnBerserker.Visible = btnCaster.Visible = btnSaber.Visible = false;
                    btnBerserker.Enabled = btnCaster.Enabled = btnSaber.Enabled = false;
                    btnAD.Visible = btnAP.Visible = btnULT.Visible = true;
                    btnAD.Enabled = btnAP.Enabled = btnULT.Enabled = true;
                    myAtk.Visible = myChar.Visible = myCharge.Visible = myHP.Visible = comAtk.Visible = comChar.Visible = comCharge.Visible = comHP.Visible = lblTurn.Visible = true;
                    servant[0].skillcd = servant[1].skillcd = servant[2].skillcd = 0;
                    timer2.Enabled = true;
                    change(sender, e);
                }
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            curtime++;
            lblCountdown.Text = curtime.ToString();
        }
    }
}
