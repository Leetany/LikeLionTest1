using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask6
{
    class Program
    {
        static int Add (int a, int b)
        {
            int sum = 0;
            sum = a + b;
            return sum;
        }

        static int StringLength(string str)
        {
            int L = str.Length;
            return L;
        }

        static int ReturnMAX(int[] numbers)
        {
            int MAX = numbers[0];
            for(int i= 1; i < numbers.Length; i++)
            {
                if (numbers[i] > MAX)
                {
                    MAX = numbers[i];
                }
            }
            return MAX;
        }

        static void Main(string[] args)
        {
            /*//Q1.
            int[] Array1 = new int[5];
            for(int i = 0; i<5; i++)
            {
                Array1[i] = (i + 1) * 10;
                Console.Write($"{Array1[i]} ");
            }
            Console.WriteLine("\n");

            //Q2.
            int[] Array2 = new int[5];
            int sum = 0;
            for (int i = 0; i<5; i++)
            {
                Console.Write($"{i + 1}번째 정수를 입력하세요: ");
                Array2[i] = int.Parse(Console.ReadLine());
                sum += Array2[i];
            }
            Console.WriteLine($"총합: {sum}");

            //Q3.
            int[] Array3 = { 3, 8, 15, 6, 2 };
            int Max = Array3[1];
            for(int i = 1; i<5; i++)
            {
                if (Array3[i] > Max)
                {
                    Max = Array3[i];
                }
            }
            Console.WriteLine("\n"+ Max);*/

            /*//Q4
            for(int i=1; i<=10; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");

            //Q5
            int[] Array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int n = 0;

            while (n < 10)
            {
                if (Array1[n]%2 == 0)
                {
                    Console.Write($"{Array1[n]} ");
                }
                n++;
            }
            Console.WriteLine("\n");

            //Q6
            int[] Array2 = { 1, 2, 3, 4, 5 };
            foreach(int Array in Array2)
            {
                Console.Write($"{Array} ");
            }*/

            //Q7
            int a = 0, b = 0, result = 0;
            Console.Write($"첫번째 숫자를 입력하세요: ");
            a = int.Parse(Console.ReadLine());
            Console.Write($"두번째 번째 숫자를 입력하세요: ");
            b = int.Parse(Console.ReadLine());
            result = Add(a, b);
            Console.WriteLine($"{a}와 {b}의 합: {result}");

            //Q8
            string str = "";
            int L = 0;
            Console.Write($"\n문자열 입력: ");
            str = Console.ReadLine();
            L = StringLength(str);
            Console.WriteLine($"문자열 길이: {L}");
            Console.WriteLine();

            //Q9
            int[] numbers = new int[3];
            int Max = 0;
            for(int i = 0;i <3; i++)
            {
                Console.Write($"{i+1}번째 정수를 입력하세요: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Max = ReturnMAX(numbers);
            Console.WriteLine($"가장 큰 수: {Max}");
        }
    }
}
