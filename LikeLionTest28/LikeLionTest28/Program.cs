using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace LikeLionTest28
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("프로그램 종료");

            string path = Environment.GetEnvironmentVariable("PATH");
            Console.WriteLine($"PATH: {path}");

            Environment.Exit(0);*/

            /*Random rand = new Random();

            int randomNumber = rand.Next(1, 101); //1부터 100까지
            Console.WriteLine("랜덤 숫자 : " + randomNumber);*/

            //프로그램 실행 시간 구하기
            /*Stopwatch stopwatch = Stopwatch.StartNew();

            //실행 코드
            for (int i = 0; i<100; i++)
            {
                Thread.Sleep(1);
            } // 0.001

            stopwatch.Stop();

            Console.WriteLine("for문 시간 : " + stopwatch.ElapsedMilliseconds + "ms");*/

            //정규식
            /*string input = "Hello, my phone number is 010-1234-5678";
            string pattern = @"\d{3}-\d{4}-\d{4}"; //전화 번호 패턴

            bool isMatch = Regex.IsMatch(input, pattern);
            Console.WriteLine($"전화번호가 존재하는가? {isMatch}");*/


        }
    }
}
