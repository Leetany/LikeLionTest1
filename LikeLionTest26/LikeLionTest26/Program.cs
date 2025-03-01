using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLionTest26
{
    class Program
    {
        class Marine
        {
            public string Name;
            public int Cost;

            public Marine()
            {
                Name = "Marine";
                Cost = 50;
            }
            public Marine(string name, int cost)
            {
                Name = name;
                Cost = cost;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"이름 : {Name}, 가격 : {Cost}");
            }
        }

        class SCV
        {
            public string Name;
            public int Cost;
            public SCV()
            {
                Name = "SCV";
                Cost = 50;
            }
            public SCV(string name, int cost)
            {
                Name = name;
                Cost = cost;
            }
            public void ShowInfo()
            {
                Console.WriteLine($"이름 : {Name}, 가격 : {Cost}");
            }
        }
        //this 키워드 사용
        //this 자기 자신 가르킴
        class Barrack
        {
            public string Name;
            public int Cost;
            public Barrack()
            {
                Name = "Barrack";
                Cost = 150;
            }
            public Barrack(string Name, int Cost)
            {
                this.Name = Name;
                this.Cost = Cost;
            }
            public void ShowInfo()
            {
                Console.WriteLine($"이름 : {Name}, 가격 : {Cost}");
            }
        }

        class Mineral
        {
            public int Cost;
            public Mineral()
            {
                Cost = 1500;
            }
            public Mineral(int Cost)
            {
                this.Cost = Cost;
            }
            public void ShowInfo()
            {
                Console.WriteLine($"현재 미네랄 보유량 : {Cost}");
            }
        }

        //Game클래스를 만들어보자
        //static 붙이면 공간이 달라서 바로 쓸 수 있음
        class Game
        {
            public static int mineral;
            public static int gas;
            public static int unitnum;

            public static void ShowInfo()
            {
                Console.WriteLine($"미네랄 {mineral} 가스 {gas} 인구수 {unitnum}");
            }
        }
        static void Main(string[] args)
        {
            Game.mineral = 50;
            Game.gas = 0;
            Game.unitnum = 4;
            Game.ShowInfo();

            Marine marine = new Marine("불꽃테란", 100);
            SCV scv = new SCV("열받은SCV", 70);
            Barrack barrack = new Barrack("불타는배럭", 200);
            //클래스의 배열
            Mineral[] mineral = new Mineral[7];

            //각 배열에 new 객체화
            for(int i = 0; i <mineral.Length;i++)
            {
                mineral[i] = new Mineral();
                mineral[i].ShowInfo();
            }

            marine.ShowInfo();
            scv.ShowInfo();
            barrack.ShowInfo();
        }
    }
}
