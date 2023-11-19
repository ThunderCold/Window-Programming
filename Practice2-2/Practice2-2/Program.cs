using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("設定遊戲參數");
            Console.Write("輸入空間的大小: ");
            string str = Console.ReadLine();
            string[] s1 = str.Split(',');
            int M = int.Parse(s1[0]), N = int.Parse(s1[1]);
            Console.Write("輸入鬼的數量: ");
            str = Console.ReadLine();
            int X = int.Parse(str);
            if(X>=M*N||M<=0||N<=0)
            {
                Console.WriteLine("遊戲參數錯誤!");
                Console.Read();
                return;
            }
            List<int> ghost = new List<int>();
            List<int> nums = new List<int>();
            int score = 0;
            //第一次輸入
            Console.Clear();
            Console.Write("   ");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{(char)(65 + i)} ");
            }
            Console.Write("\n");
            for(int i=0;i<M;i++)
            {
                Console.Write(i);
                if (i < 10)
                {
                    Console.Write("  ");
                }
                else
                {
                    Console.Write(" ");
                }
                for (int j=0;j<N;j++)
                {
                    Console.Write("- ");
                }
                Console.Write('\n');
            }
            int firstx = 0, firsty = 0;
            bool ok = false;
            while(!ok)
            {
                Console.Write("輸入要查看的位置: ");
                str = Console.ReadLine();
                string[] s2 = str.Split(',');
                firstx = int.Parse(s2[0]);
                firsty = s2[1][0] - 'A';
                if (firstx < 0 || firsty < 0 || firstx >= M || firsty >= N)
                {
                    Console.WriteLine("無效的輸入，請再試一次");
                }
                else
                {
                    ok = true;
                }
            }
            score++;
            //遊戲設定
            for (int i=0;i<M*N;i++)
            {
                nums.Add(i);
            }
            nums.Remove(firstx * N + firsty);
            Random random = new Random();
            for(int i=0;i<X;i++)
            {
                int randomIndex = random.Next(0, nums.Count);
                ghost.Add(nums[randomIndex]);
                nums.RemoveAt(randomIndex);
            }
            int[,] nb = new int[M, N];
            bool[,] vis = new bool[M, N];
            for(int i=0;i<M;i++)
            {
                for(int j=0;j<N;j++)
                {
                    vis[i, j] = false;
                    int sum = 0;
                    if(i>0&&j>0)
                    {
                        if (ghost.Contains((i - 1) * N + j - 1))
                        {
                            sum++;
                        }
                    }
                    if(i>0)
                    {
                        if (ghost.Contains((i - 1) * N + j))
                        {
                            sum++;
                        }
                    }
                    if(i>0&&j<N-1)
                    {
                        if (ghost.Contains((i - 1) * N + j + 1))
                        {
                            sum++;
                        }
                    }
                    if(j>0)
                    {
                        if (ghost.Contains(i * N + j - 1))
                        {
                            sum++;
                        }
                    }
                    if (j <N-1)
                    {
                        if (ghost.Contains(i * N + j + 1))
                        {
                            sum++;
                        }
                    }
                    if(i<M-1&&j>0)
                    {
                        if (ghost.Contains((i + 1) * N + j - 1))
                        {
                            sum++;
                        }
                    }
                    if(i<M-1)
                    {
                        if (ghost.Contains((i + 1) * N + j))
                        {
                            sum++;
                        }
                    }
                    if(i<M-1&&j<N-1)
                    {
                        if (ghost.Contains((i + 1) * N + j + 1))
                        {
                            sum++;
                        }
                    }
                    nb[i, j] = sum;
                }
            }
            vis[firstx, firsty] = true;
            //第一次輸入就WIN
            if(M*N==X+1)
            {
                Console.Clear();
                Console.Write("   ");
                for (int i = 0; i < N; i++)
                {
                    Console.Write($"{(char)(65 + i)} ");
                }
                Console.Write("\n");
                for (int i = 0; i < M; i++)
                {
                    Console.Write(i);
                    if (i < 10)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < N; j++)
                    {
                        if (ghost.Contains(i * N + j))
                        {
                            Console.Write("X ");
                        }
                        else
                        {
                            Console.Write($"{nb[i, j]} ");
                        }
                    }
                    Console.Write('\n');
                }
                Console.WriteLine("遊戲結束! 你成功躲避所有的鬼了");
                Console.Read();
                return;
            }
            //第二次遊戲開始
            bool finish = false;
            while(!finish)
            {
                Console.Clear();
                Console.Write("   ");
                for(int i=0;i<N; i++)
                {
                    Console.Write($"{(char)(65 + i)} ");
                }
                Console.Write("\n");
                for (int i=0;i<M;i++)
                {
                    Console.Write(i);
                    if (i < 10)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    for (int j=0;j<N;j++)
                    {
                        if (vis[i,j]==false)
                        {
                            Console.Write("- ");
                        }
                        else if(ghost.Contains(i*N+j))
                        {
                            Console.Write("X ");
                        }
                        else
                        {
                            Console.Write($"{nb[i, j]} ");
                        }
                    }
                    Console.Write("\n");
                }
                ok = false;
                int x = 0, y = 0;
                while(!ok)
                {
                    Console.Write("輸入要查看的位置: ");
                    str = Console.ReadLine();
                    string[] s = str.Split(',');
                    x = int.Parse(s[0]);
                    y = s[1][0] - 'A';
                    if (x < 0 || y < 0 || x >= M || y >= N)
                    {
                        Console.WriteLine("無效的輸入，請再試一次");
                    }
                    else if(vis[x, y])
                    {
                        Console.WriteLine("無效的輸入，請再試一次");
                    }
                    else
                    {
                        ok = true;
                    }
                }
                score++;
                if(ghost.Contains(x*N+y)||score >= M * N - ghost.Count) //遊戲結束
                {
                    Console.Clear();
                    Console.Write("   ");
                    for (int i = 0; i < N; i++)
                    {
                        Console.Write($"{(char)(65 + i)} ");
                    }
                    Console.Write("\n");
                    for (int i = 0; i < M; i++)
                    {
                        Console.Write(i);
                        if (i < 10)
                        {
                            Console.Write("  ");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                        for (int j = 0; j < N; j++)
                        {
                            if(ghost.Contains(i*N+j))
                            {
                                Console.Write("X ");
                            }
                            else
                            {
                                Console.Write($"{nb[i, j]} ");
                            }
                        }
                        Console.Write('\n');
                    }
                    if(ghost.Contains(x*N+y))
                    {
                        Console.WriteLine("遊戲結束! 你被鬼抓到了");
                        Console.Read();
                        finish = true;
                    }
                    else
                    {
                        Console.WriteLine("遊戲結束! 你成功躲避所有的鬼了");
                        Console.Read();
                        finish = true;
                    }
                }
                else
                {
                    vis[x, y] = true;
                }
            }
        }
    }
}
