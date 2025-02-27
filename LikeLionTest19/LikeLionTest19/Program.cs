using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLionTest19
{
    class Program
    {
        //C#화살표 함수
        //C#에서 화살표 함수 => 람다 표현식 이라고도 하며
        //간결한 방식으로 함수를 정의할 수 있습니다.
        static int Add(int a, int b) => a + b;
        static void PrintMessageArrow() => Console.WriteLine("안녕하세요!");
        static void Main(string[] args)
        {
            Console.WriteLine(Add(3, 5));
            PrintMessageArrow();

            //Math클래스 사용
            //수학적 계산
            Console.WriteLine($"Pi: {Math.PI}");
            Console.WriteLine($"Square root of 25: {Math.Sqrt(25)}");
            Console.WriteLine($"Power(2^3): {Math.Pow(2, 3)}");
            Console.WriteLine($"Round(3.75): {Math.Round(3.75)}");

        }
    }
}
