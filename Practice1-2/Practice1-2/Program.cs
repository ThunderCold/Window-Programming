using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 0, 0, 0, 0 };
            double[] c = new double[] { 0, 1, 0.031, 0.23, 4.59 };
            string[] s = new string[] { "", "TWD", "USD", "CNY", "JPY" };
            int item, number,ccy=1;
            string ans, coupon;
            bool finish = false;
            while (!finish)
            {
                Console.Write("(1)商品列表 (2)新增至購物車 (3)自購物車刪除 (4) 查看購物車 (5)結帳 (6)轉換幣值 (7)退出網站\n輸入數字選擇功能：");
                int func = int.Parse(Console.ReadLine());
                switch (func)
                {
                    case 1:
                        Console.WriteLine("列表:");
                        Console.WriteLine("商品名稱 商品單價");
                        Console.WriteLine("1.潛水相機防丟繩 ({0}){1}", s[ccy], 199 * c[ccy]);
                        Console.WriteLine("2.潛水配重帶 ({0}){1}", s[ccy], 460 * c[ccy]);
                        Console.WriteLine("3.潛水作業指北針 ({0}){1}\n", s[ccy], 1100 * c[ccy]);
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
                        Console.WriteLine("1.潛水相機防丟繩 ({0}){1} {2} {3}", s[ccy], 199 * c[ccy], a[1], a[1] * 199 * c[ccy]);
                        Console.WriteLine("2.潛水配重帶 ({0}){1} {2} {3}", s[ccy], 460 * c[ccy], a[2], a[2] * 460 * c[ccy]);
                        Console.WriteLine("3.潛水作業指北針 ({0}){1} {2} {3}", s[ccy], 1100 * c[ccy], a[3], a[3] * 1100 * c[ccy]);
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
                        Console.WriteLine("1.潛水相機防丟繩 ({0}){1} {2} {3}", s[ccy], 199 * c[ccy], a[1], a[1] * 199 * c[ccy]);
                        Console.WriteLine("2.潛水配重帶 ({0}){1} {2} {3}", s[ccy], 460 * c[ccy], a[2], a[2] * 460 * c[ccy]);
                        Console.WriteLine("3.潛水作業指北針 ({0}){1} {2} {3}\n", s[ccy], 1100 * c[ccy], a[3], a[3] * 1100 * c[ccy]);
                        break;
                    case 5:
                        Console.WriteLine("訂單商品:");
                        Console.WriteLine("商品 單價 數量 小計");
                        if (a[1] > 0)
                        {
                            Console.WriteLine("1.潛水相機防丟繩 ({0}){1} {2} {3}", s[ccy], 199 * c[ccy], a[1], a[1] * 199 * c[ccy]);
                        }
                        if (a[2] > 0)
                        {
                            Console.WriteLine("2.潛水配重帶 ({0}){1} {2} {3}", s[ccy], 460 * c[ccy], a[2], a[2] * 460 * c[ccy]);
                        }
                        if (a[3] > 0)
                        {
                            Console.WriteLine("3.潛水作業指北針 ({0}){1} {2} {3}", s[ccy], 1100 * c[ccy], a[3], a[3] * 1100 * c[ccy]);
                        }
                        Console.WriteLine("總價 = {0}", (a[1] * 199 + a[2] * 460 + a[3] * 1100) * c[ccy]);
                        Console.Write("*是否要結帳(Y/N)*:");
                        ans=Console.ReadLine();
                        if(ans=="Y")
                        {
                            bool checkout = true;
                            if (a[1]>1)
                            {
                                Console.WriteLine("潛水相機防丟繩庫存不足!剩餘數量1!\n");
                                checkout = false;
                            }
                            if (a[2]>2)
                            {
                                Console.WriteLine("潛水配重帶庫存不足!剩餘數量2!\n");
                                checkout = false;
                            }
                            if (a[3]>1)
                            {
                                Console.WriteLine("潛水作業指北針庫存不足!剩餘數量1!\n");
                                checkout = false;
                            }
                            if(checkout)
                            {
                                Console.Write("*選擇結帳方式(1.線上支付 2.貨到付款):");
                                int payment = int.Parse(Console.ReadLine());
                                if(payment!=1&&payment!=2)
                                {
                                    Console.WriteLine("輸入錯誤!請重新輸入!\n");
                                }
                                else
                                {
                                    Console.Write("*折扣碼(若無折扣碼則輸入N):");
                                    coupon=Console.ReadLine();
                                    if (coupon != "N" && coupon!="1111")
                                    {
                                        Console.WriteLine("輸入錯誤!請重新輸入!\n");
                                    }
                                    else
                                    {
                                        Console.WriteLine("訂單狀態:");
                                        Console.WriteLine("商品 單價 數量 小計");
                                        if (a[1] > 0)
                                        {
                                            Console.WriteLine("潛水相機防丟繩 ({0}){1} {2} {3}", s[ccy], 199 * c[ccy], a[1], a[1] * 199 * c[ccy]);
                                        }
                                        if (a[2] > 0)
                                        {
                                            Console.WriteLine("潛水配重帶 ({0}){1} {2} {3}", s[ccy], 460 * c[ccy], a[2], a[2] * 460 * c[ccy]);
                                        }
                                        if (a[3] > 0)
                                        {
                                            Console.WriteLine("潛水作業指北針 ({0}){1} {2} {3}", s[ccy], 1100 * c[ccy], a[3], a[3] * 1100 * c[ccy]);
                                        }
                                        Console.WriteLine("總價 = {0}", (a[1] * 199 + a[2] * 460 + a[3] * 1100) * c[ccy]);
                                        if(coupon=="1111")
                                        {
                                            Console.WriteLine("總價(折扣後) = {0}", (a[1] * 199 + a[2] * 460 + a[3] * 1100) * 0.95 * c[ccy]);
                                        }
                                        else
                                        {
                                            Console.WriteLine("總價(折扣後) = {0}", (a[1] * 199 + a[2] * 460 + a[3] * 1100) * c[ccy]);
                                        }
                                        if(payment==1)
                                        {
                                            Console.WriteLine("狀態:已付款\n");
                                        }
                                        else
                                        {
                                            Console.WriteLine("狀態:尚未付款\n");
                                        }
                                        Console.Read();
                                        finish = true;
                                    }
                                }
                            }
                        }
                        else if(ans=="N")
                        {
                            Console.WriteLine();
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("輸入錯誤!請重新輸入!\n");
                        }
                        break;
                    case 6:
                        Console.Write("選擇貨幣 1.TWD 2.USD 3.CNY 4.JPY :");
                        ccy = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        break;
                    case 7:
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
