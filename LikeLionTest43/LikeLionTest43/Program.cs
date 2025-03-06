using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hello;  //네임스페이스 편하게 쓸수 잇다.

namespace Hello
{
    public class Say
    {
        public void SayHello()
        {
            Console.WriteLine("안녕하세요!");
        }
    }
}
namespace LikeLionTest43
{
    class Person
    {
        private string name = "홍길동"; //필드 클래스의 데이터를 저장하는 멤버입니다.

        public void SetName(string n)
        {
            name = n;
        }

        public string GetName()
        { 
            return name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Say sa = new Say();
            sa.SayHello();

            Person p = new Person();  //객체로 만들기 인스턴스
            p.SetName("Bob");
            Console.WriteLine(p.GetName());
        }
    }
}
