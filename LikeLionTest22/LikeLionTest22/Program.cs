using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLionTest22
{
    class Program
    {
        /*struct Rectangle
        {
            public int Width;
            public int Height;

            public int GetArea() => Width * Height;
        }*/

        /*struct Point
        {
            public int x;
            public int y;
        }*/

        struct Grade
        {
            public int Kor;
            public int Math;
            public int Eng;
            public string name;

            public void Print()
            {
                Console.WriteLine($"{name}\t{Kor}\t {Math}\t{Eng}");
            }
        }
        static void Main(string[] args)
        {
            /* //var rect = new Rectangle { Width = 5, Height = 4 };
             Rectangle rect;
             rect.Width = 10;
             rect.Height = 20;

             Console.WriteLine($"Area: {rect.GetArea()}");*/

            /*Point[] points = new Point[2];

            points[0].x = 10;
            points[0].y = 10;

            points[1].x = 20;
            points[1].y = 20;

            foreach(var point in points)
            {
                Console.WriteLine($"Point: ({point.x}, {point.y})");
            }*/

            /*Grade[] grades = new Grade[3];

            grades[0].name = "홍길동";
            grades[1].name = "홍길란";
            grades[2].name = "홍길순";

            for(int i = 0; i<3;i++)
            {
                Console.Write("홍길동의 국어 점수를 입력하세요: ");
                grades[i].Kor = int.Parse(Console.ReadLine());
                Console.Write("홍길란의 수학 점수를 입력하세요: ");
                grades[i].Math = int.Parse(Console.ReadLine());
                Console.Write("홍길순의 영어 점수를 입력하세요: ");
                grades[i].Eng = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("이름  국어  수학  영어");
            foreach(var grade in grades)
            {
                Console.WriteLine($"{grade.name}  {grade.Kor}  {grade.Math}  {grade.Eng}");
            }*/

            //학생 배열 선언
            Grade[] grades = new Grade[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("학생성적을 입력하세요.");
                Console.Write("학생이름: ");
                grades[i].name = Console.ReadLine();
                Console.Write("국어: ");
                grades[i].Kor = int.Parse(Console.ReadLine());
                Console.Write("수학: ");
                grades[i].Math = int.Parse(Console.ReadLine());
                Console.Write("영어: ");
                grades[i].Eng = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("이름    국어   영어   수학");

            foreach(Grade grade in grades)
            {
                grade.Print();
            }
        }
    }
}
