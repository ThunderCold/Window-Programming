using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool finish = false;
            int cnt = 0;
            var score = new Tuple<int, string, int>[200005];
            while (!finish)
            {
                Console.WriteLine("## 成績計算器 ##");
                Console.WriteLine("1. 新增科目(create)");
                Console.WriteLine("2. 刪除科目(delete)");
                Console.WriteLine("3. 更新科目(update)");
                Console.WriteLine("4. 列印成績單(print)");
                Console.WriteLine("5. 退出選單(exit)");
                Console.Write("選擇要執行的指令操作: ");
                string str = Console.ReadLine();
                string[] s = str.Split(' ');
                if (s[0]=="create")
                {
                    bool exist = false;
                    for(int i=0;i<cnt;i++)
                    {
                        if (score[i].Item2 == s[1])
                        {
                            exist = true;
                            break;
                        }
                    }    
                    if(int.Parse(s[2])<0 || int.Parse(s[2])>100)
                    {
                        Console.WriteLine("成績分數異常! 請重新輸入!\n");
                    }
                    else if(int.Parse(s[3]) < 0 || int.Parse(s[3]) > 10)
                    {
                        Console.WriteLine("學分數異常! 請重新輸入!\n");
                    }
                    else if (exist)
                    {
                        Console.WriteLine("科目已存在\n");
                    }
                    else
                    {
                        score[cnt] = Tuple.Create(int.Parse(s[2]), s[1], int.Parse(s[3]));
                        cnt++;
                        Console.WriteLine();
                    }
                }
                else if (s[0]=="delete")
                {
                    int target = -1;
                    for(int i=0;i<cnt;i++)
                    {
                        if (score[i].Item2 == s[1])
                        {
                            target = i;
                            break;
                        }
                    }
                    if (target!=-1)
                    {
                        score[target] = Tuple.Create(-1, "0", 0);
                        cnt--;
                        Array.Sort(score);
                        Array.Reverse(score);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("科目不存在\n");
                    }
                }
                else if (s[0]=="update")
                {
                    int target = -1;
                    for (int i = 0; i < cnt; i++)
                    {
                        if (score[i].Item2 == s[1])
                        {
                            target = i;
                            break;
                        }
                    }
                    if (int.Parse(s[2]) < 0 || int.Parse(s[2]) > 100)
                    {
                        Console.WriteLine("成績分數異常! 請重新輸入!\n");
                    }
                    else if (int.Parse(s[3]) < 0 || int.Parse(s[3]) > 10)
                    {
                        Console.WriteLine("學分數異常! 請重新輸入!\n");
                    }
                    else if (target == -1)
                    {
                        Console.WriteLine("科目不存在\n");
                    }
                    else
                    {
                        score[target] = Tuple.Create(int.Parse(s[2]), s[1], int.Parse(s[3]));
                        Console.WriteLine();
                    }
                }
                else if (s[0]=="print")
                {
                    Array.Sort(score);
                    Array.Reverse(score);
                    Console.WriteLine("\n我的成績單:");
                    Console.WriteLine("編號    科目代碼    分數    等第    學分數");
                    double total_score = 0, all_credit = 0, get_credit = 0, old_gpa = 0, new_gpa = 0;
                    string leval,blank1,blank2;
                    for(int i=0;i<cnt;i++)
                    {
                        if(i<9)
                        {
                            blank1 = "  ";
                        }
                        else if(i<99)
                        {
                            blank1 = " ";
                        }
                        else
                        {
                            blank1 = "";
                        }
                        if(score[i].Item1<10)
                        {
                            blank2 = "  ";
                        }
                        else if(score[i].Item1 < 100)
                        {
                            blank2 = " ";
                        }
                        else
                        {
                            blank2 = "";
                        }
                        total_score += score[i].Item1 * score[i].Item3;
                        all_credit+= score[i].Item3;
                        if(score[i].Item1>=60)
                        {
                            get_credit+= score[i].Item3;
                        }
                        if(score[i].Item1>=90)
                        {
                            new_gpa += 4.3 * score[i].Item3;
                            old_gpa += 4 * score[i].Item3;
                            leval = "A+";
                        }
                        else if (score[i].Item1>=85)
                        {
                            new_gpa += 4 * score[i].Item3;
                            old_gpa += 4 * score[i].Item3;
                            leval = "A ";
                        }
                        else if (score[i].Item1>=80)
                        {
                            new_gpa += 3.7 * score[i].Item3;
                            old_gpa += 4 * score[i].Item3;
                            leval = "A-";
                        }
                        else if (score[i].Item1>=77)
                        {
                            new_gpa += 3.3 * score[i].Item3;
                            old_gpa += 3 * score[i].Item3;
                            leval = "B+";
                        }
                        else if (score[i].Item1>=73)
                        {
                            new_gpa += 3 * score[i].Item3;
                            old_gpa += 3 * score[i].Item3;
                            leval = "B ";
                        }
                        else if (score[i].Item1>=70)
                        {
                            new_gpa += 2.7 * score[i].Item3;
                            old_gpa += 3 * score[i].Item3;
                            leval = "B-";
                        }
                        else if (score[i].Item1>=67)
                        {
                            new_gpa += 2.3 * score[i].Item3;
                            old_gpa += 2 * score[i].Item3;
                            leval = "C+";
                        }
                        else if (score[i].Item1>=63)
                        {
                            new_gpa += 2 * score[i].Item3;
                            old_gpa += 2 * score[i].Item3;
                            leval = "C ";
                        }
                        else if (score[i].Item1>=60)
                        {
                            new_gpa += 1.7 * score[i].Item3;
                            old_gpa += 2 * score[i].Item3;
                            leval = "C-";
                        }
                        else if (score[i].Item1>=50)
                        {
                            old_gpa += 1 * score[i].Item3;
                            leval = "F ";
                        }
                        else
                        {
                            leval = "F ";
                        }
                        Console.WriteLine($"{i + 1}   {blank1}   {score[i].Item2}      {score[i].Item1}  {blank2}   {leval}       {score[i].Item3}");
                    }
                    Console.WriteLine($"總平均: {Math.Round(total_score / all_credit, 2)}");
                    Console.WriteLine($"GPA: {Math.Round(old_gpa / all_credit, 1)} (舊制), {Math.Round(new_gpa / all_credit, 1)} (新制)");
                    Console.WriteLine($"實拿學分數/總學分數: {get_credit}/{all_credit}\n");
                }
                else if (s[0]=="exit")
                {
                    finish = true;
                }
                else
                {
                    Console.WriteLine("指令格式不符! 請重新輸入!\n");
                }
            }
        }
    }
}
