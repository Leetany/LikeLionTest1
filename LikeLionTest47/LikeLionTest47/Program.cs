using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLionTest47
{
    class Parent
    {
        public Parent (string message)
        {
            Console.WriteLine("부모생성자" + message);

        }
    }

    class Child : Parent
    {
        public Child():base("하하하하성공") //부모 생성자 호출
        {
            Console.WriteLine("자식생성자 호출");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child(); //객체 생성 시작
        }
    }
}
