using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int Kor = 0;
            Kor = int.Parse(Console.ReadLine); 
            
            이렇게 쓰면 더 짧게 만들 수 있음.
             */
            string iKor, iEng, iMath = null;
            Console.Write("국어 점수를 입력해주세요: ");
            iKor = Console.ReadLine();
            Console.Write("영어 점수를 입력해주세요: ");
            iEng = Console.ReadLine();
            Console.Write("수학 점수를 입력해주세요: ");
            iMath = Console.ReadLine();

            int IKor = int.Parse(iKor);
            int IEng = int.Parse(iEng);
            int IMath = int.Parse(iMath);
            int sum = IKor + IEng + IMath;
            float average = (float)sum / 3;

            Console.WriteLine($"국어 점수: {iKor}");
            Console.WriteLine($"영어 점수: {iEng}");
            Console.WriteLine($"수학 점수: {iMath}");
            Console.WriteLine($"총점: {sum}");
            Console.WriteLine($"수학 점수: {average}");

            Console.WriteLine("");

            string input = null;
            int a = 0;

            Console.Write("정수를 입력해주세요: ");
            input = Console.ReadLine();
            a = int.Parse(input);

            Console.WriteLine($"원래의 값: {a}");
            Console.WriteLine($"비트반전 값: {~a}");
        }
    }
}
