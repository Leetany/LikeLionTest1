using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LikeLionTest15
{
    class Program
    {
        //1단계 함수
        //반환형 함수이름 (매개변수)
        //{
        //}

        /*static void Loading()
        {
            Console.WriteLine("로딩중.");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중..");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중...");
            Thread.Sleep(1000);
        }

        //2단계
        //입력
        static void AttackFunction(int _Attack)
        {
            Console.WriteLine("공격력은: " + _Attack);
        }

        //3단계
        //출력
        static int BaseAttack()
        {
            int attack = 10;

            return attack;
        }*/

        /*static int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }*/

        static void Main(string[] args)
        {
            /*int Attack = 0;
            int baseAttack = 0;
            Console.WriteLine("캐릭터 공격력을 입력: ");
            Attack = int.Parse(Console.ReadLine());

            baseAttack = BaseAttack();
            AttackFunction(baseAttack+Attack);*/

            /*int result = Add(10, 20);
            Console.WriteLine($"10 + 20 = {result}");*/

            string[] fruits = { "사과", "바나나", "체리" };

            foreach(string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
