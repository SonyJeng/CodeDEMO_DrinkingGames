using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //0=0
        //1=5
        //2=10
        //3=15
        //4=20

        static void Main(string[] args)
        {
            int com = 0, pa = 0;
            int isConti;
            do
            {
                Random num = new Random();
                int who = num.Next(0, 2);
                //0為玩家出拳 1為電腦出拳
                while (!(com == 2 || pa == 2))
                {
                    if (who == 0)
                    {
                        int a = (num.Next(0, 2)) * 5;//電腦出拳
                        int b = (num.Next(0, 2)) * 5;
                        int c = (num.Next(0, 3)) * 5 + a + b;

                        Console.WriteLine("電腦已準備，換你了：");//玩家出拳
                        string play = Console.ReadLine();
                        string[] input = play.Split(' ');
                        int d = int.Parse(input[0]);
                        int e = int.Parse(input[1]);
                        Console.WriteLine($"電腦：{a} {b} {c}");
                        Console.WriteLine($"玩家：{d} {e}");

                        if (c == (a + b + d + e))
                        {
                            Console.WriteLine("You're lose!");
                            if (com==0)
                            {
                                Console.WriteLine("電腦聽牌");
                            }
                            who = 0;
                            com++;
                        }
                        else
                        {
                            Console.WriteLine("You're win!");
                            Console.WriteLine("玩家聽牌");
                            who = 1;
                            com = 0;
                            pa++;
                        }
                    }
                    else
                    {
                        //電腦出拳
                        int a = (num.Next(0, 2)) * 5;
                        int b = (num.Next(0, 2)) * 5;
                        //玩家出拳
                        Console.WriteLine("請出拳，要喊哦~:");
                        string play = Console.ReadLine();
                        string[] input = play.Split(' ');
                        int d = int.Parse(input[0]);
                        int e = int.Parse(input[1]);
                        int c = int.Parse(input[2]);
                        Console.WriteLine($"電腦：{a} {b}");
                        Console.WriteLine($"玩家：{d} {e} {c}");

                        if (c == (a + b + d + e))
                        {
                            Console.WriteLine("You're win!");
                            if (pa == 0)
                            {
                                Console.WriteLine("玩家聽牌");
                            }
                            pa++;
                            who = 1;
                        }
                        else
                        {
                            Console.WriteLine("You're lose!");
                            Console.WriteLine("電腦聽牌");
                            who = 0;
                            pa = 0;
                            com++;
                        }
                    }
                }

                
                Console.WriteLine("請問是否繼續(1: Yes / 2: No)");
                isConti = int.Parse(Console.ReadLine());
            } while (isConti == 1);



            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
