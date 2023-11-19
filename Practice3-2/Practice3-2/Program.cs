using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3_2
{
    class Member
    {
        public string name;
        public string department;
        public string id;
        public string level;
        public string title;
        public Member(string name, string department, string id, string level, string title)
        {
            this.name = name;
            this.department = department;
            this.id = id;
            this.level = level;
            this.title = title;
        }
    }
    internal class Program
    {
        static void show()
        {
            Console.WriteLine("--------------------------###   社員資料登記   ###--------------------------");
            Console.WriteLine("新增社員資訊:     register        name     department       ID");
            Console.WriteLine("以特定屬性查詢:   search          name     tag     Want_search_string");
            Console.WriteLine("授予社員職位:     entitle         name     department       ID    That_title ");
            Console.WriteLine("所有社員列表:     check");
            Console.WriteLine("指令格式列表:     help");
            Console.WriteLine("離開此程式:       exit\n");
        }
        static void Main(string[] args)
        {
            List<Member> memberlist = new List<Member>();
            bool finish = false;
            show();
            while (!finish)
            {
                string str=Console.ReadLine();
                string[] s = str.Split(' ');
                if (s[0]=="register")
                {
                    if (s.Length != 4)
                    {
                        Console.WriteLine("        輸入格式有誤，請再檢查一次");
                        continue;
                    }
                    Member target=memberlist.FirstOrDefault(member => member.name == s[1] && member.department == s[2] && member.id == s[3]);
                    if (target!=null)
                    {
                        if(target.level == "萌新社員")
                        {
                            Console.WriteLine("已晉升為資深社員");
                            target.level = "資深社員";
                        }
                        else if (target.level == "資深社員")
                        {
                            Console.WriteLine("已晉升為永久社員");
                            target.level = "永久社員";
                        }
                        else
                        {
                            Console.WriteLine("已經是永久社員了喔");
                        }
                    }
                    else
                    {
                        Member newmember = new Member(s[1], s[2], s[3], "萌新社員", "無");
                        memberlist.Add(newmember);
                        Console.WriteLine("歡迎新社員!!");
                    }
                }
                else if (s[0]=="search")
                {
                    if (s.Length != 3)
                    {
                        Console.WriteLine("        輸入格式有誤，請再檢查一次");
                        continue;
                    }
                    if (s[1]=="name")
                    {
                        bool found = false;
                        IEnumerable<Member> targets = memberlist.Where(member => member.name == s[2]);
                        foreach (Member i in targets)
                        {
                            found = true;
                            Console.WriteLine($"{i.name}\t{i.department}\t{i.id}\t{i.level}\t{i.title}");
                        }
                        if(!found)
                        {
                            Console.WriteLine("        找不到這個人ㄟ");
                        }
                    }
                    else if (s[1] == "department")
                    {
                        bool found = false;
                        IEnumerable<Member> targets = memberlist.Where(member => member.department == s[2]);
                        foreach (Member i in targets)
                        {
                            found = true;
                            Console.WriteLine($"{i.name}\t{i.department}\t{i.id}\t{i.level}\t{i.title}");
                        }
                        if (!found)
                        {
                            Console.WriteLine("        找不到這個人ㄟ");
                        }
                    }
                    else if (s[1] == "ID")
                    {
                        bool found = false;
                        IEnumerable<Member> targets = memberlist.Where(member => member.id == s[2]);
                        foreach (Member i in targets)
                        {
                            found = true;
                            Console.WriteLine($"{i.name}\t{i.department}\t{i.id}\t{i.level}\t{i.title}");
                        }
                        if (!found)
                        {
                            Console.WriteLine("        找不到這個人ㄟ");
                        }
                    }
                    else if (s[1] == "level")
                    {
                        bool found = false;
                        IEnumerable<Member> targets = memberlist.Where(member => member.level == s[2]);
                        foreach (Member i in targets)
                        {
                            found = true;
                            Console.WriteLine($"{i.name}\t{i.department}\t{i.id}\t{i.level}\t{i.title}");
                        }
                        if (!found)
                        {
                            Console.WriteLine("        找不到這個人ㄟ");
                        }
                    }
                    else if (s[1] == "title")
                    {
                        bool found = false;
                        IEnumerable<Member> targets = memberlist.Where(member => member.title == s[2]);
                        foreach (Member i in targets)
                        {
                            found = true;
                            Console.WriteLine($"{i.name}\t{i.department}\t{i.id}\t{i.level}\t{i.title}");
                        }
                        if (!found)
                        {
                            Console.WriteLine("        找不到這個人ㄟ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("        無此搜尋功能");
                    }
                }
                else if (s[0]=="entitle")
                {
                    if (s.Length != 5)
                    {
                        Console.WriteLine("        輸入格式有誤，請再檢查一次");
                        continue;
                    }
                    Member target = memberlist.FirstOrDefault(member => member.name == s[1] && member.department == s[2] && member.id == s[3]);
                    if(target != null)
                    {
                        if (s[4].Contains("社長"))
                        {
                            Console.WriteLine("        我們的社長只有阿明一個人，你不要想篡位!");
                        }
                        else
                        {
                            target.title = s[4];
                        }
                    }
                    else
                    {
                        Console.WriteLine("        找不到這個人ㄟ");
                    }
                }
                else if (s[0]=="check")
                {
                    if (s.Length != 1)
                    {
                        Console.WriteLine("        輸入格式有誤，請再檢查一次");
                        continue;
                    }
                    Console.WriteLine("----------------------------------------------------------");
                    foreach (Member i in memberlist)
                    {
                        Console.WriteLine($"{i.name}\t{i.department}\t{i.id}\t{i.level}\t{i.title}");
                    }
                    Console.WriteLine("----------------------------------------------------------");
                }
                else if (s[0]=="help")
                {
                    if (s.Length != 1)
                    {
                        Console.WriteLine("        輸入格式有誤，請再檢查一次");
                        continue;
                    }
                    show();
                }
                else if (s[0]=="exit")
                {
                    if (s.Length != 1)
                    {
                        Console.WriteLine("        輸入格式有誤，請再檢查一次");
                        continue;
                    }
                    finish = true;
                }
                else
                {
                    Console.WriteLine("        不存在這個功能，有疑慮請打help");
                }
            }
        }
    }
}
