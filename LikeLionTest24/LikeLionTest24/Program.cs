using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LikeLionTest24
{
    class Program
    {
        struct Player
        {
            public int x;
            public int y;
        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(125, 40); // 콘솔 창 크기 설정 (가로 125, 세로 50)
            Console.SetBufferSize(125, 40); // 버퍼 크기도 동일하게 설정 (스크롤 방지)

            Console.CursorVisible = false;

            string[] player = new string[]
            {
                "->",
                ">>>",
                "->",
            }; //배열로 문자열로 그리기

            int playerX=0;
            int playerY=12;

            ConsoleKeyInfo KeyInfo;

            //시간 1초 루프
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long prevSecond = stopwatch.ElapsedMilliseconds; // 1/1000 1000일때 1초

            while (true)
            {
                long currentSecond = stopwatch.ElapsedMilliseconds; //현재시간 가져오기

                if (currentSecond - prevSecond >= 100)                      //Thread.Sleep은 시스템을 다운 시켯다가 키는 것이기 때문에 
                {                                                           //게임 같은 곳에서는 계속 보여줘야 하기 때문에 저렇게 짜서 100밀리세크 만에 화면을 리셋시켜주는 것

                    Console.Clear();
                    //Console.WriteLine("1초 루프");

                    prevSecond = currentSecond; // 이전 시간 업데이트

                    for (int i = 0; i < player.Length; i++)
                    {
                        //콘솔좌표 설정 플레이어X 플레이어Y
                        Console.SetCursorPosition(playerX, playerY + i);
                        //문자열배열 출력
                        Console.WriteLine(player[i]);
                    }

                    KeyInfo = Console.ReadKey(true);



                    //방향키 입력에 따른 좌표 변경
                    switch (KeyInfo.Key)
                    {
                        case ConsoleKey.UpArrow: if (playerY > 0) playerY--; break;
                        case ConsoleKey.DownArrow: if (playerY < Console.WindowHeight - 3) playerY++; break;
                        case ConsoleKey.LeftArrow: if (playerX > 0) playerX--; break;
                        case ConsoleKey.RightArrow: if (playerX < Console.WindowWidth - 3) playerX++; break;
                        case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                        case ConsoleKey.Escape: return; //Esc키로 종료
                    }

                
                }
            }
        }
    }
}
