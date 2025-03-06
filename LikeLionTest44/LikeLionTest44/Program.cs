using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLionTest44
{
    class Person
    {
        public string Name;
        public int Age;

        public Person() //생성자
        {
            Name = "Unknown";
            Age = 0;
        }

        public Person(string name)
        {
            Name = name;
            Age = 0;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();  //생성자 호출
            Person p1 = new Person("Persia");
            Person p2 = new Person("카타리나", 20);

            Console.WriteLine(p.Name+ ", "+ p.Age);
            Console.WriteLine(p1.Name+ ", "+ p1.Age);
            Console.WriteLine(p2.Name+ ", "+ p2.Age);
            
        }
    }
}
