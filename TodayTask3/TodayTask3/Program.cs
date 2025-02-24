using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "검존멋사";
            int att = 100;

            Console.Write($"가지고 있는 소지금을 입력하세요: ");
            int money = int.Parse(Console.ReadLine());

            if (money <= 100) 
            {
                Console.WriteLine($"당신의 캐릭터 이름은 {name}이고,");
                Console.WriteLine($"소유한 무기는 무한의 대검이며,");
                Console.WriteLine($"공격력은 {att} + 1이다.");
            }
            else if (money <= 200)
            {
                Console.WriteLine($"당신의 캐릭터 이름은 {name}이고,");
                Console.WriteLine($"소유한 무기는 카타나이며,");
                Console.WriteLine($"공격력은 {att} + 2이다.");
            }
            else if (money <= 300)
            {
                Console.WriteLine($"당신의 캐릭터 이름은 {name}이고,");
                Console.WriteLine($"소유한 무기는 진은검이며,");
                Console.WriteLine($"공격력은 {att} + 3이다.");
            }
            else if (money <= 400)
            {
                Console.WriteLine($"당신의 캐릭터 이름은 {name}이고,");
                Console.WriteLine($"소유한 무기는 집판검이며,");
                Console.WriteLine($"공격력은 {att} + 4이다.");
            }
            else if (money <= 500)
            {
                Console.WriteLine($"당신의 캐릭터 이름은 {name}이고,");
                Console.WriteLine($"소유한 무기는 엑스칼리버이며,");
                Console.WriteLine($"공격력은 {att} + 5이다.");
            }
            else if (money <= 600)
            {
                Console.WriteLine($"당신의 캐릭터 이름은 {name}이고,");
                Console.WriteLine($"소유한 무기는 유령검이며,");
                Console.WriteLine($"공격력은 {att} + 6이다.");
            }
            else
            {
                Console.WriteLine($"당신의 캐릭터 이름은 {name}이고,");
                Console.WriteLine($"소유한 무기는 전설의 검이며,");
                Console.WriteLine($"공격력은 {att} + 7이다.");
            }
            
        }
    }
}
