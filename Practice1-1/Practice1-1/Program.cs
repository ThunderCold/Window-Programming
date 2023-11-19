using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 0, 0, 0, 0 };
            int item, number;
            bool finish = false;
            while (!finish)
            {
                Console.Write("(1)商品列表 (2)新增至購物車 (3)自購物車刪除 (4) 查看購物車 (5)計算總金額 (6)退出網站\n輸入數字選擇功能：");
                int func = int.Parse(Console.ReadLine());
                switch (func)
                {
                    case 1:
                        Console.WriteLine("列表:");
                        Console.WriteLine("商品名稱 商品單價");
                        Console.WriteLine("1.潛水相機防丟繩 (TWD)199");
                        Console.WriteLine("2.潛水配重帶 (TWD)460");
                        Console.WriteLine("3.潛水作業指北針 (TWD)1100\n");
                        break;
                    case 2:
                        Console.WriteLine("(1)潛水相機防丟繩 (2)潛水配重帶 (3)潛水作業指北針");
                        Console.Write("輸入數字選擇產品：");
                        item = int.Parse(Console.ReadLine());
                        Console.Write("輸入數量：");
                        number = int.Parse(Console.ReadLine());
                        a[item] += number;
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("購物車內容:");
                        Console.WriteLine("商品 單價 數量 小計");
                        Console.WriteLine("1.潛水相機防丟繩 (TWD)199 {0} {1}", a[1], a[1] * 199);
                        Console.WriteLine("2.潛水配重帶 (TWD)460 {0} {1}", a[2], a[2] * 460);
                        Console.WriteLine("3.潛水作業指北針 (TWD)1100 {0} {1}", a[3], a[3] * 1100);
                        Console.Write("輸入數字選擇產品：");
                        item = int.Parse(Console.ReadLine());
                        if (item == 4)
                        {
                            Console.WriteLine("輸入錯誤!請重新輸入!\n");
                            continue;
                        }
                        Console.Write("輸入數量：");
                        number = int.Parse(Console.ReadLine());
                        a[item] -= number;
                        Console.WriteLine("成功刪除產品!\n");
                        break;
                    case 4:
                        Console.WriteLine("購物車內容:");
                        Console.WriteLine("商品 單價 數量 小計");
                        Console.WriteLine("1.潛水相機防丟繩 (TWD)199 {0} {1}", a[1], a[1] * 199);
                        Console.WriteLine("2.潛水配重帶 (TWD)460 {0} {1}", a[2], a[2] * 460);
                        Console.WriteLine("3.潛水作業指北針 (TWD)1100 {0} {1}\n", a[3], a[3] * 1100);
                        break;
                    case 5:
                        Console.WriteLine("訂單商品:");
                        Console.WriteLine("商品 單價 數量 小計");
                        if (a[1] > 0)
                        {
                            Console.WriteLine("潛水相機防丟繩 (TWD)199 {0} {1}", a[1], a[1] * 199);
                        }
                        if (a[2] > 0)
                        {
                            Console.WriteLine("潛水配重帶 (TWD)460 {0} {1}", a[2], a[2] * 460);
                        }
                        if (a[3] > 0)
                        {
                            Console.WriteLine("潛水作業指北針 (TWD)1100 {0} {1}", a[3], a[3] * 1100);
                        }
                        Console.WriteLine("總價 = {0}\n", a[1] * 199 + a[2] * 460 + a[3] * 1100);
                        break;
                    case 6:
                        finish = true;
                        break;
                    default:
                        Console.WriteLine("輸入錯誤!請重新輸入!\n");
                        break;
                }
            }
        }
    }
}
