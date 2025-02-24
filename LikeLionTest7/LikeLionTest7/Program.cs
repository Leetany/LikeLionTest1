using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LikeLionTest7
{
    class Program
    {
        static void Main(string[] args)
        {
            //~ 비트 반전

            /*int num = 10;               //00000000 00000000 00000000 00001010
            int result = ~num;          //11111111 11111111 11111111 11110101 2의 보수법으로 계산 해서 -11

            Console.WriteLine("원래값: " + num);
            Console.WriteLine("~ 연산자 적용 후: "+ result);*/

            /*double pi = 3.14;
            int integerPi = (int)pi;

            Console.WriteLine(integerPi);*/

            /*int iKor = 90;
            int iEng = 75;
            int iMath = 86;

            int sum = 0;
            float average = 0.0f;

            sum = iKor + iEng + iMath;
            average = (float)sum / 3;

            Console.WriteLine($"총점: {sum}");
            Console.WriteLine($"평균: {average}");*/

            /*int a = 10, b = 3;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);*/

            string firstName = "Alice";
            string lastName = "Smith";

            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
