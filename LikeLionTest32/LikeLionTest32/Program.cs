using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace LikeLionTest32
{
    class Program
    {
        //제네릭 사용하기(Generics)
        //<T> 제네릭 클래스를 사용하면 특정 타입에 종속되지 않는 범용 클래스를 만들수있습니다.

        /*class Cup<T>
        {
            public T Content { get; set; }
        }*/
        static void Main(string[] args)
        {
            /*Cup<string> CupOfString = new Cup<string> { Content = "Coffee" };
            Cup<int> CupOfInt = new Cup<int> { Content = 42 };
            Console.WriteLine($"CupOfString : {CupOfString.Content}");
            Console.WriteLine($"CupOfString : {CupOfInt.Content}");*/

            /*Stack<int> stack = new Stack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            while(stack.Count>0)
            {
                Console.WriteLine(stack.Pop());
            }*/

            /*List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            names.Add("Dave");

            foreach(var name in names)
            {
                Console.WriteLine(name);
            }*/

            //IEnumerator
            //C#컬렉션 순회 반복할 수 있는 인터페이스

            ArrayList list = new ArrayList { "Apple", "Banana", "Cherry" };

            IEnumerator enumerator = list.GetEnumerator(); //열거자 가져오기

            while(enumerator.MoveNext()) //다음 요소가 있는지 확인
            {
                Console.WriteLine(enumerator.Current);
            }    
        }
    }
}
