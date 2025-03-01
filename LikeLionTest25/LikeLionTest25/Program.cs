using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLionTest25
{
    class Program
    {
        class Person
        {
            public string Name;
            public int Age;

            //기본생성자
            //클래스가 객체로 생성될 대 자동으로 실행되는 특별한 메서드
            //클래스와 같은 이름 가지며, 반환형이 없다 (void도 사용하지 않음)
            //객체를 만들 때 필요한 초기 값을 설정할 때 사용 많이 함.

            public Person()
            {
                Name = "이름 없음";
                Age = 0;
                Console.WriteLine("기본 생성자가 실행됨");
            }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
                Console.WriteLine("매개변수 있는 생성자가 실행됨");
            }

            public void ShowInfo()
            {
                Console.WriteLine($"이름: {Name}, 나이: {Age}");
            }
        }
        static void Main(string[] args)
        {
            /*DateTime now = DateTime.Now;
            Console.WriteLine($"Current Date and Time: {now}");

            TimeSpan duration = new TimeSpan(1, 30, 0);
            Console.WriteLine($"Duration: {duration}");*/

            //클래스
            //

            Person p1 = new Person("철수", 12);   //객체 생성 instance
            p1.ShowInfo();

            Person p2 = new Person("영희", 14);
            p2.ShowInfo();
        }
    }
}
