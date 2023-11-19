using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int status = 1, rdom;
        String[] analysisArr = { "桃花運大漲", "家庭遭逢變故", "事業平步青雲，有升官可能", "事業起伏大", "親人病情好轉", "被財神眷顧", "近期一帆風順" };

        String[] suggestArr = { "少做壞事，夜路走多了總匯三明治",
                     "保持謙虛，一山還有一山高，雞蛋還有雞蛋糕",
                     "善待他人，不要任意嘲笑別人，除非你忍不住",
                     "早點睡覺，不要仗著自己長得醜，就任意熬夜",
                     "小心小人，可謂浮雲能蔽日，輕舟已過萬重山",
                     "不要偷懶，你在睡覺的時候，美國人還在上班阿",
                     "健康第一，定期身體檢查並謹記醫生怎麼說，doctor!",
                     "穩定情緒，今天不開心沒關係，反正明天也不會開心"};
        int[] day = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        Random random = new Random();

        public void status1(object sender, EventArgs e)
        {
            label1.Location = new Point(340, 10);
            labelName.Location = new Point(120, 80);
            labelGender.Location = new Point(120, 140);
            labelBirth.Location = new Point(120, 200);
            labelDate.Location = new Point(120, 260);
            labelCatdog.Location = new Point(120, 320);
            txtboxName.Location = new Point(250, 80);
            txtboxGender.Location = new Point(250, 140);
            txtboxBirth.Location = new Point(250, 200);
            txtboxDate.Location = new Point(250, 260);
            txtboxCatdog.Location = new Point(250, 320);
            errorName.Location = new Point(580, 80);
            errorGender.Location = new Point(580, 140);
            errorBirth.Location = new Point(580, 200);
            errorDate.Location = new Point(580, 260);
            errorCatdog.Location = new Point(580, 320);
            btonEnter.Location = new Point(250, 420);
            txtboxName.Visible = txtboxGender.Visible = txtboxBirth.Visible = txtboxDate.Visible = txtboxCatdog.Visible = errorBirth.Visible = errorCatdog.Visible = errorDate.Visible = errorGender.Visible = errorName.Visible = true;
            ansBirth.Visible = ansCatdog.Visible = ansDate.Visible = ansGender.Visible = ansName.Visible = fortune.Visible = suggestion.Visible = false;
            label1.Text = "資料輸入";
            labelName.Text = "姓名";
            labelGender.Text = "性別";
            labelBirth.Text = "出生年月日";
            labelDate.Text = "今日日期";
            labelCatdog.Text = "貓派or狗派";
            txtboxBirth.Text = txtboxCatdog.Text = txtboxDate.Text = txtboxGender.Text = txtboxName.Text = errorBirth.Text = errorCatdog.Text = errorDate.Text = errorGender.Text = errorName.Text = ansBirth.Text = ansCatdog.Text = ansDate.Text = ansGender.Text = ansName.Text = fortune.Text = suggestion.Text = "";
            btonEnter.Text = "AI大神請告訴我答案吧";
        }

        public void status2(object sender, EventArgs e)
        {
            label1.Location = new Point(340, 10);
            labelName.Location = new Point(220, 60);
            labelGender.Location = new Point(510, 60);
            labelBirth.Location = new Point(70, 120);
            labelDate.Location = new Point(370, 120);
            labelCatdog.Location = new Point(640, 120);
            ansName.Location = new Point(220, 90);
            ansGender.Location = new Point(510, 90);
            ansBirth.Location = new Point(70, 150);
            ansDate.Location = new Point(370, 150);
            ansCatdog.Location = new Point(640, 150);
            fortune.Location = new Point(100, 260);
            suggestion.Location = new Point(100, 320);
            ansName.Text = txtboxName.Text;
            ansGender.Text = txtboxGender.Text;
            ansBirth.Text = txtboxBirth.Text;
            ansDate.Text = txtboxDate.Text;
            ansCatdog.Text = txtboxCatdog.Text;
            label1.Text = "神諭時刻";
            txtboxName.Visible = txtboxGender.Visible = txtboxBirth.Visible = txtboxDate.Visible = txtboxCatdog.Visible = errorBirth.Visible = errorCatdog.Visible = errorDate.Visible = errorGender.Visible = errorName.Visible = false;
            ansBirth.Visible = ansCatdog.Visible = ansDate.Visible = ansGender.Visible = ansName.Visible = fortune.Visible = suggestion.Visible = true;
            btonEnter.Text = "來，下面一位~";
            rdom = random.Next(0, 7);
            fortune.Text = $"運勢:{analysisArr[rdom]}";
            rdom = random.Next(0, 8);
            suggestion.Text = $"建議:{suggestArr[rdom]}";
            fortune.Size = new Size(700, 30);
            suggestion.Size = new Size(700, 30);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            status1(sender, e);
        }

        private void btonEnter_Click(object sender, EventArgs e)
        {
            if(status==1)
            {
                bool ok = true;
                if (txtboxName.Text == "")
                {
                    ok = false;
                    errorName.Text = "此欄未填寫";
                }
                else
                {
                    errorName.Text = "";
                }
                if (txtboxGender.Text == "")
                {
                    ok = false;
                    errorGender.Text = "此欄未填寫";
                }
                else if (txtboxGender.Text != "男" && txtboxGender.Text != "女")
                {
                    ok = false;
                    errorGender.Text = "輸入應為男or女";
                }
                else
                {
                    errorGender.Text = "";
                }
                if (txtboxBirth.Text == "")
                {
                    ok = false;
                    errorBirth.Text = "此欄未填寫";
                }
                else if(txtboxBirth.Text.Contains("/"))
                {
                    string[] birth = txtboxBirth.Text.Split('/');
                    if (int.Parse(birth[0]) < 0 || int.Parse(birth[0]) > 2023 || int.Parse(birth[1]) < 1 || int.Parse(birth[1]) > 12 || int.Parse(birth[2]) < 1 || int.Parse(birth[2]) > day[int.Parse(birth[1])])
                    {
                        ok = false;
                        errorBirth.Text = "請確認日期填寫是否正確";
                    }
                    else
                    {
                        errorBirth.Text = "";
                    }
                }
                else
                {
                    errorBirth.Text = "";
                }
                if (txtboxDate.Text == "")
                {
                    ok = false;
                    errorDate.Text = "此欄未填寫";
                }
                else if (txtboxDate.Text.Contains("/"))
                {
                    string[] date = txtboxDate.Text.Split('/');
                    if (int.Parse(date[0]) < 0 || int.Parse(date[0]) > 9999 || int.Parse(date[1]) < 1 || int.Parse(date[1]) > 12 || int.Parse(date[2]) < 1 || int.Parse(date[2]) > day[int.Parse(date[1])])
                    {
                        ok = false;
                        errorDate.Text = "請確認日期填寫是否正確";
                    }
                    else
                    {
                        errorDate.Text = "";
                    }
                }
                else
                {
                    errorDate.Text = "";
                }
                if (txtboxCatdog.Text == "")
                {
                    ok = false;
                    errorCatdog.Text = "此欄未填寫";
                }
                else if (txtboxCatdog.Text != "貓" && txtboxCatdog.Text != "狗")
                {
                    ok = false;
                    errorCatdog.Text = "輸入應為貓or狗";
                }
                else
                {
                    errorCatdog.Text = "";
                }
                if(ok)
                {
                    status2(sender, e);
                    status = 2;
                }
            }
            else
            {
                status1(sender, e);
                status = 1;
            }
        }
    }
}
