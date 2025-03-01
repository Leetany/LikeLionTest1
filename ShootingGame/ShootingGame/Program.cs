using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShootingGame
{
    //미사일 클래스
    public class BULLET
    {
        public int x;
        public int y;
        public bool fire;
    }
    //플레이어 클래스
    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();  //c언어 함수 가져옴

        public int playerX;   //플레이어 X좌표
        public int playerY;   //플레이어 Y좌표
        public BULLET[,] playerBullets;

        public int Score = 100;
        public Item item = new Item();
        public int itemCount = 1;


        public Player() //생성자
        {
            //플레이어 좌표위치 초기화
            playerX = 0;
            playerY = 12;

            playerBullets = new BULLET[3, 20];

            for(int i = 0; i < itemCount; i++)
            {
                for(int j = 0; j < 20; j++)
                {
                    playerBullets[i, j] = new BULLET();
                    playerBullets[i, j].x = 0;
                    playerBullets[i, j].y = 0;
                    playerBullets[i, j].fire = false;
                }
            }
        }

        public void GameMain()
        {
            //키를 입력하는 부분
            KeyControl();
            //플레이얼를 그려준다.
            PlayerDraw();

            //UI점수
            UIscore();

            if (item.ItemLife)
            {
                item.ItemMove();
                item.ItemDraw();
                CrashItem();
            }
        }

        public void KeyControl()
        {
            int pressKey;  //정수형 변수선언 키값 받을거임 

            if (Console.KeyAvailable) //키가 눌렸을때 true
            {
                pressKey = _getch(); //아스키값 왼쪽 오른쪽

                if (pressKey == 0 || pressKey == 224) // 화살표 키 또는 특수 키 감지
                {
                    pressKey = _getch(); // 실제 키 값 읽기
                }

                switch (pressKey)
                {
                    case 72:  //위쪽방향 아스키코드                    
                        playerY--;
                        if (playerY < 1)
                            playerY = 1;
                        break;
                    case 75:
                        //왼쪽 화살표키
                        playerX--;
                        if (playerX < 0)
                            playerX = 0;
                        break;
                    case 77:
                        //오른쪽
                        playerX++;
                        if (playerX > 75)
                            playerX = 75;
                        break;
                    case 80: //아래
                        playerY++;
                        if (playerY > 21)
                            playerY = 21;
                        break;
                    case 32: //스페이스바
                        for (int i = 0; i < itemCount; i++)
                        {
                            for(int j = 0; j < 20; j++)
                            {
                                if (playerBullets[i,j].fire == false)
                                {
                                    playerBullets[i, j].fire = true;
                                    playerBullets[i, j].x = playerX + 5;
                                    playerBullets[i, j].y = playerY + i;
                                    break;
                                }
                            }
                        }
                        break;
                    case 27:
                        {
                            Environment.Exit(1);
                        }
                        break;
                }
            }
        }

        public void BulletDraws()
        {
            string bullet = "->";

            for(int i = 0; i < itemCount; i++)
            {
                for(int j = 0; j < 20; j++)
                {
                    if (playerBullets[i,j].fire == true)
                    {
                        Console.SetCursorPosition(playerBullets[i, j].x - 1, playerBullets[i,j].y);
                        Console.Write(bullet);

                        playerBullets[i,j].x++;

                        if (playerBullets[i,j].x >78)
                        {
                            playerBullets[i, j].fire = false;
                        }
                    }
                }
            }
        }

        public void PlayerDraw()
        {
            String[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            };//배열 문자열로 그리기

            for (int i = 0; i < player.Length; i++)
            {
                //콘솔좌표 설정 플레이어X 플레이어Y
                Console.SetCursorPosition(playerX, playerY + i);
                //문자열배열 출력
                Console.WriteLine(player[i]);
            }
        }

        //충돌처리
        public void ClashEnemyAndBullet(Enemy enemy)
        {
            for(int i = 0; i < itemCount; i++)
            {
                for(int j = 0; j < 20; j++)
                {
                    if (playerBullets[i,j].fire == true)
                    {
                        if (playerBullets[i,j].y == enemy.enemyY)
                        {
                            if (playerBullets[i,j].x >= (enemy.enemyX -1) && playerBullets[i,j].x <=(enemy.enemyX+1))
                            {
                                item.ItemLife = true;
                                item.itemX = enemy.enemyX;
                                item.itemY = enemy.enemyY;

                                Random rand = new Random();
                                enemy.enemyX = 75;
                                enemy.enemyY = rand.Next(2, 22);

                                playerBullets[i, j].fire = false;

                                Score += 100;
                            }
                        }
                    }
                }
            }
        }

        public void UIscore()
        {
            Console.SetCursorPosition(63, 0);
            Console.Write("┏━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(63, 1);
            Console.Write("┃              ┃");
            Console.SetCursorPosition(65, 1);
            Console.Write("Score : " + Score);
            Console.SetCursorPosition(63, 2);
            Console.Write("┗━━━━━━━━━━━━━━┛");
        }

        //아이템 충돌이 일어나면 양쪽미사일 발사
        public void CrashItem()
        {

            if (playerY + 1 == item.itemY)
            {
                if (playerX >= item.itemX - 2 && playerX <= item.itemX + 2)
                {
                    item.ItemLife = false;

                    if (itemCount < 3)
                        itemCount++;

                    for(int i = 0; i < itemCount; i++)
                    {
                        for(int j = 0; j < 20; j++)
                        {
                            playerBullets[i, j] = new BULLET();
                            playerBullets[i,j].x = 0;
                            playerBullets[i,j].y = 0;
                            playerBullets[i, j].fire = false;
                        }
                    }

                }
            }
        }

    }

    public class Enemy //적 클래스
    {
        public int enemyX;  //X좌표
        public int enemyY;  //Y좌표

        public Enemy()
        {
            //적 좌표 초기화
            enemyX = 77;
            enemyY = 12;
        }

        public void EnemyDraw()//적그리기
        {
            string enemy = "<-0->"; //문자열로 표현
            Console.SetCursorPosition(enemyX, enemyY); //좌표설정
            Console.Write(enemy);//출력
        }

        public void EnmeyMove()
        {
            Random rand = new Random(); //랜덤
            enemyX--; //왼쪽으로 움직임

            if (enemyX < 2) //화면 왼쪽넘어가면 새로 좌표잡아라
            {
                enemyX = 75; //좌표 77
                enemyY = rand.Next(2, 22); //2~21 
            }
        }
    }


    //아이템 클래스
    public class Item
    {
        public string ItemName;
        public string ItemSprite;
        public int itemX = 0;
        public int itemY = 0;
        public bool ItemLife = false;

        public void ItemDraw()
        {
            Console.SetCursorPosition(itemX, itemY);
            ItemSprite = "Item★";
            Console.Write(ItemSprite);
        }

        public void ItemMove()
        {
            //if(itemX <=1 || itemY <=1)
            //{
            //    ItemLife = false;
            //}
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.CursorVisible = false;

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);


            //플레이어 생성
            Player player = new Player();
            Enemy enemy = new Enemy(); //적생성

            //유니티처럼 속도 프레임속도
            int dwTime = Environment.TickCount;  // 1/1000 초가 흐른다.

            while (true) //무한반복
            {
                //0.05초 지연
                if (dwTime + 50 < Environment.TickCount)
                {
                    //현재시간 세팅
                    dwTime = Environment.TickCount;
                    Console.Clear();

                    //플레이어
                    player.GameMain();

                    player.BulletDraws();

                    enemy.EnmeyMove();//적이동
                    enemy.EnemyDraw();//적그리기

                    //충돌처리
                    player.ClashEnemyAndBullet(enemy);
                }
            }
        }
    }
}

