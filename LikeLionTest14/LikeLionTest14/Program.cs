using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLionTest14
{
    class Program
    {
        static void Main(string[] args)
        {
            //배열
            // 0부터 시작한다.

            /*int[] num = new int[3];  //3개 메모리 만들겠다.
            num[0] = 10;
            num[1] = 20;
            num[2] = 30;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(num[i]);
            }*/

            /*int[] numbers = { 1, 2, 3 };
            int[] numbers2 = new int[3];
            int[] numbers3 = new int[] { 1, 2, 3 };

            for(int i=0; i<3; i++)
            {
                Console.WriteLine(numbers[i]);
                Console.WriteLine(numbers2[i]);
                Console.WriteLine(numbers3[i]);
            }*/

            /*string[] fruits = { "사과", "바나나", "오렌지" };

            for(int i = 0; i<3; i++)
            {
                Console.WriteLine(fruits[i]);
            }*/

            /*int[] Kor = new int[3];
            int[] Math = new int[3];
            int[] Eng = new int[3];
            int[] sum = new int[3];
            float[] average = new float[3];

            for(int i = 0; i<3; i++)
            {
                Console.WriteLine($"학생{i}의 국어 점수를 입력하시오.");
                Kor[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"학생{i}의 수학 점수를 입력하시오.");
                Math[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"학생{i}의 영어 점수를 입력하시오.");
                Eng[i] = int.Parse(Console.ReadLine());

                sum[i] = Kor[i] + Math[i] + Eng[i];
                average[i] = (float)sum[i];
            }*/

            /*int[] scores = new int[3];

            scores[0] = 90;
            scores[1] = 85;
            scores[2] = 88;



            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"점수 {i + 1}:{scores[i]}");
            }*/

            /*double value = 123.45678;
            //소수점 자릿 수 설정하는 포맷
            Console.WriteLine(value.ToString("F2"));
            Console.WriteLine($"소수점 둘째자리: {value:F2}");
            Console.WriteLine(String.Format("소수점 둘째 자리: {0:F2}",value));
            //소수점 없이 출력
            Console.WriteLine(value.ToString("F0"));

            double value2 = 12342132112.12323;
            Console.WriteLine(value2.ToString("N2"));*/

            //2차원 배열 
            /*int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i<2; i++)
            {
                
                for(int j=0; j<3; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }*/

            /*int[][] matrix = new int[2][];

            matrix[0] = new int[3];
            matrix[1] = new int[3];


            //값 입력
            matrix[0][0] = 1;
            matrix[0][1] = 2;
            matrix[0][2] = 3;

            matrix[1][0] = 4;
            matrix[1][1] = 5;
            matrix[1][2] = 6;


            //출력
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();

            }*/

            Console.WriteLine("가변 배열");
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5 };
            jaggedArray[2] = new int[] { 6 };


            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j]}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("var 키워드 사용");
            var numbers = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"배열 타입: {numbers.GetType()}");

        }
    }
}
