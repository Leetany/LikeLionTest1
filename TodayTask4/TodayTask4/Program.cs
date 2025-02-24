using System;

namespace TodayTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 0;
            int MAX = 0;

            Console.WriteLine("3개의 정수를 입력하시오.");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            
            if (a > b)
            {
                MAX = (a > c) ? a : c;
                Console.WriteLine($"최댓값: {MAX}");
            }
            else if(a < b)
            {
                MAX = (b > c) ? b : c;
                Console.WriteLine($"최댓값: {MAX}");
            }
            else
            {
                Console.WriteLine("정수를 입력하십시오.");
            }

            int score = 0;

            Console.Write("점수를 입력하세요.");
            score = int.Parse(Console.ReadLine());

            if (score >= 90)
            {
                Console.WriteLine("A 학점");
            }
            else if (score >=80 && score <90)
            {
                Console.WriteLine("B 학점");
            }
            else if (score >= 70 && score < 80)
            {
                Console.WriteLine("C 학점");
            }
            else if (score >= 60 && score < 70)
            {
                Console.WriteLine("D 학점");
            }
            else
            {
                Console.WriteLine("F 학점");
            }

            int x= 0, y = 0, result = 0;
            string executor = "";

            Console.WriteLine("사칙연산 계산기 입니다.");
            Console.WriteLine("숫자 2개를 입력해주세요.");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("+, -, *, / 중에서만 입력해 주세요.");
            executor = Console.ReadLine();
            

            if (executor == "+")
            {
                result = x + y;
                Console.WriteLine($"결과: {result}");
            }
            else if (executor == "-")
            {
                result = x - y;
                Console.WriteLine($"결과: {result}");
            }
            else if (executor == "*")
            {
                result = x * y;
                Console.WriteLine($"결과: {result}");
            }
            else if (executor == "/")
            {
                if (y == 0)
                {
                    Console.WriteLine("이건 무한대로 가는 길이야.");
                }
                else
                {
                    result = x / y;
                    Console.WriteLine($"결과: {result}");
                }
            }
            else
            {
                Console.WriteLine("+, -, *, / 중에서만 입력해 주세요.");
            }
        }
    }
}
