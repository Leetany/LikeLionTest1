using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLionTest8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = 10;
            a += 5;   //a = a + 5;

            Console.WriteLine(a);*/

            /*int b = 3;
            b++;                      //후위이기 때문에 이 줄에서 출력할 때는 3이 나옴 ++b일 경우에는 이줄에서도 4로 출력됨
            Console.WriteLine(b);     //여기부터 4로 적용

            --b;
            Console.WriteLine(b);*/

            /*int x = 5, y = 10;
            Console.WriteLine(x < y);
            Console.WriteLine(x == y);*/

            /*bool a = true, b = false;
            Console.WriteLine(a && b);
            Console.WriteLine(a || b);
            Console.WriteLine(!a);*/

            /*int x = 5;
            int y = 3;

            Console.WriteLine(x & y);
            Console.WriteLine(x | y);
            Console.WriteLine(x ^ y);
            Console.WriteLine(~x);*/

            /*int value = 4;
            Console.WriteLine(value << 1);
            Console.WriteLine(value >> 1);*/

            /*int a = 10, b = 20;
            int max = (a > b) ? a : b;
            Console.WriteLine(max);*/

            /*int key = 1;

            string str;
            str = (key == 1) ? "문이 열렸습니다." : "문을 못열었습니다.";

            Console.WriteLine(str);*/

            int result = 10 + 2 * 5;
            Console.WriteLine(result);

            int adjustedResult = (10 + 2) * 5;
            Console.WriteLine(adjustedResult);
        }
    }
}
