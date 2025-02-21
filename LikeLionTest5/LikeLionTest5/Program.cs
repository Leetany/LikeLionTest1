using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLionTest5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int integerNum = 10;         //정수 데이터
            float floatNum = 3.14f;        //단정밀도 실수 
            double doubleNum = 3.14159;    //배정밀도 실수

            Console.WriteLine(integerNum);
            Console.WriteLine(floatNum);
            Console.WriteLine(doubleNum);*/

            /*int intValue = -100;        //4바이트 크기의 정수
            long longValue = 1234567890L; //8바이트 크기의 정수

            Console.WriteLine(intValue);
            Console.WriteLine(longValue);*/

            /*sbyte signedByte = -50;        //1바이트 크기
            short signedShort = -32000;    //2바이트 크기
            int signedInt = -2000000000;   //4바이트 크기

            Console.WriteLine(signedByte);
            Console.WriteLine(signedShort);
            Console.WriteLine(signedInt);*/

            /*byte unsignedByte = 255;         //1바이트 크기
            ushort unsignedShort = 65000;    //2바이트 크기
            uint unsignedInt = 4000000000;   //4바이트 크기

            Console.WriteLine(unsignedByte);
            Console.WriteLine(unsignedShort);
            Console.WriteLine(unsignedInt);*/

            /*float singlePrecision = 3.14f;                     //단정밀도 실수(4바이트)
            double doublePrecision = 3.1415926535;             //배정밀도 실수(8바이트)
            decimal highPrecision = 3.141592565544436677m;     //고정밀도 (16바이트)

            Console.WriteLine(singlePrecision);
            Console.WriteLine(doublePrecision);
            Console.WriteLine(highPrecision);*/

            /*int integerValue = 100;           //기본 정수형(int)
            long longValue = 100L;            //정수형(long)
            float floatValue = 3.14f;         //실수형(float)
            double doubleValue = 3.14;        //기본 실수형(double)
            decimal decimalValue = 3.14m;     //고정밀도 실수형(decimal)

            Console.WriteLine(integerValue);
            Console.WriteLine(longValue);
            Console.WriteLine(floatValue);
            Console.WriteLine(doubleValue);
            Console.WriteLine(decimalValue);*/

            //char형식: 단일 문자를 표현 2바이트 크기
            /*char letter = 'A';  //문자 'A' 저장
            char symbol = '#';  //특수 기호 저장
            char number = '9';  //숫자 형태의 문자 저장 (문자 '9', 숫자 9아님)

            Console.WriteLine(letter);
            Console.WriteLine(symbol);
            Console.WriteLine(number);*/

            //string 형식: 여러 문자를 저장
            /*string greeting = "Hello, World!";
            string name = "Alice";

            Console.WriteLine(greeting);
            Console.WriteLine(name);
            Console.WriteLine(greeting + " " +name);*/

            //bool 형식: 참(True) 또는 거짓(False)
            /*bool isRunning = true;
            bool isFinished = false;

            Console.WriteLine(isRunning);
            Console.WriteLine(isFinished);*/

            /*const double Pi = 3.14159;
            const int MaxScore = 100;

            Console.WriteLine(Pi);
            Console.WriteLine(MaxScore);*/

            /*System.Int32 number = 123;
            System.String text = "Hello";
            System.Boolean flag = true;

            Console.WriteLine(number);
            Console.WriteLine(text);
            Console.WriteLine(flag);*/

            //int 래퍼 형식의 메서드 활용
            int number = 123;
            string numberAsString = number.ToString();

            //bool 래퍼 형식의 메서드 활용
            bool flag = true;
            string flagAsString = flag.ToString();

            Console.WriteLine(numberAsString);
            Console.WriteLine(flagAsString);
        }
    }
}
