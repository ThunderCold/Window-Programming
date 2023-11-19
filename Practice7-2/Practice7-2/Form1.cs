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

namespace Practice7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Word
        {
            public string en;
            public string zh;
            public string attr;
            public bool marked = false;
        };
        List<Word> word = new List<Word>();
        int stage;
        bool openold, onlymark, firstLoad = true;
        bool findx, findy, findz;
        string filePath, cur;
        private void init(object sender, EventArgs e)
        {
            //word.Clear();
            新增單字ToolStripMenuItem.Text = "新增單字";
            搜尋單字ToolStripMenuItem.Text = "搜尋單字";
            lbl1.Visible = lbl2.Visible = lbl3.Visible = txtbox1.Visible = txtbox2.Visible = combobox3.Visible = chkbox1.Visible = chkbox2.Visible = chkbox3.Visible = btnEnter.Visible = false;
            lbl1.Location = new Point(500, 50);
            txtbox1.Location = new Point(500, 80);
            chkbox1.Location = new Point(470, 87);
            lbl2.Location = new Point(500, 130);
            txtbox2.Location = new Point(500, 160);
            chkbox2.Location = new Point(470, 167);
            lbl3.Location = new Point(500, 210);
            combobox3.Location = new Point(500, 240);
            chkbox3.Location = new Point(470, 247);
            btnEnter.Location = new Point(530, 297);
            lblWord.Text = "";
            lblWord.Location = new Point(15, 40);
            vScrollBar1.Location = new Point(380, 40);
            stage = 0;
            openold = onlymark = false;
            findx = findy = findz = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(700, 400);
            init(sender, e);
            saveFileDialog1.Filter = "Todo File(*.todo)|*.todo|Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
            openFileDialog1.Filter = "Todo File(*.todo)|*.todo|Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
        }
        private void showword(bool x, bool y, bool z, bool m)
        {
            cur = "";
            List<Word> toShow = new List<Word>();
            foreach (Word i in word)
            {
                if ((i.en == txtbox1.Text || x) && (i.zh == txtbox2.Text || y) && (i.attr == combobox3.Text || z) && (i.marked || !m))
                {
                    cur += (i.en + " " + i.zh + " " + i.attr + "\n");
                }
            }
            string[] curArr = cur.Split('\n');
            if (curArr.Length - 1 <= 16)
            {
                vScrollBar1.Value = vScrollBar1.Maximum = 0;
                lblWord.Text = cur;
            }
            else
            {
                vScrollBar1.Maximum = curArr.Length - 1 - 16;
                string cur2 = "";
                for (int i = vScrollBar1.Value; i < vScrollBar1.Value + 16; i++)
                {
                    cur2 += (word[i].en + " " + word[i].zh + " " + word[i].attr + "\n");
                }
                lblWord.Text = cur2;
            }
        }

        private void 新增單字ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stage != 1)
            {
                showword(true, true, true, onlymark);
                stage = 1;
                搜尋單字ToolStripMenuItem.Text = "搜尋單字";
                新增單字ToolStripMenuItem.Text = "新增單字(v)";
                btnEnter.Text = "新增";
                txtbox1.Text = txtbox2.Text = combobox3.Text = "";
                lbl1.Visible = lbl2.Visible = lbl3.Visible = txtbox1.Visible = txtbox2.Visible = combobox3.Visible = btnEnter.Visible = true;
                chkbox1.Visible = chkbox2.Visible = chkbox3.Visible = false;
            }
            else
            {
                stage = 0;
                新增單字ToolStripMenuItem.Text = "新增單字";
                lbl1.Visible = lbl2.Visible = lbl3.Visible = txtbox1.Visible = txtbox2.Visible = combobox3.Visible = btnEnter.Visible = false;
            }
        }

        private void 搜尋單字ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stage != 2)
            {
                stage = 2;
                搜尋單字ToolStripMenuItem.Text = "搜尋單字(v)";
                新增單字ToolStripMenuItem.Text = "新增單字";
                btnEnter.Text = "搜尋";
                chkbox1.Checked = chkbox2.Checked = chkbox3.Checked = false;
                txtbox1.Text = txtbox2.Text = combobox3.Text = "";
                lbl1.Visible = lbl2.Visible = lbl3.Visible = txtbox1.Visible = txtbox2.Visible = combobox3.Visible = btnEnter.Visible = chkbox1.Visible = chkbox2.Visible = chkbox3.Visible = true;
                findx = findy = findz = false;
            }
            else
            {
                showword(true, true, true, onlymark);
                stage = 0;
                搜尋單字ToolStripMenuItem.Text = "搜尋單字";
                lbl1.Visible = lbl2.Visible = lbl3.Visible = txtbox1.Visible = txtbox2.Visible = combobox3.Visible = btnEnter.Visible = chkbox1.Visible = chkbox2.Visible = chkbox3.Visible = false;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (stage == 1)
            {
                if (txtbox1.Text != "" && txtbox2.Text != "" && combobox3.Text != "")
                {
                    word.Add(new Word { en = txtbox1.Text, zh = txtbox2.Text, attr = combobox3.Text });
                    showword(true, true, true, onlymark);
                    //lblWord.Text += (txtbox1.Text + " " + txtbox2.Text + " " + combobox3.Text + "\n");
                    txtbox1.Text = txtbox2.Text = combobox3.Text = "";
                }
            }
            else if (stage == 2)
            {
                findx = chkbox1.Checked;
                findy = chkbox2.Checked;
                findz = chkbox3.Checked;
                showword(!findx, !findy, !findz, onlymark);
            }
        }

        private void 儲存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string toSave = "";
            if (onlymark)
            {
                MessageBox.Show("目前只會存取被標記的單字喔!", "通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach(Word i in word)
                {
                    if(i.marked)
                    {
                        toSave += $"{i.zh} {i.en} {i.attr}\n";
                    }
                }
            }
            else
            {
                foreach (Word i in word)
                {
                    toSave += $"{i.zh} {i.en} {i.attr}\n";
                }
            }
            if (openold)
            {
                File.WriteAllText(filePath, toSave);
            }
            else
            {
                lbl1.Visible = lbl2.Visible = lbl3.Visible = txtbox1.Visible = txtbox2.Visible = combobox3.Visible = chkbox1.Visible = chkbox2.Visible = chkbox3.Visible = btnEnter.Visible = false;
                stage = 0;
                新增單字ToolStripMenuItem.Text = "新增單字";
                搜尋單字ToolStripMenuItem.Text = "搜尋單字";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, toSave);
                }
            }
        }

        private void 另存新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string toSave = "";
            if (onlymark)
            {
                MessageBox.Show("目前只會存取被標記的單字喔!", "通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (Word i in word)
                {
                    if (i.marked)
                    {
                        toSave += $"{i.zh} {i.en} {i.attr}\n";
                    }
                }
            }
            else
            {
                foreach (Word i in word)
                {
                    toSave += $"{i.zh} {i.en} {i.attr}\n";
                }
            }
            lbl1.Visible = lbl2.Visible = lbl3.Visible = txtbox1.Visible = txtbox2.Visible = combobox3.Visible = chkbox1.Visible = chkbox2.Visible = chkbox3.Visible = btnEnter.Visible = false;
            stage = 0;
            新增單字ToolStripMenuItem.Text = "新增單字";
            搜尋單字ToolStripMenuItem.Text = "搜尋單字";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openold = true;
                filePath = saveFileDialog1.FileName;
                File.WriteAllText(filePath, toSave);
            }
        }

        private void 開啟舊檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "開啟";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                try
                {
                    openold = true;
                    string fileContent = File.ReadAllText(filePath);
                    //lblWord.Text = fileContent;
                    word.Clear();
                    string[] lines = File.ReadAllLines(filePath);
                    foreach (string line in lines)
                    {
                        string[] curline = line.Split(' ');
                        word.Add(new Word { en = curline[0], zh = curline[1], attr = curline[2] });
                    }
                    showword(true, true, true, onlymark);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("讀取文件時發生錯誤" + ex.Message);
                }
            }
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            init(sender, e);
            word.Clear();
        }

        private void 字型大小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                lblWord.Font = fontDialog1.Font;
            }
        }

        private void 離開ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 單字測驗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.trans1to2(word, lblWord.Font, openold, filePath);
            this.Hide();
            form2.Show();
        }
        public void trans2to1(List<Form1.Word> x, bool old, string path)
        {
            word = x;
            openold = old;
            filePath = path;
        }

        private void 只顯示標記單字ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(onlymark)
            {
                只顯示標記單字ToolStripMenuItem.Text = "只顯示標記單字";
                onlymark = false;
                if (stage == 0 || stage == 1)
                {
                    showword(true, true, true, onlymark);
                }
                else
                {
                    showword(!findx, !findy, !findz, onlymark);
                }
            }
            else
            {
                只顯示標記單字ToolStripMenuItem.Text = "只顯示標記單字(v)";
                onlymark = true;
                if (stage == 0 || stage == 1)
                {
                    showword(true, true, true, onlymark);
                }
                else
                {
                    showword(!findx, !findy, !findz, onlymark);
                }
            }
        }

        private void 清除標記ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Word i in word)
            {
                i.marked = false;
            }
            if (stage == 0 || stage == 1)
            {
                showword(true, true, true, onlymark);
            }
            else
            {
                showword(!findx, !findy, !findz, onlymark);
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (stage == 0 || stage == 1)
            {
                showword(true, true, true, onlymark);
            }
            else
            {
                showword(!findx, !findy, !findz, onlymark);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            新增單字ToolStripMenuItem.Text = "新增單字";
            搜尋單字ToolStripMenuItem.Text = "搜尋單字";
            lbl1.Visible = lbl2.Visible = lbl3.Visible = txtbox1.Visible = txtbox2.Visible = combobox3.Visible = chkbox1.Visible = chkbox2.Visible = chkbox3.Visible = btnEnter.Visible = false;
            stage = 0;
            lblWord.Visible = true;
            showword(true, true, true, onlymark);
        }
    }
}
