using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*class SimpleCollection : IEnumerable<int>
{
    private int[] data = { 1, 2, 3, 4, 5 };
    public IEnumerator<int> GetEnumerator()
    {
        foreach (var item in data)
        {
            yield return item;
        }
    }
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}*/
namespace LikeLionTest33
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var collection = new SimpleCollection();

            foreach(var i in collection)
            {
                Console.WriteLine(i);
            }*/

            //dictionary
            /*Dictionary<string, int> ages = new Dictionary<string, int>();

            ages["금도끼"] = 10;
            ages["은도끼"] = 5;
            ages["돌도끼"] = 1;

            foreach(var pair in ages)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }*/

            //null 값
            //참조형식 null을 가질 수 있으며, 값 형식은 기본적으로 null을 가질 수 없습니다.

            /*string str = null;

            if(str == null)
            {
                Console.WriteLine("str is null");
            }*/

            /*int? nullableInt = null;

            Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");

            nullableInt = 10;

            Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");*/

            //null 값을 다루느느 연산자 소개하기 ??, ?. 연산자
            //?? 연산자를 사용해 null인 경우 대체값ㅇ르 제공하고, ?.은 null안전 접근을 합니다.

            /*string str = null;

            Console.WriteLine(str ?? "DefaultValue"); //str이 null이면 "Default Value"
            str = "Hello";

            Console.WriteLine(str?.Length); //str이 null이 아니므로 길이 출력*/

            int[] numbers = { 1, 2, 3, 4, 5 };
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            foreach(var num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            string str = null;

            Console.WriteLine(str ?? "DefaultValue");

            if(str != null)
            {
                Console.WriteLine("str is not null");
            }
            else
            {
                Console.WriteLine("DefaultValue");
            }
        }
    }
}
