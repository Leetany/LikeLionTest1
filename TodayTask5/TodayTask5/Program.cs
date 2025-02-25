using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TodayTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false; //커서 숨기기

            Random rand = new Random();

            int money = 1000;

            Console.Clear(); //화면 지우기
            Console.SetCursorPosition(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            for(int i = 1; i<=18; i++)
            {
                if (i == 9)
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write("┃                         마법사 워프 대회                                     ┃");
                }
                else
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write("┃                                                                              ┃");
                }
            }
            Console.SetCursorPosition(0, 19);
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

            Thread.Sleep(7000);

            while(true)
            {
                Console.Clear();
                Console.WriteLine($" 현재 소지한 돈: {money}");

                int magician1 = 0;
                int magician2 = 0;
                int batting = rand.Next(1, 11);

                Console.WriteLine("\n배팅할 금액을 고르시오.");
                int YourRisk = int.Parse(Console.ReadLine());
                int distance1 = rand.Next(2, 100);
                int distance2 = rand.Next(2, 100);

                Console.Clear();
                Console.SetCursorPosition(0, 1);
                Console.WriteLine("  O  ");
                Console.WriteLine(" /|ㄴ");
                Console.WriteLine(" / / ");
                Console.SetCursorPosition(0, 6);
                Console.WriteLine("  O  ");
                Console.WriteLine(" /|ㄴ");
                Console.WriteLine(" / / ");
                Thread.Sleep(1000);
                Console.Clear();
                Console.SetCursorPosition(distance1, 1);
                Console.WriteLine("  O  ");
                Console.SetCursorPosition(distance1, 2);
                Console.WriteLine(" /|ㄴ");
                Console.SetCursorPosition(distance1, 3);
                Console.WriteLine(" / / ");
                Console.SetCursorPosition(distance2, 6);
                Console.WriteLine("  O  ");
                Console.SetCursorPosition(distance2, 7);
                Console.WriteLine(" /|ㄴ");
                Console.SetCursorPosition(distance2, 8);
                Console.WriteLine(" / / ");
                Thread.Sleep(2000);
                Console.Clear();

                if (distance1 > distance2)
                {
                    money += YourRisk * batting;
                    Console.WriteLine($"축하드립니다. 배팅에 성공하셨고 추가로 {YourRisk * batting} 얻으셨습니다.");
                    Console.ReadLine();
                }
                else
                {
                    money -= YourRisk;
                    Console.WriteLine($"어우 저런, 지셨네요 {YourRisk} 차감하겠습니다");
                    Console.ReadLine();
                }
            }
        }
    }
}
