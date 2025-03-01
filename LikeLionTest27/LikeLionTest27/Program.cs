using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLionTest27
{
    class Program
    {
        /*class Person
        {
            private string name;

            //값 설정하기 (Setter) setter 함수라고 부름
            public void SetName(string newName)
            {
                name = newName;
            }

            //값 가져오기 (Getter)
            public string GetName()
            {
                return name;
            }
        }*/

        //C# 프로퍼티 property
        /*class Person
        {
            private string name;

            public string Name
            {
                //get { return name; }
                //set { name = value; }
                get; set;
            }
        }*/

        //프로퍼티가 자동 구현
        class Person
        {
            private int count = 100;
            public string Name { get; set; } //자동 구현 프로퍼티
            public int Count
            {
                get { return count; }
            }

            public float Balance { get; private set; } //외부 변경 불가

            public void AddBal()
            {
                Balance += 100;
            }
        }

        //마린 클래스
        //프로퍼티 이용해서 이름과 미네랄을 만드시오
        class Marine
        {
            public string Name { get; private set; } = "마린";
            public int Cost { get; set; } = 100;
        }
        static void Main(string[] args)
        {
            //C#에서 get/set 방식의 함수와 프로퍼티 비교
            //C#에서 객체의 값을 읽고(get), 설정(set)하는 
            //방식으로 함수(get/set 메서드) 또는
            //**프로퍼티(Property)**를 사용할 수 있습니다.

            /*Person p1 = new Person();

            p1.SetName("홍길동");
            Console.WriteLine($"이름: {p1.GetName()}");*/

            /*Person p = new Person();
            p.Name = "홍길동";

            Console.WriteLine($"이름 : {p.Name}");*/

            Person p = new Person();
            p.Name = "홍길동";
            //p.Balance = 1000; 불가능
            p.AddBal();

            Console.WriteLine($"이름 : {p.Name} Count : {p.Count} Balance : {p.Balance}");

            Marine m = new Marine();

            Console.WriteLine($"이름: {m.Name}, 가격: {m.Cost}");
        }
    }
}
