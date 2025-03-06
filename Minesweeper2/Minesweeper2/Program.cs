using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Minesweeper
{
    class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();  //c언어 함수 가져옴

        public int playerX, playerY;  //플레이어 x, y좌표
        public Player() //생성자
        {
            playerX = 0;
            playerY = 0;
        }

        public void GameMain()  //계속 돌릴 부분
        {

            KeyControl();
            PlayerDraw();

        }

        public void KeyControl()
        {
            int pressKey;

            if (Console.KeyAvailable)
            {
                pressKey = _getch();

                if (pressKey == 0 || pressKey == 224)
                {
                    pressKey = _getch();
                }

                switch (pressKey)
                {
                    case 72:
                        playerY--;
                        if (playerY < 0)
                            playerY = 0;
                        break;
                    case 75:
                        playerX -= 2;
                        if (playerX < 0)
                            playerX = 0;
                        break;
                    case 77:
                        playerX += 2;
                        if (playerX > 18)
                            playerX = 18;
                        break;
                    case 80:
                        playerY++;
                        if (playerY > 9)
                            playerY = 9;
                        break;
                    //스페이스바 눌러서 지뢰 찾는 것
                    case 32:


                    case 27:
                        Environment.Exit(1);
                        break;
                }
            }
        }

        public void PlayerDraw()
        {
            // 새 위치에 플레이어 표시
            Console.SetCursorPosition(playerX, playerY);
            Console.Write("□");
        }
    }

    class Mine   //마인 클래스  마인 이중배열로 관리하려고 클래스 따로 둠
    {
        public int x;
        public int y;
        public bool exist;
        public bool explosion;
        public int minecount;

        public Mine()
        {
            exist = false;
        }
        public Mine(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Map   //게임 맵
    {
        public int width = 20;
        public int height = 10;
        public Mine[,] mine;
        public Random rand = new Random();
        
        
        public Map()
        {
            
            mine = new Mine[width, height];

            for (int i = 0; i < width; i+=2)
            {
                for (int j = 0; j < height; j++)
                {
                    mine[i, j] = new Mine();
                }
            }
            CraftMine();
            CountMine();
        }

        public void DrawMap()
        {
            for (int i = 0; i < width; i += 2)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.SetCursorPosition(i, j);
                    if (mine[i,j].exist)
                    {
                        Console.WriteLine("* ");
                    }
                    else
                    {
                        Console.WriteLine("■");
                    }
                }
            }
        }

        public void CraftMine()
        {
            int minenum = rand.Next(25, 40);
 
            int existpercent = rand.Next(1, 101);

            for (int i = 0; i < 20; i += 2)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (minenum > 0)
                    {
                        if (existpercent > 50)
                        {
                            mine[i, j].exist = true;
                            minenum--;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

        }

        public void CountMine()
        {
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Console.SetWindowSize(40, 25);
            Console.SetBufferSize(40, 25);

            Player player = new Player();
            Map map = new Map();

            Console.Clear();
            map.DrawMap();

            /*while (true)
            {

                map.DrawMap();
                player.GameMain();

                Thread.Sleep(100);
                Console.Clear();
            }*/
        }
    }
}
