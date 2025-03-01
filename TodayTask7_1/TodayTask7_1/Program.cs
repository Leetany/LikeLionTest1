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
            string[] shape;

            public Player(int x, int y)
            {
                X = x;
                Y = y;
                shape = new string[]
                {
                    "->",
                    ">>>",
                    "->"
                };
            }

            public void Render()
            {
                for(int i= 0; i <shape.Length; i++)
                {
                    Console.SetCursorPosition(X, Y + i);
                    Console.WriteLine(shape[i]);
                }
            }

            public void Move(ConsoleKeyInfo keyInfo, ref Player player )
            {
                

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (player.Y > 0) player.Y--; break;
                    case ConsoleKey.DownArrow:
                        if (player.Y < Console.WindowHeight - 3) player.Y++; break;
                    case ConsoleKey.LeftArrow:
                        if (player.X > 0) player.X--; break;
                    case ConsoleKey.RightArrow:
                        if (player.X < Console.WindowWidth - 3) player.X++; break;
                    case ConsoleKey.Escape: return;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(125, 40);
            Console.SetBufferSize(125, 40);
            Console.CursorVisible = false;

            Player player = new Player(0, 12);

            int playerX = 0;
            int playerY = 12;

            ConsoleKeyInfo keyInfo;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long prevSecond = stopwatch.ElapsedMilliseconds;

            while(true)
            {
                long currentSecond = stopwatch.ElapsedMilliseconds;

                if (currentSecond - prevSecond >= 100)
                {
                    keyInfo = Console.ReadKey(true);
                    
                    player.Move(keyInfo, ref player);

                    /*switch (keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow: 
                            if (playerY > 0) playerY--; break;
                        case ConsoleKey.DownArrow:
                            if (playerY < Console.WindowHeight - 3) playerY++; break;
                        case ConsoleKey.LeftArrow:
                            if (playerX > 0) playerX--; break;
                        case ConsoleKey.RightArrow:
                            if (playerX < Console.WindowWidth - 3) playerX++; break;
                        case ConsoleKey.Escape: return;
                    }*/
                }

                player.Render();

                /*for(int i = 0; i < player.Length; i++)
                {
                    Console.SetCursorPosition(playerX, playerY + i);
                    Console.WriteLine(player[i]);
                }*/
                prevSecond = currentSecond;
            }
        }
    }
}