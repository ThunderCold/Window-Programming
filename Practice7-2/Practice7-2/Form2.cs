using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice7_2
{
    public partial class Form2 : Form
    {
        Form1 form1 = new Form1();
        List<Form1.Word> word;
        int cur;
        bool openold;
        string filePath;
        Random random = new Random();
        public Form2()
        {
            InitializeComponent();
        }
        public void trans1to2(List<Form1.Word> x, System.Drawing.Font y, bool old, string path)
        {
            word = x;
            lblAttr.Font = lblEn.Font = lblZh.Font = y;
            openold = old;
            filePath = path;
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            lblEn.Text = lblZh.Text = lblAttr.Text = "";
            lblEn.Location = new Point(60, 60);
            lblZh.Location = new Point(60, 130);
            lblAttr.Location = new Point(60, 200);
            chkboxMark.Location = new Point(480, 150);
            lblMark.Location = new Point(530, 146);
            btnView.Location = new Point(490, 210);
            btnNext.Location = new Point(490, 270);
            if (word.Count > 0)
            {
                cur = random.Next(0, word.Count);
                lblEn.Text = $"單字: {word[cur].en.ToString()}";
                lblZh.Text = $"中文: {word[cur].zh.ToString()}";
                lblAttr.Text = $"詞性: {word[cur].attr.ToString()}";
                lblZh.Visible = lblAttr.Visible = false;
                chkboxMark.Checked = word[cur].marked;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            lblZh.Visible = lblAttr.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            word[cur].marked = chkboxMark.Checked;
            form1.trans2to1(word, openold, filePath);
            Form2_Shown(sender, e);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.trans2to1(word, openold, filePath);
            form1.Show();
        }
    }
}
