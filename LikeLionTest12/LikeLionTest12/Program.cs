using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LikeLionTest12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random
            /*Random rand = new Random();

            //0 이상 10 미만의 랜덤 정수 생성

            for(int i = 0; i<10; i++)
            {
                int randomNumber = rand.Next(0, 10);
                Console.WriteLine($"0이상 10 미만의 랜덤 정수: {randomNumber}");
            }

            int randomInRange = 0;
            for (int i = 0; i<100; i++)
            {
                randomInRange = rand.Next(5, 15);
                Console.WriteLine($"5부터 14까지: {randomInRange}");
            }*/

            Random rand = new Random();
            int rnd = 0;

            for(int i = 0; i<20; i++)
            {
                rnd = rand.Next(1, 101);

                if (rnd >= 1 && rnd <= 10)
                {
                    Console.WriteLine("도끼등급 SSS");
                }
                else if (rnd >= 11 && rnd <= 40)
                {
                    Console.WriteLine("도끼등급 SS");
                }
                else
                {
                    Console.WriteLine("도끼등급 S");
                }
                Thread.Sleep(500);
            }
        }
    }
}
