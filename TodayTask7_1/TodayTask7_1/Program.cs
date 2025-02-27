using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShootingGame1
{
    class Program
    {
        struct Player
        {
            public int X;
            public int Y;
            public string[] plane;

            public Player(int x, int y)
            {
                X = x;
                Y = y;
                plane = new string[]
                {
                    "->",
                    ">>>",
                    "->"
                };
            }

            public void Rendering()
            {
                for (int i = 0; i < plane.Length; i++)
                {
                    Console.SetCursorPosition(X, Y + i);
                    Console.WriteLine(plane[i]);
                }
            }

            public void Move(ref Player pp)
            {
                if (Console.KeyAvailable) //키가 눌렸을때 true
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow: if (pp.Y > 0) pp.Y--; break;
                        case ConsoleKey.DownArrow: if (pp.Y < Console.WindowHeight - 1) pp.Y++; break;
                        case ConsoleKey.LeftArrow: if (pp.X > 0) pp.X--; break;
                        case ConsoleKey.RightArrow: if (pp.X < Console.WindowWidth - 1) pp.X++; break;
                        case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                        case ConsoleKey.Escape: return; //ESC키로 종료 
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(125, 40); // 콘솔 창 크기 설정 (가로 80, 세로 25)
            Console.SetBufferSize(125, 40); // 버퍼 크기도 동일하게 설정 (스크롤 방지)
            Console.CursorVisible = false;

            Player player = new Player(0, 12);

            ConsoleKeyInfo keyInfo;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long prevSecond = stopwatch.ElapsedMilliseconds; // 1 /1000    1000일때 1초

            while (true)
            {
                long currentSecond = stopwatch.ElapsedMilliseconds; 

                if (currentSecond - prevSecond >= 100)
                {
                    Console.Clear();

                    player.Move(ref player);

                    player.Rendering();
                    prevSecond = currentSecond;//이전 시간 업데이트
                }
            }
        }
    }
}