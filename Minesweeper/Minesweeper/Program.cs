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
        //private int prevX, prevY;     //플레이어 이전 x, 좌표
        public Player() //생성자
        {
            playerX = 1;
            playerY = 1;
        }

        public void GameMain()
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
                        if (playerY < 1)
                            playerY = 1;
                        break;
                    case 75:
                        playerX -= 2;
                        if (playerX < 1)
                            playerX = 1;
                        break;
                    case 77:
                        playerX += 2;
                        if (playerX > 19)
                            playerX = 19;
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

    class Mine
    {
        public int x;
        public int y;
        public bool exist;
        public bool explosion;
        public int minecount;

        public Mine(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Cover
    {
        public int x;
        public int y;
        public string shape;
        public bool visible;

        public Cover(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.shape = "■";
            this.visible = true;
        }

    }

    class Map
    {
        public int width = 20;
        public int height = 11;
        public Cover[,] covers;
        public Mine[,] mine;
        public Random rand = new Random();

        public Map()
        {
            covers = new Cover[width, height];
            mine = new Mine[width, height];
            InitializeMap();
            CraftMine();
            CountMine();
            DrawMap();
        }

        public void InitializeMap()
        {
            for (int i = 1; i < width; i += 2)
            {
                for (int j = 1; j < height; j++)
                {
                    covers[i, j] = new Cover(i, j);
                    mine[i, j] = new Mine(i, j);
                    mine[i, j].exist = false;
                }
            }
        }

        public void DrawMap()
        {
            for (int i = 1; i < width; i += 2)
            {
                for (int j = 1; j < height; j++)
                {

                    Console.SetCursorPosition(i, j);
                    Console.WriteLine(mine[i,j].minecount);
                }
            }

        }

        public void CraftMine()
        {
            int minenum = rand.Next(25, 40);
            Console.WriteLine(minenum);
            int existpercent = rand.Next(1, 101);


            for (int i = 1; i < 20; i += 2)
            {
                for (int j = 1; j < 10; j++)
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

            for (int i = 1; i < 20; i += 2)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (mine[i, j].exist == false)
                    {
                        for (int di = i - 2; di < i + 3; di += 2)
                        {
                            for (int dj = j - 1; dj < j + 2; dj++)
                            {
                                if (di < 0 || di > 20) continue;
                                if (dj == 0 || dj > 10) continue;
                                if (mine[di, dj].exist == true)
                                {
                                    mine[i, j].minecount++;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Console.SetWindowSize(40, 20);
            Console.SetBufferSize(40, 20);

            Player player = new Player();
            Map map = new Map();

            Console.Clear();
            map.DrawMap();

            while (true)
            {
                
                map.DrawMap();
                player.GameMain();

                Thread.Sleep(100);
                Console.Clear();
            }
        }
    }
}
